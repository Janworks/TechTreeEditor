﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using DRSLibrary;
using TechTreeEditor.TechTreeStructure;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;

namespace TechTreeEditor
{
	public partial class UnitRenderForm : Form
	{
		#region Konstanten

		/// <summary>
		/// Die Standard-Hintergrundfarbe.
		/// </summary>
		private Color COLOR_BACKGROUND = Color.FromArgb(243, 233, 212);

		/// <summary>
		/// Die Standard-Schattenfarbe.
		/// </summary>
		private Color COLOR_SHADOW = Color.FromArgb(100, 100, 100, 100);

		/// <summary>
		/// Die Zeit in Millisekunden, die zwischen zwei Frames im Rendermodus gewartet wird.
		/// </summary>
		private int RENDER_FRAME_TIME = 40;

		/// <summary>
		/// Der vertikale Abstand der Eckpunkte eines Tiles zu dessen Mittelpunkt.
		/// </summary>
		private double TILE_VERTICAL_OFFSET = 11 * Math.Sqrt(5);

		/// <summary>
		/// Der horizontale Abstand der Eckpunkte eines Tiles zu dessen Mittelpunkt.
		/// </summary>
		private double TILE_HORIZONTAL_OFFSET = 22 * Math.Sqrt(5);

		#endregion Konstanten

		#region Variablen

		/// <summary>
		/// Gibt an, ob die OpenGL-Zeichenfläche bereits initialisiert wurde.
		/// </summary>
		private bool _glLoaded = false;

		/// <summary>
		/// Gibt an, ob gerade die zurendernde Einheit aktualisiert wird. Dies unterbindet Ereignisse von Buttons o.ä..
		/// </summary>
		private bool _updatingUnit = false;

		/// <summary>
		/// Die zugrundeliegenden Projektdaten.
		/// </summary>
		private TechTreeFile _projectFile = null;

		/// <summary>
		/// Die zu rendernde Einheit.
		/// </summary>
		private TechTreeUnit _renderUnit = null;

		/// <summary>
		/// Die Farbtabelle zu Rendern von Grafiken.
		/// </summary>
		private BitmapLibrary.ColorTable _pal50500 = null;

		/// <summary>
		/// Die Graphics-DRS mit Grafiken.
		/// </summary>
		private DRSFile _graphicsDRS = null;

		/// <summary>
		/// Die aktuell gezeigte Grafik.
		/// </summary>
		private GraphicMode _currShowedGraphic = GraphicMode.Attacking;

		/// <summary>
		/// Die einzelnen zu zeichnenden Animationen.
		/// </summary>
		private List<Animation> _animations;

		/// <summary>
		/// Die Vergrößerung der zu zeichnenden Animationen.
		/// </summary>
		private float _zoom = 1.0f;

		/// <summary>
		/// Der Faktor zur Rendergeschwindigkeit.
		/// </summary>
		private float _speedMult = 1.0f;

		/// <summary>
		/// Die Position der Maus beim letzten Betätigen der linken Maustaste im Zeichenfeld.
		/// </summary>
		private Point _mouseClickLocation;

		/// <summary>
		/// Die Verschiebung der Zeichenfläche.
		/// </summary>
		private Point _renderingTranslation = new Point(0, 0);

		#endregion Variablen

		#region Funktionen

		/// <summary>
		/// Konstruktor.
		/// </summary>
		private UnitRenderForm()
		{
			// Steuerelemente laden
			InitializeComponent();

			// Steuerelement-Einstellungen laden
			Location = Properties.Settings.Default.UnitRenderFormLocation;
			Size = Properties.Settings.Default.UnitRenderFormSize;
			WindowState = Properties.Settings.Default.UnitRenderFormWindowState;

			// Render-Timer-Intervall setzen
			_renderTimer.Interval = RENDER_FRAME_TIME;

			// Animationsliste anlegen
			_animations = new List<Animation>();

			// Farbpalette laden
			_pal50500 = new BitmapLibrary.ColorTable(new BitmapLibrary.JASCPalette(new IORAMHelper.RAMBuffer(Properties.Resources.pal50500)));

			// Mausrad-Ereignis auf der Zeichenfläche behandeln
			_drawPanel.MouseWheel += _drawPanel_MouseWheel;
		}

		/// <summary>
		/// Erstellt ein neues Einheiten-Render-Fenster.
		/// </summary>
		/// <param name="projectFile">Das zugrundeliegende Projekt.</param>
		public UnitRenderForm(TechTreeFile projectFile)
			: this()
		{
			// Parameter merken
			_projectFile = projectFile;

			// Graphics-DRS laden
			string graDRS = Path.GetFullPath(_projectFile.GraphicsDRSPath);
			if(File.Exists(graDRS))
			{
				// Laden
				_graphicsDRSTextBox.Text = graDRS;
				_loadDRSButton_Click(this, EventArgs.Empty);
			}
		}

		/// <summary>
		/// Initialisiert OpenGL und die Zeichenfläche.
		/// </summary>
		private void InitDrawPanel()
		{
			// Ich bin dran
			_drawPanel.MakeCurrent();

			// Panel leeren
			GL.ClearColor(COLOR_BACKGROUND);

			// Texturen aktivieren
			GL.Enable(EnableCap.Texture2D);

			// 2D-Grafik benötigt keine Tiefenerkennung
			GL.Disable(EnableCap.DepthTest);

			// Blending einschalten
			GL.Enable(EnableCap.Blend);
			GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

			// Blickwinkel erstellen
			SetupDrawPanelViewPort();

			// Alles ist geladen
			_glLoaded = true;
		}

