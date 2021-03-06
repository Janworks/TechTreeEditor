﻿namespace TechTreeEditor
{
	partial class ImportDATFile
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportDATFile));
			this.label1 = new System.Windows.Forms.Label();
			this._datTextBox = new System.Windows.Forms.TextBox();
			this._datButton = new System.Windows.Forms.Button();
			this._openDATDialog = new System.Windows.Forms.OpenFileDialog();
			this._loadDataButton = new System.Windows.Forms.Button();
			this._loadProgressBar = new System.Windows.Forms.ProgressBar();
			this._selectionGroupBox = new System.Windows.Forms.GroupBox();
			this._selectionView = new System.Windows.Forms.DataGridView();
			this._selectionViewIncludeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this._selectionViewIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._selectionViewInternalNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._selectionViewDLLNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._selectionViewTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this._finishButton = new System.Windows.Forms.Button();
			this._cancelButton = new System.Windows.Forms.Button();
			this._dllTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._openDLLDialog = new System.Windows.Forms.OpenFileDialog();
			this._dllButton = new System.Windows.Forms.Button();
			this._dllHelpBox = new System.Windows.Forms.ToolTip(this.components);
			this._finishProgressBar = new System.Windows.Forms.ProgressBar();
			this._interfacDRSButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this._interfacDRSTextBox = new System.Windows.Forms.TextBox();
			this._saveProjectDialog = new System.Windows.Forms.SaveFileDialog();
			this._openInterfacDRSDialog = new System.Windows.Forms.OpenFileDialog();
			this._ageCountField = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this._selectionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._selectionView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._ageCountField)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this._dllHelpBox.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
			// 
			// _datTextBox
			// 
			resources.ApplyResources(this._datTextBox, "_datTextBox");
			this._datTextBox.Name = "_datTextBox";
			this._dllHelpBox.SetToolTip(this._datTextBox, resources.GetString("_datTextBox.ToolTip"));
			// 
			// _datButton
			// 
			resources.ApplyResources(this._datButton, "_datButton");
			this._datButton.Name = "_datButton";
			this._dllHelpBox.SetToolTip(this._datButton, resources.GetString("_datButton.ToolTip"));
			this._datButton.UseVisualStyleBackColor = true;
			this._datButton.Click += new System.EventHandler(this._datButton_Click);
			// 
			// _openDATDialog
			// 
			resources.ApplyResources(this._openDATDialog, "_openDATDialog");
			// 
			// _loadDataButton
			// 
			resources.ApplyResources(this._loadDataButton, "_loadDataButton");
			this._loadDataButton.Name = "_loadDataButton";
			this._dllHelpBox.SetToolTip(this._loadDataButton, resources.GetString("_loadDataButton.ToolTip"));
			this._loadDataButton.UseVisualStyleBackColor = true;
			this._loadDataButton.Click += new System.EventHandler(this._loadDataButton_Click);
			// 
			// _loadProgressBar
			// 
			resources.ApplyResources(this._loadProgressBar, "_loadProgressBar");
			this._loadProgressBar.Name = "_loadProgressBar";
			this._loadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this._dllHelpBox.SetToolTip(this._loadProgressBar, resources.GetString("_loadProgressBar.ToolTip"));
			// 
			// _selectionGroupBox
			// 
			resources.ApplyResources(this._selectionGroupBox, "_selectionGroupBox");
			this._selectionGroupBox.Controls.Add(this._selectionView);
			this._selectionGroupBox.Controls.Add(this.label2);
			this._selectionGroupBox.Name = "_selectionGroupBox";
			this._selectionGroupBox.TabStop = false;
			this._dllHelpBox.SetToolTip(this._selectionGroupBox, resources.GetString("_selectionGroupBox.ToolTip"));
			// 
			// _selectionView
			// 
			resources.ApplyResources(this._selectionView, "_selectionView");
			this._selectionView.AllowUserToAddRows = false;
			this._selectionView.AllowUserToDeleteRows = false;
			this._selectionView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._selectionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._selectionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._selectionViewIncludeColumn,
            this._selectionViewIDColumn,
            this._selectionViewInternalNameColumn,
            this._selectionViewDLLNameColumn,
            this._selectionViewTypeColumn});
			this._selectionView.MultiSelect = false;
			this._selectionView.Name = "_selectionView";
			this._dllHelpBox.SetToolTip(this._selectionView, resources.GetString("_selectionView.ToolTip"));
			this._selectionView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this._selectionView_SortCompare);
			// 
			// _selectionViewIncludeColumn
			// 
			this._selectionViewIncludeColumn.FillWeight = 10F;
			resources.ApplyResources(this._selectionViewIncludeColumn, "_selectionViewIncludeColumn");
			this._selectionViewIncludeColumn.Name = "_selectionViewIncludeColumn";
			this._selectionViewIncludeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this._selectionViewIncludeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// _selectionViewIDColumn
			// 
			this._selectionViewIDColumn.FillWeight = 10F;
			resources.ApplyResources(this._selectionViewIDColumn, "_selectionViewIDColumn");
			this._selectionViewIDColumn.Name = "_selectionViewIDColumn";
			this._selectionViewIDColumn.ReadOnly = true;
			// 
			// _selectionViewInternalNameColumn
			// 
			this._selectionViewInternalNameColumn.FillWeight = 20F;
			resources.ApplyResources(this._selectionViewInternalNameColumn, "_selectionViewInternalNameColumn");
			this._selectionViewInternalNameColumn.Name = "_selectionViewInternalNameColumn";
			// 
			// _selectionViewDLLNameColumn
			// 
			this._selectionViewDLLNameColumn.FillWeight = 40F;
			resources.ApplyResources(this._selectionViewDLLNameColumn, "_selectionViewDLLNameColumn");
			this._selectionViewDLLNameColumn.Name = "_selectionViewDLLNameColumn";
			this._selectionViewDLLNameColumn.ReadOnly = true;
			// 
			// _selectionViewTypeColumn
			// 
			this._selectionViewTypeColumn.FillWeight = 20F;
			resources.ApplyResources(this._selectionViewTypeColumn, "_selectionViewTypeColumn");
			this._selectionViewTypeColumn.Name = "_selectionViewTypeColumn";
			this._selectionViewTypeColumn.ReadOnly = true;
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this._dllHelpBox.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			// 
			// _finishButton
			// 
			resources.ApplyResources(this._finishButton, "_finishButton");
			this._finishButton.Name = "_finishButton";
			this._dllHelpBox.SetToolTip(this._finishButton, resources.GetString("_finishButton.ToolTip"));
			this._finishButton.UseVisualStyleBackColor = true;
			this._finishButton.Click += new System.EventHandler(this._finishButton_Click);
			// 
			// _cancelButton
			// 
			resources.ApplyResources(this._cancelButton, "_cancelButton");
			this._cancelButton.Name = "_cancelButton";
			this._dllHelpBox.SetToolTip(this._cancelButton, resources.GetString("_cancelButton.ToolTip"));
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
			// 
			// _dllTextBox
			// 
			resources.ApplyResources(this._dllTextBox, "_dllTextBox");
			this._dllTextBox.Name = "_dllTextBox";
			this._dllHelpBox.SetToolTip(this._dllTextBox, resources.GetString("_dllTextBox.ToolTip"));
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			this._dllHelpBox.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
			// 
			// _openDLLDialog
			// 
			resources.ApplyResources(this._openDLLDialog, "_openDLLDialog");
			this._openDLLDialog.Multiselect = true;
			// 
			// _dllButton
			// 
			resources.ApplyResources(this._dllButton, "_dllButton");
			this._dllButton.Name = "_dllButton";
			this._dllHelpBox.SetToolTip(this._dllButton, resources.GetString("_dllButton.ToolTip"));
			this._dllButton.UseVisualStyleBackColor = true;
			this._dllButton.Click += new System.EventHandler(this._dllButton_Click);
			// 
			// _dllHelpBox
			// 
			this._dllHelpBox.AutoPopDelay = 5000;
			this._dllHelpBox.InitialDelay = 500;
			this._dllHelpBox.ReshowDelay = 100;
			// 
			// _finishProgressBar
			// 
			resources.ApplyResources(this._finishProgressBar, "_finishProgressBar");
			this._finishProgressBar.Name = "_finishProgressBar";
			this._finishProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this._dllHelpBox.SetToolTip(this._finishProgressBar, resources.GetString("_finishProgressBar.ToolTip"));
			// 
			// _interfacDRSButton
			// 
			resources.ApplyResources(this._interfacDRSButton, "_interfacDRSButton");
			this._interfacDRSButton.Name = "_interfacDRSButton";
			this._dllHelpBox.SetToolTip(this._interfacDRSButton, resources.GetString("_interfacDRSButton.ToolTip"));
			this._interfacDRSButton.UseVisualStyleBackColor = true;
			this._interfacDRSButton.Click += new System.EventHandler(this._interfacDRSButton_Click);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			this._dllHelpBox.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
			// 
			// _interfacDRSTextBox
			// 
			resources.ApplyResources(this._interfacDRSTextBox, "_interfacDRSTextBox");
			this._interfacDRSTextBox.Name = "_interfacDRSTextBox";
			this._dllHelpBox.SetToolTip(this._interfacDRSTextBox, resources.GetString("_interfacDRSTextBox.ToolTip"));
			// 
			// _saveProjectDialog
			// 
			resources.ApplyResources(this._saveProjectDialog, "_saveProjectDialog");
			// 
			// _openInterfacDRSDialog
			// 
			resources.ApplyResources(this._openInterfacDRSDialog, "_openInterfacDRSDialog");
			// 
			// _ageCountField
			// 
			resources.ApplyResources(this._ageCountField, "_ageCountField");
			this._ageCountField.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this._ageCountField.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this._ageCountField.Name = "_ageCountField";
			this._dllHelpBox.SetToolTip(this._ageCountField, resources.GetString("_ageCountField.ToolTip"));
			this._ageCountField.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			this._dllHelpBox.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
			// 
			// ImportDATFile
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label5);
			this.Controls.Add(this._ageCountField);
			this.Controls.Add(this._interfacDRSButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._interfacDRSTextBox);
			this.Controls.Add(this._finishProgressBar);
			this.Controls.Add(this._dllButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._dllTextBox);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._finishButton);
			this.Controls.Add(this._selectionGroupBox);
			this.Controls.Add(this._loadProgressBar);
			this.Controls.Add(this._loadDataButton);
			this.Controls.Add(this._datButton);
			this.Controls.Add(this._datTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "ImportDATFile";
			this._dllHelpBox.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportDATFile_FormClosing);
			this._selectionGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._selectionView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._ageCountField)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _datTextBox;
		private System.Windows.Forms.Button _datButton;
		private System.Windows.Forms.OpenFileDialog _openDATDialog;
		private System.Windows.Forms.Button _loadDataButton;
		private System.Windows.Forms.ProgressBar _loadProgressBar;
		private System.Windows.Forms.GroupBox _selectionGroupBox;
		private System.Windows.Forms.DataGridView _selectionView;
		private System.Windows.Forms.Button _finishButton;
		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _dllTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.OpenFileDialog _openDLLDialog;
		private System.Windows.Forms.Button _dllButton;
		private System.Windows.Forms.ToolTip _dllHelpBox;
		private System.Windows.Forms.DataGridViewCheckBoxColumn _selectionViewIncludeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _selectionViewIDColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _selectionViewInternalNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _selectionViewDLLNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _selectionViewTypeColumn;
		private System.Windows.Forms.SaveFileDialog _saveProjectDialog;
		private System.Windows.Forms.ProgressBar _finishProgressBar;
		private System.Windows.Forms.Button _interfacDRSButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _interfacDRSTextBox;
		private System.Windows.Forms.OpenFileDialog _openInterfacDRSDialog;
		private System.Windows.Forms.NumericUpDown _ageCountField;
		private System.Windows.Forms.Label label5;
	}
}