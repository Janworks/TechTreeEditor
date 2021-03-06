﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;

namespace TechTreeEditor.TechTreeStructure
{
	/// <summary>
	/// Definiert ein Einheit-Element im Technologiebaum.
	/// </summary>
	[System.Diagnostics.DebuggerDisplay("ID: #{ID}, Name: {Name}")]
	public abstract class TechTreeUnit : TechTreeElement
	{
		#region Variablen

		/// <summary>
		/// Die zugehörige DAT-Einheit.
		/// In diese Eigenschaft sollte im Normalfall nicht geschrieben werden, es sollte auf den jeweiligen Einheiten-Manager zurückgegriffen werden!
		/// </summary>
		public GenieLibrary.DataElements.Civ.Unit DATUnit { get; set; }

		/// <summary>
		/// Die zugehörige tote Einheit.
		/// </summary>
		public TechTreeUnit DeadUnit { get; set; }

		/// <summary>
		/// Die Fähigkeiten der Einheit.
		/// </summary>
		public List<UnitAbility> Abilities { get; private set; }

		#endregion Variablen

		#region Funktionen

		/// <summary>
		/// Konstruktor.
		/// Erstellt ein neues TechTree-Einheit-Element.
		/// </summary>
		public TechTreeUnit()
			: base()
		{
			// Fähigkeitenliste anlegen
			Abilities = new List<UnitAbility>();
		}

		/// <summary>
		/// Liest das aktuelle Element aus dem angegebenen XElement.
		/// </summary>
		/// <param name="element">Das XElement, aus dem das Element erstellt werden soll.</param>
		/// <param name="previousElements">Die bereits eingelesenen Vorgängerelemente, von denen dieses Element abhängig sein kann.</param>
		/// <param name="dat">Die DAT-Datei, aus der ggf. Daten ausgelesen werden können.</param>
		/// <param name="langFiles">Das Language-Datei-Objekt zum Auslesen von Stringdaten.</param>
		public override void FromXml(XElement element, Dictionary<int, TechTreeElement> previousElements, GenieLibrary.GenieFile dat, GenieLibrary.LanguageFileWrapper langFiles)
		{
			// Elemente der Oberklasse lesen
			base.FromXml(element, previousElements, dat, langFiles);

			// Werte einlesen
			int id = (int)element.Element("deadunit");
			if(id >= 0)
				this.DeadUnit = (TechTreeUnit)previousElements[id];

			// DAT-Einheit laden
			for(int c = dat.Civs.Count - 1; c >= 0; --c)
				if((DATUnit = dat.Civs[c].Units.FirstOrDefault(u => u.Key == ID).Value) != null)
					break;

			// Einheiten-Fähigkeiten laden
			GenieLibrary.DataElements.UnitHeader unitHeader = dat.UnitHeaders[ID];
			id = 0;
			foreach(XElement ab in element.Element("abilities").Descendants("ability"))
			{
				// Fähigkeiten laden
				Abilities.Add(new UnitAbility(ab, previousElements, unitHeader.Commands[id]));

				// Nächste
				++id;
			}

            // Namen setzen
            UpdateName(langFiles);
        }

		/// <summary>
		/// Erstellt für alle Kindelemente die Texturen.
		/// </summary>
		/// <param name="textureFunc">Die Textur-Generierungsfunktion.</param>
		public override void CreateIconTextures(Func<string, short, Color, int> textureFunc)
		{
			// Schon ein Icon vorhanden? => Abbrechen
			if(IconTextureID > 0)
				return;

			// Icon erstellen
			CreateIconTexture(textureFunc);

			// Funktion in der Basisklasse aufrufen
			base.CreateIconTextures(textureFunc);
		}

		/// <summary>
		/// Erstellt die Icon-Textur.
		/// </summary>
		/// <param name="textureFunc">Die Textur-Generierungsfunktion.</param>
		public override void CreateIconTexture(Func<string, short, Color, int> textureFunc)
		{
			// Icon erstellen
			IconTextureID = textureFunc(Type, DATUnit.IconID, BoxColor);
		}

		/// <summary>
		/// Zählt die Referenzen zu dem angegebenen Element.
		/// </summary>
		/// <param name="element">Das zu zählende Element.</param>
		/// <returns></returns>
		public override int CountReferencesToElement(TechTreeElement element)
		{
			// Oberklassen zählen lassen
			int counter = base.CountReferencesToElement(element);

			// Zählen
			if(DeadUnit == element)
				++counter;

			// Fertig
			return counter;
		}

		/// <summary>
		/// Generiert den Anzeige-Namen.
		/// </summary>
		/// <param name="langFiles">Das Language-Datei-Objekt zum Auslesen von Stringdaten.</param>
		public override void UpdateName(GenieLibrary.LanguageFileWrapper langFiles)
		{
			// Name setzen
			Name = langFiles.GetString(DATUnit.LanguageDLLName) + " [ID " + ID.ToString() + ", T " + (byte)DATUnit.Type + ", " + DATUnit.Name1.TrimEnd('\0') + "]";
		}

		#endregion Funktionen

		#region Eigenschaften

		/// <summary>
		/// Ruft den den Elementtyp (= Klassennamen) ab.
		/// </summary>
		public override string Type
		{
			get { return "TechTreeUnit"; }
		}

		#endregion Eigenschaften
	}
}