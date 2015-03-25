﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using X2AddOnTechTreeEditor.TechTreeStructure;

namespace X2AddOnTechTreeEditor
{
	public partial class EditCreatableForm : Form
	{
		#region Variablen

		/// <summary>
		/// Das in diesem Fenster bearbeitbare Gebäude.
		/// </summary>
		TechTreeCreatable _creatable = null;

		/// <summary>
		/// Die zugrundeliegenden Projektdaten.
		/// </summary>
		TechTreeFile _projectFile = null;

		#endregion

		#region Funktionen

		/// <summary>
		/// Konstruktor.
		/// </summary>
		private EditCreatableForm()
		{
			// Steuerelement laden
			InitializeComponent();
		}

		/// <summary>
		/// Erstellt ein neues Einheit-Bearbeitungsfenster.
		/// </summary>
		/// <param name="projectile">Die zu bearbeitende Einheit.</param>
		public EditCreatableForm(TechTreeFile projectFile, TechTreeCreatable unit)
			: this()
		{
			// Parameter merken
			_creatable = unit;
			_projectFile = projectFile;

			// Fenstertitel aktualisieren
			this.Text += _creatable.Name;

			// Dummy-Objekte für leere Listenelemente erstellen
			TechTreeEyeCandy emptyEyeCandy = new TechTreeEyeCandy() { ID = -1 };
			_trackUnitComboBox.Items.Add(emptyEyeCandy);
			TechTreeProjectile emptyProj = new TechTreeProjectile() { ID = -1 };
			_projUnitComboBox.Items.Add(emptyProj);
			_projDuplUnitComboBox.Items.Add(emptyProj);

			// Trackingliste erstellen
			_trackUnitComboBox.SuspendLayout();
			_trackUnitComboBox.DisplayMember = "Name";
			_projectFile.Where(u => u.GetType() == typeof(TechTreeEyeCandy)).ForEach(u =>
			{
				_trackUnitComboBox.Items.Add(u);
			});
			_trackUnitComboBox.ResumeLayout();

			// Projektillisten erstellen
			_projUnitComboBox.SuspendLayout();
			_projDuplUnitComboBox.SuspendLayout();
			_projUnitComboBox.DisplayMember = "Name";
			_projDuplUnitComboBox.DisplayMember = "Name";
			_projectFile.Where(p => p.GetType() == typeof(TechTreeProjectile)).ForEach(p =>
			{
				_projUnitComboBox.Items.Add(p);
				_projDuplUnitComboBox.Items.Add(p);
			});
			_projUnitComboBox.ResumeLayout();
			_projDuplUnitComboBox.ResumeLayout();

			// Elemente auswählen
			_trackUnitComboBox.SelectedItem = (_creatable.TrackingUnit == null ? emptyEyeCandy : _creatable.TrackingUnit);
			_projUnitComboBox.SelectedItem = (_creatable.ProjectileUnit == null ? emptyProj : _creatable.ProjectileUnit);
			_projDuplUnitComboBox.SelectedItem = (_creatable.ProjectileDuplicationUnit == null ? emptyProj : _creatable.ProjectileDuplicationUnit);

			// Kindelemente in View schreiben
			foreach(var currC in _creatable.Children)
			{
				// Zeile erstellen
				DataGridViewRow row = new DataGridViewRow() { Tag = (TechTreeElement)currC.Item2 };
				row.Cells.Add(new DataGridViewTextBoxCell() { Value = currC.Item1.ToString() });
				row.Cells.Add(new DataGridViewTextBoxCell() { Value = currC.Item2.Name });
				_childrenView.Rows.Add(row);
			}
		}

		#endregion

		#region Ereignishandler

		private void _projUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Wert aktualisieren
			TechTreeProjectile selItem = (TechTreeProjectile)_projUnitComboBox.SelectedItem;
			_creatable.ProjectileUnit = (selItem.ID >= 0 ? selItem : null);
		}

		private void _projDuplUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Wert aktualisieren
			TechTreeProjectile selItem = (TechTreeProjectile)_projDuplUnitComboBox.SelectedItem;
			_creatable.ProjectileDuplicationUnit = (selItem.ID >= 0 ? selItem : null);
		}

		private void _trackUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Wert aktualisieren
			TechTreeEyeCandy selItem = (TechTreeEyeCandy)_trackUnitComboBox.SelectedItem;
			_creatable.TrackingUnit = (selItem.ID >= 0 ? selItem : null);
		}

		private void _childrenView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			// Button-Spalte
			if(e.ColumnIndex == 0)
			{
				// Der Wert muss numerisch sein
				byte val = 0;
				if(!byte.TryParse((string)e.FormattedValue, out val) || val < 0)
				{
					// Fehler
					MessageBox.Show("Bitte gib eine positive ganze Zahl an!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					e.Cancel = true;
				}
				else
				{
					// Wert speichern
					int index = _creatable.Children.FindIndex(c => c.Item2 == (TechTreeElement)_childrenView.Rows[e.RowIndex].Tag);
					_creatable.Children[index] = new Tuple<byte, TechTreeElement>(val, (TechTreeElement)_childrenView.Rows[e.RowIndex].Tag);
				}
			}
		}

		private void _closeButton_Click(object sender, EventArgs e)
		{
			// Fenster schließen
			this.Close();
		}

		#endregion
	}
}
