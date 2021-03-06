﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TechTreeEditor.Properties;

namespace TechTreeEditor
{
	public partial class NewProjectForm : Form
	{
		#region Variablen

		/// <summary>
		/// Der Pfad zur neu erstellten Projektdatei.
		/// </summary>
		private string _projectFilePath = null;

		#endregion Variablen

		#region Funktionen

		/// <summary>
		/// Konstruktor.
		/// </summary>
		public NewProjectForm()
		{
			// Steuerelemente laden
			InitializeComponent();

			// ToolTip zuweisen
			_dllHelpBox.SetToolTip(_dllTextBox, Strings.ImportDATFile_ToolTip_LanguageFiles);
			_dllHelpBox.InitialDelay = 0;
			_dllHelpBox.ReshowDelay = 0;
			_dllHelpBox.AutomaticDelay = 0;
			_dllHelpBox.ShowAlways = true;
		}

		#endregion Funktionen

		#region Ereignishandler

		private void _dllButton_Click(object sender, EventArgs e)
		{
			// Dialog anzeigen
			if(_openDLLDialog.ShowDialog() == DialogResult.OK)
			{
				// Dateinamen aktualisieren
				_dllTextBox.Text = string.Join(";", _openDLLDialog.FileNames);
			}
		}

		private void _interfacDRSButton_Click(object sender, EventArgs e)
		{
			// Dialog anzeigen
			if(_openInterfacDRSDialog.ShowDialog() == DialogResult.OK)
			{
				// Dateinamen aktualisieren
				_interfacDRSTextBox.Text = _openInterfacDRSDialog.FileName;
			}
		}

		private void _cancelButton_Click(object sender, EventArgs e)
		{
			// Fenster schließen
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void _finishButton_Click(object sender, EventArgs e)
		{
			// Speicherfenster anzeigen
			if(_saveProjectDialog.ShowDialog() == DialogResult.OK)
			{
				// Projektdatei aus Ressourcen holen und am Zielort speichern
				_projectFilePath = _saveProjectDialog.FileName;
				if(_minimalProjectButton.Checked)
					File.WriteAllBytes(_saveProjectDialog.FileName, Resources.ProjectTemplate_Minimal);
				else if(_fullProjectButton.Checked)
					File.WriteAllBytes(_saveProjectDialog.FileName, Resources.ProjectTemplate_Full);

				// DLL-Pfade extrahieren
				List<string> languageFileNames = _dllTextBox.Text.Split(';').ToList();
				languageFileNames.RemoveAll(fn => string.IsNullOrEmpty(fn));
				languageFileNames.Reverse();

				// Projektdatei öffnen
				TechTreeFile projectFile = new TechTreeFile(_projectFilePath);

				// Dateipfade ergänzen
				projectFile.InterfacDRSPath = _interfacDRSTextBox.Text;
				projectFile.LanguageFilePaths = languageFileNames;

				// Projekt speichern und schließen
				projectFile.WriteData(_projectFilePath);
				projectFile = null;
			}

			// Fenster schließen
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		#endregion Ereignishandler

		#region Eigenschaften

		/// <summary>
		/// Ruft den Pfad zur neu erstellten Projektdatei ab.
		/// </summary>
		public string NewProjectFile
		{
			get { return _projectFilePath; }
		}

		#endregion Eigenschaften
	}
}