		/// <summary>
		/// Erstellt die Koordinaten und Blickwinkel der Zeichenfläche.
		/// </summary>
		private void SetupDrawPanelViewPort()
		{
			// Ich bin dran
			_drawPanel.MakeCurrent();

			// Blickwinkel erstellen
			GL.MatrixMode(MatrixMode.Projection);
			GL.LoadIdentity();
			GL.Ortho(0.0, _drawPanel.Width, _drawPanel.Height, 0.0, -1.0, 1.0); // Pixel oben links ist (0, 0)
			GL.Viewport(0, 0, _drawPanel.Width, _drawPanel.Height);

			// Zeichenmodus laden
			GL.MatrixMode(MatrixMode.Modelview);
		}

		/// <summary>
		/// Aktualisiert die zugrundeliegende Projektdatei.
		/// </summary>
		/// <param name="projectFile">Die neue Projektdatei.</param>
		public void UpdateProjectFile(TechTreeFile projectFile)
		{
			// Aktualisieren
			_projectFile = projectFile;

			// Neuzeichnen
			_drawPanel.Invalidate();
		}

		/// <summary>
		/// Aktualisiert die zu rendernde Einheit.
		/// </summary>
		/// <param name="renderUnit">Die neue zu rendernde Einheit.</param>
		public void UpdateRenderUnit(TechTreeUnit renderUnit)
		{
			// Merken
			_renderUnit = renderUnit;

			// Einheit definiert?
			if(renderUnit == null || renderUnit.DATUnit == null)
				return;

			// Je nach Einheitentyp Buttons (de-)aktivieren
			_updatingUnit = true;
			if(renderUnit.DATUnit.Type >= GenieLibrary.DataElements.Civ.Unit.UnitType.DeadFish)
				_graMovingButton.Enabled = true;
			else
			{
				// Button deaktivieren und deselektieren
				_graMovingButton.Enabled = false;
				if(_graMovingButton.Checked)
				{
					// Stehende Grafik auswählen
					_graStandingButton.Select();
					_currShowedGraphic = GraphicMode.Standing;
				}
			}
			if(renderUnit.DATUnit.Type >= GenieLibrary.DataElements.Civ.Unit.UnitType.Type50)
				_graAttackingButton.Enabled = true;
			else
			{
				// Button deaktivieren und deselektieren
				_graAttackingButton.Enabled = false;
				if(_graAttackingButton.Checked)
				{
					// Stehende Grafik auswählen
					_graStandingButton.Select();
					_currShowedGraphic = GraphicMode.Standing;
				}
			}

			// Fertig
			_updatingUnit = false;

			// Zu rendernde Grafik erstellen
			PreprocessRenderedGraphic();

			// Neuzeichnen
			_drawPanel.Invalidate();
		}

		/// <summary>
		/// Lädt die zu zeigende Grafik und bereitet diese vor, sodass sie effizient gerendert werden kann.
		/// </summary>
		private void PreprocessRenderedGraphic()
		{
			// Kontext holen
			_drawPanel.MakeCurrent();

			// Alte Animationen löschen
			foreach(Animation anim in _animations)
			{
				// Stoppen und Textur freigeben
				anim.StopAnimation();
				if(anim.TextureID > 0)
					GL.DeleteTexture(anim.TextureID);
			}
			_animations.Clear();
			_angleField.Maximum = 0;

			// Ist eine Einheit geladen?
			if(_renderUnit == null || _renderUnit.DATUnit == null || _graphicsDRS == null)
				return;

			// Ggf. Annexes durchgehen
			if(_renderUnit is TechTreeBuilding)
				foreach(var annex in ((TechTreeBuilding)_renderUnit).AnnexUnits)
					if(annex != null && annex.Item1 != null)
					{
						// Annex-Einheit abrufen
						TechTreeBuilding annexUnit = annex.Item1;

						// Annex-Grafik-ID holen
						int annexGraID = -1;
						switch(_currShowedGraphic)
						{
							case GraphicMode.Attacking:
								annexGraID = annexUnit.DATUnit.Type50.AttackGraphic;
								break;
							case GraphicMode.Falling:
								annexGraID = annexUnit.DATUnit.DyingGraphic1;
								break;
							case GraphicMode.Moving:
								annexGraID = annexUnit.DATUnit.DeadFish.WalkingGraphic1;
								break;
							case GraphicMode.Standing:
								annexGraID = annexUnit.DATUnit.StandingGraphic1;
								break;
						}

						// Grafik abrufen
						if(!_projectFile.BasicGenieFile.Graphics.ContainsKey(annexGraID))
							return;
						GenieLibrary.DataElements.Graphic annexRenderGraphic = _projectFile.BasicGenieFile.Graphics[annexGraID];

						// Offset berechnen und Animation erstellen
						double annexX = TILE_HORIZONTAL_OFFSET * (annex.Item3 + annex.Item2);
						double annexY = TILE_VERTICAL_OFFSET * (annex.Item3 - annex.Item2);
						CreateAnimationFromGraphic(annexRenderGraphic, new Point((int)Math.Round(annexX), (int)Math.Round(annexY)), true);
					}


			// Falls die Einheit eine Obereinheit hat, diese zeichnen
			TechTreeUnit renderUnit = _renderUnit;
			if(renderUnit is TechTreeBuilding && ((TechTreeBuilding)renderUnit).HeadUnit != null)
				renderUnit = ((TechTreeBuilding)renderUnit).HeadUnit;

			// Grafik-ID holen
			int graID = -1;
			switch(_currShowedGraphic)
			{
				case GraphicMode.Attacking:
					graID = renderUnit.DATUnit.Type50.AttackGraphic;
					break;
				case GraphicMode.Falling:
					graID = renderUnit.DATUnit.DyingGraphic1;
					break;
				case GraphicMode.Moving:
					graID = renderUnit.DATUnit.DeadFish.WalkingGraphic1;
					break;
				case GraphicMode.Standing:
					graID = renderUnit.DATUnit.StandingGraphic1;
					break;
			}

			// Grafik abrufen
			if(!_projectFile.BasicGenieFile.Graphics.ContainsKey(graID))
				return;
			GenieLibrary.DataElements.Graphic renderGraphic = _projectFile.BasicGenieFile.Graphics[graID];

			// Animation erstellen
			CreateAnimationFromGraphic(renderGraphic, new Point(0, 0), true);

			// Zentrieren
			_renderingTranslation = new Point(0, 0);

			// Falls Rendering läuft, Animationen starten
			if(_renderTimer.Enabled)
				foreach(Animation anim in _animations)
					anim.StartAnimation();
		}

		/// <summary>
		/// Erstellt eine Animation anhand der gegebenen DAT-Grafik.
		/// </summary>
		/// <param name="graphic">Die Grafik, anhand der die Animation erstellt werden soll.</param>
		/// <param name="offset">Der gewünschte Versatz der Grafik beim Rendervorgang.</param>
		/// <param name="parseDeltas">Gibt an, ob die Grafik-Delta-Werte zu eigenständigen Animationen umgewandelt werden sollen.</param>
		/// <returns></returns>
		private void CreateAnimationFromGraphic(GenieLibrary.DataElements.Graphic graphic, Point offset, bool parseDeltas)
		{
			// Animation erstellen
			Animation animation = new Animation();
			int animationIndex = _animations.Count;

			// Zur Grafik gehörende SLP-Datei abrufen
			if(graphic.SLP >= 0 && _graphicsDRS.ResourceExists((uint)graphic.SLP))
			{
				// SLP laden
				SLPLoader.Loader renderSLP = new SLPLoader.Loader(new IORAMHelper.RAMBuffer(_graphicsDRS.GetResourceData((uint)graphic.SLP)));

				// Die DAT-Framezahl sollte das Produkt aus Achsenzahl und SLP-Framezahl sein => nicht benötigte Achsenframes ignorieren
				uint slpFrameCount = renderSLP.FrameCount;
				uint slpAngleCount = (graphic.MirroringMode > 0 ? (uint)(graphic.AngleCount / 2 + 1) : graphic.AngleCount);
				if((slpFrameCount / graphic.FrameCount) != slpAngleCount)
					slpFrameCount = slpAngleCount * graphic.FrameCount;

				// Mindestens ein Frame ist sinnvoll, und mehr als die vorhandenen können auch nicht gerendert werden
				if(slpFrameCount > 0 && slpFrameCount <= renderSLP.FrameCount)
				{
					// Ein paar Parameter setzen
					animation.FrameCount = graphic.AngleCount * graphic.FrameCount;
					animation.BaseFrameTime = graphic.FrameRate * 1000.0f;
					animation.SpeedMultiplier = _speedMult;
					animation.AngleCount = graphic.AngleCount;

					// Achsenauswahlfeld aktualisieren
					_angleField.Maximum = Math.Max(_angleField.Maximum, animation.AngleCount - 1) + 1;

					// Maximale Frame-Größe berechnen: Diese setzt sich zusammen aus der Breite der einzelnen SLP-Frames und den zugehörigen Frame-Ankern, ausgehend vom Mittelpunkt.
					// => Beim Rendern muss später nur noch die Textur durchgeschoben werden, Anker sind nicht mehr zu berücksichtigen.
					int offsetLeft = 0;
					int offsetRight = 0;
					int offsetTop = 0;
					int offsetBottom = 0;
					for(int f = 0; f < slpFrameCount; ++f)
					{
						// Werte berechnen
						offsetLeft = Math.Max(offsetLeft, renderSLP._frameInformationenHeaders[f].XAnker);
						offsetRight = Math.Max(offsetRight, (int)renderSLP._frameInformationenHeaders[f].Breite - renderSLP._frameInformationenHeaders[f].XAnker);
						offsetTop = Math.Max(offsetTop, renderSLP._frameInformationenHeaders[f].YAnker);
						offsetBottom = Math.Max(offsetBottom, (int)renderSLP._frameInformationenHeaders[f].Höhe - renderSLP._frameInformationenHeaders[f].YAnker);
					}

					// Bei Spiegelachsen die horizontalen Offsets gleichsetzen
					if(graphic.MirroringMode > 0)
						offsetLeft = offsetRight = Math.Max(offsetLeft, offsetRight);

					// Framegrößen berechnen
					int frameWidth = offsetLeft + offsetRight;
					if(frameWidth % 2 == 1)
						++frameWidth;
					int frameHeight = offsetTop + offsetBottom;
					if(frameHeight % 2 == 1)
						++frameHeight;
					animation.FrameBounds = new Size(frameWidth, frameHeight);
					animation.RenderOffset = new Point(offset.X - offsetLeft, offset.Y - offsetTop);

					// Eine ungefähr quadratische Textur soll am Ende herauskommen
					animation.FramesPerLine = (int)Math.Sqrt(animation.FrameCount);
					int textureWidth = (int)NextPowerOfTwo((uint)animation.FramesPerLine * (uint)frameWidth);
					int textureHeight = (int)NextPowerOfTwo((uint)Math.Round((double)animation.FrameCount / animation.FramesPerLine) * (uint)frameHeight);
					animation.TextureBounds = new Size(textureWidth, textureHeight);

					// Frames nacheinander auf Bitmap zeichnen
					using(Bitmap textureBitmap = new Bitmap(textureWidth, textureHeight))
					{
						// Bitmap-Grafikobjekt abrufen
						using(Graphics g = Graphics.FromImage(textureBitmap))
						{
							// Frames durchlaufen
							int i = 0;
							int j = 0;
							for(uint f = 0; f < slpFrameCount; ++f)
							{
								// Frame-Bitmap holen und zeichnen
								using(Bitmap currFrame = renderSLP.getFrameAsBitmap(f, _pal50500, SLPLoader.Loader.Masks.Graphic, Color.FromArgb(0, 0, 0, 0), COLOR_SHADOW))
									g.DrawImage(currFrame, j * frameWidth + offsetLeft - renderSLP._frameInformationenHeaders[(int)f].XAnker, i * frameHeight + offsetTop - renderSLP._frameInformationenHeaders[(int)f].YAnker);

								g.FillRectangle(Brushes.Gold, j * frameWidth + offsetLeft - 4, i * frameHeight + offsetTop - 4, 8, 8);

								// Koordinaten erhöhen
								if(++j >= animation.FramesPerLine)
								{
									// Neue Zeile
									++i;
									j = 0;
								}
							}

							// Ggf. Spiegelframes erzeugen => Alle Achsen außer Norden und Süden werden gespiegelt
							if(graphic.MirroringMode > 0)
								for(int a = (int)(slpFrameCount / graphic.FrameCount) - 2; a > 0; --a)
									for(uint f = (uint)a * graphic.FrameCount; f < (a + 1) * graphic.FrameCount; ++f)
									{
										// Frame-Bitmap holen und zeichnen
										using(Bitmap currFrame = renderSLP.getFrameAsBitmap(f, _pal50500, SLPLoader.Loader.Masks.Graphic, Color.FromArgb(0, 0, 0, 0), COLOR_SHADOW))
										{
											// Bild spiegeln
											currFrame.RotateFlip(RotateFlipType.RotateNoneFlipX);

											// Bild in Textur zeichnen
											g.DrawImage(currFrame, j * frameWidth + offsetLeft - (renderSLP._frameInformationenHeaders[(int)f].Breite - renderSLP._frameInformationenHeaders[(int)f].XAnker), i * frameHeight + offsetTop - renderSLP._frameInformationenHeaders[(int)f].YAnker);
										}

										g.FillRectangle(Brushes.Gold, j * frameWidth + offsetLeft - 4, i * frameHeight + offsetTop - 4, 8, 8);

										// Koordinaten erhöhen
										if(++j >= animation.FramesPerLine)
										{
											// Neue Zeile
											++i;
											j = 0;
										}
									}
						}

						textureBitmap.Save("R:\\" + graphic.SLP + ".png");

						// Textur anlegen und binden
						animation.TextureID = GL.GenTexture();
						GL.BindTexture(TextureTarget.Texture2D, animation.TextureID);

						// Textur soll bei Verkleinerung/Vergrößerung scharf (= pixelig) bleiben
						GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
						GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

						// Bild-Bits sperren
						BitmapData data = textureBitmap.LockBits(new Rectangle(0, 0, textureWidth, textureHeight), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

						// Textur an OpenGL übergeben
						GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, textureWidth, textureHeight, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);

						// Bild-Bits wieder freigeben
						textureBitmap.UnlockBits(data);

						// Texturbindung beenden
						GL.BindTexture(TextureTarget.Texture2D, 0);
					}

					// Animation speichern
					_animations.Add(animation);
				}
			}

			// Deltas erstellen?
			if(parseDeltas)
			{
				// Deltas durchlaufen
				foreach(var delta in graphic.Deltas)
				{
					// Gültiges Delta?
					if(!_projectFile.BasicGenieFile.Graphics.ContainsKey(delta.GraphicID))
					{
						// Bei ID -1 wird die Basisgrafik neu gezeichnet, d.h. nach vorn gebracht
						if(delta.GraphicID == -1 && _animations.Count > animationIndex)
						{
							// Element ans Ende schieben
							_animations.MoveToEnd(animationIndex);

							// Neuen Index merken
							animationIndex = _animations.Count - 1;
						}

						// Nächstes Delta
						continue;
					}

					// Delta-Grafik abrufen und Animation erstellen
					CreateAnimationFromGraphic(_projectFile.BasicGenieFile.Graphics[delta.GraphicID], new Point(offset.X + delta.DirectionX, offset.Y + delta.DirectionY), false);
				}
			}
		}

		/// <summary>
		/// Aktualisiert die Aktualisierungsgeschwindigkeiten der einzelnen Animationen.
		/// </summary>
		/// <param name="newSpeedMult">Der neue Geschwindigkeitsfaktor.</param>
		private void UpdateAnimationSpeed(float newSpeedMult)
		{
			// Faktoren aktualisieren
			_speedMult = newSpeedMult;
			foreach(Animation anim in _animations)
				anim.SpeedMultiplier = _speedMult;
		}

		#endregion Funktionen

		#region Ereignishandler

		private void UnitRenderForm_Load(object sender, EventArgs e)
		{
			// OpenGL und das Zeichenpanel initialisieren
			if(!DesignMode)
				InitDrawPanel();
		}

		private void _drawPanel_Paint(object sender, PaintEventArgs e)
		{
			// Wurde OpenGL schon geladen?
			if(!_glLoaded)
				return;

			// Kontext holen
			_drawPanel.MakeCurrent();

			// Zeichenfläche leeren
			GL.Clear(ClearBufferMask.ColorBufferBit);

			// Während Einheiten-Update lieber nichts tun
			if(_updatingUnit || _renderUnit == null)
			{
				// Hintergrund anzeigen und abbrechen
				_drawPanel.SwapBuffers();
				return;
			}

			// Zeichenmatrix zurücksetzen
			GL.LoadIdentity();

			// Zeichenfläche verschieben
			GL.Translate(_renderingTranslation.X, _renderingTranslation.Y, 0.0f);

			// Ausgang aller Zeichnungen ist der Fenstermittelpunkt
			GL.Translate(_drawPanel.Width / 2.0f, _drawPanel.Height / 2.0f, 0.0f);

			// Ggf. Rahmen zeichnen
			if(_renderUnit.DATUnit.Type == GenieLibrary.DataElements.Civ.Unit.UnitType.Building)
			{
				// Keine Textur binden
				GL.BindTexture(TextureTarget.Texture2D, 0);

				// Größe
				if(_radiusSizeCheckBox.Checked)
					DrawBorder(_renderUnit.DATUnit.SizeRadius1, _renderUnit.DATUnit.SizeRadius2, Color.Red);

				// Editor
				if(_radiusEditorCheckBox.Checked)
					DrawBorder(_renderUnit.DATUnit.EditorRadius1, _renderUnit.DATUnit.EditorRadius2, Color.Gray);

				// Auswahl
				if(_radiusSelectionCheckBox.Checked)
					DrawBorder(_renderUnit.DATUnit.SelectionRadius1, _renderUnit.DATUnit.SelectionRadius2, Color.DarkGreen);

				// Manuell
				if(_radiusCustomCheckBox.Checked)
					DrawBorder((float)_radiusCustom1Field.Value, (float)_radiusCustom2Field.Value, Color.Blue);
			}

			// Animationen der Reihe nach in der Fenstermitte zeichnen
			foreach(Animation animation in _animations)
			{
				// Ist eine Animationstextur vorhanden?
				if(animation.TextureID > 0)
				{
					// Textur binden
					GL.Color3(Color.White);
					GL.BindTexture(TextureTarget.Texture2D, animation.TextureID);

					// Gezoomte Texturabmessungen berechnen
					double zoomedTexHalfWidth = (_zoom / 2) * animation.FrameBounds.Width;
					double zoomedTexHalfHeight = (_zoom / 2) * animation.FrameBounds.Height;

					// Ansicht verschieben
					GL.PushMatrix();
					GL.Translate(animation.RenderOffset.X * _zoom, animation.RenderOffset.Y * _zoom, 0.0);
					{
						// Frame-Koordinaten berechnen
						int frameID = animation.FrameID;
						double frameX = (frameID % animation.FramesPerLine) * animation.FrameBounds.Width;
						double frameY = (frameID / animation.FramesPerLine) * animation.FrameBounds.Height;

						// Frame zeichnen
						double texLeft = frameX / animation.TextureBounds.Width;
						double texRight = (frameX + animation.FrameBounds.Width) / animation.TextureBounds.Width;
						double texTop = frameY / animation.TextureBounds.Height;
						double texBottom = (frameY + animation.FrameBounds.Height) / animation.TextureBounds.Height;
						GL.Begin(PrimitiveType.Quads);
						{
							GL.TexCoord2(texLeft, texTop); GL.Vertex2(0, 0); // Oben links
							GL.TexCoord2(texRight, texTop); GL.Vertex2(2 * zoomedTexHalfWidth, 0); // Oben rechts
							GL.TexCoord2(texRight, texBottom); GL.Vertex2(2 * zoomedTexHalfWidth, 2 * zoomedTexHalfHeight); // Unten rechts
							GL.TexCoord2(texLeft, texBottom); GL.Vertex2(0, 2 * zoomedTexHalfHeight); // Unten links
						}
						GL.End();
					}
					GL.PopMatrix();
				}
			}

			// Puffer tauschen, um Flackern zu vermeiden
			_drawPanel.SwapBuffers();
		}

		private void _drawPanel_Resize(object sender, EventArgs e)
		{
			// Visual Studio Designer-Crash verhindern
			if(DesignMode)
				return;

			// Prüfen, ob das Panel überhaupt eine Größe hat (Fenster minimiert?)
			if(_drawPanel.Width != 0 && _drawPanel.Height != 0)
			{
				// Blickwinkel neu laden
				SetupDrawPanelViewPort();

				// Neuzeichnen erzwingen
				_drawPanel.Invalidate();
			}
		}

		private void _graphicsDRSButton_Click(object sender, EventArgs e)
		{
			// Dialog anzeigen
			if(_openGraphicsDRSDialog.ShowDialog() == DialogResult.OK)
			{
				// Dateinamen aktualisieren
				_graphicsDRSTextBox.Text = _openGraphicsDRSDialog.FileName;
			}
		}

		private void _loadDRSButton_Click(object sender, EventArgs e)
		{
			// DRS-Datei laden
			try
			{
				// Laden
				_graphicsDRS = new DRSFile(_graphicsDRSTextBox.Text);

				// Play-Button freischalten
				_playButton.Enabled = true;
			}
			catch(Exception ex)
			{
				// Fehlermeldung anzeigen und Fenster schließen
				MessageBox.Show("Fehler beim Laden der Graphics-DRS: " + ex.Message + "\n\nDas Fenster wird geschlossen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
		}

		private void _closeButton_Click(object sender, EventArgs e)
		{
			// Fenster schließen
			Close();
		}

		private void _graAttackingButton_CheckedChanged(object sender, EventArgs e)
		{
			// Button bei Einheiten-Update ignorieren
			if(_updatingUnit)
				return;

			// Aktiviert?
			if(_graAttackingButton.Checked)
			{
				// Gezeigte Grafik ändern
				_currShowedGraphic = GraphicMode.Attacking;

				// Grafik laden
				PreprocessRenderedGraphic();

				// Neu zeichnen
				_drawPanel.Invalidate();
			}
		}

		private void _graStandingButton_CheckedChanged(object sender, EventArgs e)
		{
			// Button bei Einheiten-Update ignorieren
			if(_updatingUnit)
				return;

			// Aktiviert?
			if(_graStandingButton.Checked)
			{
				// Gezeigte Grafik ändern
				_currShowedGraphic = GraphicMode.Standing;

				// Grafik laden
				PreprocessRenderedGraphic();

				// Neu zeichnen
				_drawPanel.Invalidate();
			}
		}

		private void _graMovingButton_CheckedChanged(object sender, EventArgs e)
		{
			// Button bei Einheiten-Update ignorieren
			if(_updatingUnit)
				return;

			// Aktiviert?
			if(_graMovingButton.Checked)
			{
				// Gezeigte Grafik ändern
				_currShowedGraphic = GraphicMode.Moving;

				// Grafik laden
				PreprocessRenderedGraphic();

				// Neu zeichnen
				_drawPanel.Invalidate();
			}
		}

		private void _graFallingButton_CheckedChanged(object sender, EventArgs e)
		{
			// Button bei Einheiten-Update ignorieren
			if(_updatingUnit)
				return;

			// Aktiviert?
			if(_graFallingButton.Checked)
			{
				// Gezeigte Grafik ändern
				_currShowedGraphic = GraphicMode.Falling;

				// Grafik laden
				PreprocessRenderedGraphic();

				// Neu zeichnen
				_drawPanel.Invalidate();
			}
		}

		private void _zoomField_ValueChanged(object sender, EventArgs e)
		{
			// Neuen Zoom speichern
			_zoom = (float)_zoomField.Value;

			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		private void _speedSlowButton_CheckedChanged(object sender, EventArgs e)
		{
			// Geschwindigkeit ändern
			UpdateAnimationSpeed(0.6f);
		}

		private void _speedNormalButton_CheckedChanged(object sender, EventArgs e)
		{
			// Geschwindigkeit ändern
			UpdateAnimationSpeed(0.75f);
		}

		private void _speedFastButton_CheckedChanged(object sender, EventArgs e)
		{
			// Geschwindigkeit ändern
			UpdateAnimationSpeed(1.0f);
		}

		private void _speedCustomButton_CheckedChanged(object sender, EventArgs e)
		{
			// Eingabefeld (de-)aktivieren
			_speedCustomField.Enabled = _speedCustomButton.Checked;
			if(_speedCustomButton.Checked)
				UpdateAnimationSpeed((float)_speedCustomField.Value);
		}

		private void _speedCustomField_ValueChanged(object sender, EventArgs e)
		{
			// Wert setzen
			UpdateAnimationSpeed((float)_speedCustomField.Value);
		}

		private void _playButton_Click(object sender, EventArgs e)
		{
			// Render-Timer starten
			_playButton.Enabled = false;
			_stopButton.Enabled = true;
			_renderTimer.Start();

			// Animationstimer starten
			foreach(Animation anim in _animations)
				anim.StartAnimation();
		}

		private void _stopButton_Click(object sender, EventArgs e)
		{
			// Animationstimer beenden
			foreach(Animation anim in _animations)
				anim.StopAnimation();

			// Render-Timer beenden
			_playButton.Enabled = true;
			_stopButton.Enabled = false;
			_renderTimer.Stop();
		}

		private void _renderTimer_Tick(object sender, EventArgs e)
		{
			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		private void UnitRenderForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Animationstimer beenden
			_renderTimer.Stop();
			foreach(Animation anim in _animations)
				anim.StopAnimation();

			// Steuerelement-Einstellungen merken
			Properties.Settings.Default.UnitRenderFormLocation = Location;
			Properties.Settings.Default.UnitRenderFormWindowState = WindowState;
			Properties.Settings.Default.UnitRenderFormSize = Size;
		}

		private void _angleField_ValueChanged(object sender, EventArgs e)
		{
			// Werte zyklisch ändern
			if(_angleField.Value == _angleField.Maximum)
				_angleField.Value = _angleField.Minimum + 1;
			else if(_angleField.Value == _angleField.Minimum)
				_angleField.Value = _angleField.Maximum - 1;

			// Neue Achse an Animationen durchgeben
			else if(_angleField.Enabled)
				foreach(Animation anim in _animations)
					anim.CurrentAngle = (int)(_angleField.Value / (_angleField.Maximum / anim.AngleCount));
		}

		private void _drawPanel_MouseDown(object sender, MouseEventArgs e)
		{
			// Verschiebe-Cursor anzeigen
			_drawPanel.Cursor = Cursors.SizeAll;
			_mouseClickLocation = e.Location;
		}

		private void _drawPanel_MouseUp(object sender, MouseEventArgs e)
		{
			// Cursor zurücksetzen
			_drawPanel.Cursor = Cursors.Default;
		}

		private void _drawPanel_MouseMove(object sender, MouseEventArgs e)
		{
			// Falls linke Maustause gedrückt, Zeichnung verschieben
			if(e.Button == MouseButtons.Left)
			{
				// Neues Offset berechnen
				_renderingTranslation = new Point(_renderingTranslation.X + e.Location.X - _mouseClickLocation.X, _renderingTranslation.Y + e.Location.Y - _mouseClickLocation.Y);
				_mouseClickLocation = e.Location;

				// Neuzeichnen
				_drawPanel.Invalidate();
			}
		}

		private void _drawPanel_MouseWheel(object sender, MouseEventArgs e)
		{
			// Steuerungstaste gedrückt?
			if(ModifierKeys == Keys.Control)
			{
				// Vom Zoom bereinigten Abstand des unter dem Mauszeiger befindlichen Punktes von Bildmitte berechnen
				PointF mousePointCenterDistance = new PointF((e.X - _drawPanel.Width / 2) / _zoom, (e.Y - _drawPanel.Height / 2) / _zoom);

				// Alte von Zoom bereinigte Verschiebung der Zeichenfläche merken
				PointF oldRenderingTranslation = new PointF(_renderingTranslation.X / _zoom, _renderingTranslation.Y / _zoom);

				// Zoomen
				float zoomDelta = (e.Delta > 0 ? 0.5f : -0.5f);
				if(_zoomField.Value + (decimal)zoomDelta <= _zoomField.Maximum && _zoomField.Value + (decimal)zoomDelta >= _zoomField.Minimum)
					_zoomField.Value += (decimal)zoomDelta;
				else if(zoomDelta < 0)
				{
					zoomDelta = (float)(_zoomField.Minimum - _zoomField.Value);
					_zoomField.Value = _zoomField.Minimum;
				}
				else
				{
					zoomDelta = (float)(_zoomField.Maximum - _zoomField.Value);
					_zoomField.Value = _zoomField.Maximum;
				}

				// Renderoffset entsprechend ändern, um auf die aktuelle Mausposition zoomen zu können
				_renderingTranslation.X = (int)(_zoom * oldRenderingTranslation.X + e.X - _drawPanel.Width / 2 - _zoom * mousePointCenterDistance.X);
				_renderingTranslation.Y = (int)(_zoom * oldRenderingTranslation.Y + e.Y - _drawPanel.Height / 2 - _zoom * mousePointCenterDistance.Y);

				// Neu zeichnen
				_drawPanel.Invalidate();
			}
		}

		private void _centerUnitButton_Click(object sender, EventArgs e)
		{
			// Zentrieren
			_renderingTranslation = new Point(0, 0);

			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		private void _radiusCustomCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			// Auswahlfelder umschalten
			_radiusCustom1Field.Enabled = _radiusCustom2Field.Enabled = _radiusCustomCheckBox.Checked;

			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		private void _radiusSizeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		private void _radiusEditorCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		private void _radiusSelectionCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		private void _radiusCustom1Field_ValueChanged(object sender, EventArgs e)
		{
			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		private void _radiusCustom2Field_ValueChanged(object sender, EventArgs e)
		{
			// Neu zeichnen
			_drawPanel.Invalidate();
		}

		#endregion Ereignishandler

		#region Hilfsfunktionen

		/// <summary>
		/// Zeichnet einen viereckigen Tile-Bereich um den aktuellen Mittelpunkt.
		/// </summary>
		/// <param name="size1">Die Höhe des Bereichs.</param>
		/// <param name="size2">Die Breite des Bereichs.</param>
		/// <param name="color">Die Farbe des Rahmens.</param>
		/// <returns></returns>
		private void DrawBorder(float size1, float size2, Color color)
		{
			// Seitenpunkte berechnen
			float topX = (float)((size2 - size1) * TILE_HORIZONTAL_OFFSET);
			float topY = (float)((size2 + size1) * TILE_VERTICAL_OFFSET);
			float leftX = (float)(-(size1 + size2) * TILE_HORIZONTAL_OFFSET);
			float leftY = (float)((size1 - size2) * TILE_VERTICAL_OFFSET);

			// Zeichnen
			GL.Color3(color);
			GL.Begin(PrimitiveType.LineLoop);
			{
				GL.Vertex2(_zoom * leftX, _zoom * leftY); // Links
				GL.Vertex2(_zoom * topX, _zoom * topY); // Oben
				GL.Vertex2(-_zoom * leftX, -_zoom * leftY); // Rechts
				GL.Vertex2(-_zoom * topX, -_zoom * topY); // Unten
			}
			GL.End();
		}

		/// <summary>
		/// Berechnet die nächsthöhere (oder gleiche) Zweierpotenz zum gegebenen Wert.
		/// </summary>
		/// <param name="value">Der Wert, zu dem die nächsthöhere Zweierpotenz gefunden werden soll.</param>
		/// <returns></returns>
		private uint NextPowerOfTwo(uint value)
		{
			// Bit-Magie
			--value;
			value |= value >> 1;
			value |= value >> 2;
			value |= value >> 4;
			value |= value >> 8;
			value |= value >> 16;
			return ++value;
		}

		#endregion

		#region Hilfsklassen

		/// <summary>
		/// Definiert eine Animation.
		/// </summary>
		private class Animation
		{
			#region Variablen

			/// <summary>
			/// Die Zeit in Millisekunden, die ein Frame angezeigt wird.
			/// </summary>
			public float BaseFrameTime { get; set; } = 100.0f;

			/// <summary>
			/// Der Faktor, dessen Inverses auf die Darstellungszeit eines Frames angewandt werden soll.
			/// </summary>
			private float _speedMultiplier = 1.0f;

			/// <summary>
			/// Die Textur-ID der Animation.
			/// </summary>
			public int TextureID { get; set; }

			/// <summary>
			/// Die Abmessungen der Animations-Textur (2er-Potenz).
			/// </summary>
			public Size TextureBounds { get; set; }

			/// <summary>
			/// Die Anzahl der Frames der Animation. Muss ein Vielfaches von AngleCount sein.
			/// </summary>
			public int FrameCount { get; set; }

			/// <summary>
			/// Die Anzahl der Frames in der Animations-Textur pro Zeile.
			/// </summary>
			public int FramesPerLine { get; set; }

			/// <summary>
			/// Der aktuell angezeigte Frame der Animation.
			/// </summary>
			public int FrameID { get; set; }

			/// <summary>
			/// Die Abmessungen der einzelnen Animations-Frames (alle gleich groß).
			/// </summary>
			public Size FrameBounds { get; set; }

			/// <summary>
			/// Die Anzahl der in der Textur vorgerenderten Animationsachsen.
			/// </summary>
			public int AngleCount { get; set; } = 5;

			/// <summary>
			/// Der Versatz beim Rendern.
			/// </summary>
			public Point RenderOffset { get; set; }

			/// <summary>
			/// Der interne Thread, der durch stetiges Ändern der Frame-ID die Animation realisiert.
			/// </summary>
			private System.Timers.Timer _animateTimer;

			/// <summary>
			/// Die aktuelle Animationsachse.
			/// </summary>
			private int _currentAngle = 0;

			#endregion

			#region Eigenschaften

			/// <summary>
			/// Der Faktor, dessen Inverses auf die Darstellungszeit eines Frames angewandt werden soll.
			/// </summary>
			public float SpeedMultiplier
			{
				get { return _speedMultiplier; }
				set
				{
					// Neuen Faktor speichern
					_speedMultiplier = value;

					// Timer-Intervall aktualisieren
					if(BaseFrameTime != 0 && SpeedMultiplier != 0)
						_animateTimer.Interval = BaseFrameTime / SpeedMultiplier;
				}
			}

			/// <summary>
			/// Die aktuelle Animationsachse.
			/// </summary>
			public int CurrentAngle
			{
				get { return _currentAngle; }
				set
				{
					// Wert speichern
					if(value < AngleCount)
						_currentAngle = value;

					// Frame-ID aktualisieren
					FrameID = _currentAngle * (FrameCount / AngleCount);
				}
			}

			#endregion

			#region Funktionen

			/// <summary>
			/// Konstruktor. Erstellt eine neue Animation.
			/// </summary>
			public Animation()
			{
				// Timer erstellen
				_animateTimer = new System.Timers.Timer();
				_animateTimer.AutoReset = false;
				_animateTimer.Elapsed += new System.Timers.ElapsedEventHandler(AnimateTimerTick);
			}

			/// <summary>
			/// Startet die Animation.
			/// </summary>
			public void StartAnimation()
			{
				// Das Intervall sollte größer als 0 sein
				if(BaseFrameTime != 0 && SpeedMultiplier != 0)
				{
					// Timer starten
					_animateTimer.Interval = BaseFrameTime / SpeedMultiplier;
					_animateTimer.Start();
				}
			}

			/// <summary>
			/// Stoppt die Animation.
			/// </summary>
			public void StopAnimation()
			{
				// Timer stoppen
				_animateTimer.Stop();
			}

			/// <summary>
			/// Führt bei Auslösen durch den Animationstimer die Animation um einen Schritt fort.
			/// </summary>
			public void AnimateTimerTick(object sender, System.Timers.ElapsedEventArgs e)
			{
				// Frame-ID inkrementieren
				if(FrameID < FrameCount - 1)
					++FrameID;
				else
					FrameID = 0;

				// Hat sich die Achse geändert?
				if(FrameID >= (_currentAngle + 1) * (FrameCount / AngleCount))
					FrameID = _currentAngle * (FrameCount / AngleCount);

				// Nächstes Intervall
				_animateTimer.Start();
			}

			#endregion
		}

		#endregion

		#region Enumerationen

		/// <summary>
		/// Die verschiedenen Grafik-Typen.
		/// </summary>
		private enum GraphicMode
		{
			Attacking,
			Falling,
			Moving,
			Standing
		}

		#endregion
	}
}