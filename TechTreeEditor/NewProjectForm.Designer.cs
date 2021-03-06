﻿namespace TechTreeEditor
{
	partial class NewProjectForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectForm));
			this.label4 = new System.Windows.Forms.Label();
			this._interfacDRSTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._dllTextBox = new System.Windows.Forms.TextBox();
			this._interfacDRSButton = new System.Windows.Forms.Button();
			this._dllButton = new System.Windows.Forms.Button();
			this._minimalProjectButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this._fullProjectButton = new System.Windows.Forms.RadioButton();
			this._cancelButton = new System.Windows.Forms.Button();
			this._finishButton = new System.Windows.Forms.Button();
			this._saveProjectDialog = new System.Windows.Forms.SaveFileDialog();
			this._openDLLDialog = new System.Windows.Forms.OpenFileDialog();
			this._dllHelpBox = new System.Windows.Forms.ToolTip(this.components);
			this._reducedProjectButton = new System.Windows.Forms.RadioButton();
			this._openInterfacDRSDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// _interfacDRSTextBox
			// 
			resources.ApplyResources(this._interfacDRSTextBox, "_interfacDRSTextBox");
			this._interfacDRSTextBox.Name = "_interfacDRSTextBox";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// _dllTextBox
			// 
			resources.ApplyResources(this._dllTextBox, "_dllTextBox");
			this._dllTextBox.Name = "_dllTextBox";
			// 
			// _interfacDRSButton
			// 
			resources.ApplyResources(this._interfacDRSButton, "_interfacDRSButton");
			this._interfacDRSButton.Name = "_interfacDRSButton";
			this._interfacDRSButton.UseVisualStyleBackColor = true;
			this._interfacDRSButton.Click += new System.EventHandler(this._interfacDRSButton_Click);
			// 
			// _dllButton
			// 
			resources.ApplyResources(this._dllButton, "_dllButton");
			this._dllButton.Name = "_dllButton";
			this._dllButton.UseVisualStyleBackColor = true;
			this._dllButton.Click += new System.EventHandler(this._dllButton_Click);
			// 
			// _minimalProjectButton
			// 
			resources.ApplyResources(this._minimalProjectButton, "_minimalProjectButton");
			this._minimalProjectButton.Name = "_minimalProjectButton";
			this._minimalProjectButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// _fullProjectButton
			// 
			resources.ApplyResources(this._fullProjectButton, "_fullProjectButton");
			this._fullProjectButton.Checked = true;
			this._fullProjectButton.Name = "_fullProjectButton";
			this._fullProjectButton.TabStop = true;
			this._fullProjectButton.UseVisualStyleBackColor = true;
			// 
			// _cancelButton
			// 
			resources.ApplyResources(this._cancelButton, "_cancelButton");
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
			// 
			// _finishButton
			// 
			resources.ApplyResources(this._finishButton, "_finishButton");
			this._finishButton.Name = "_finishButton";
			this._finishButton.UseVisualStyleBackColor = true;
			this._finishButton.Click += new System.EventHandler(this._finishButton_Click);
			// 
			// _saveProjectDialog
			// 
			resources.ApplyResources(this._saveProjectDialog, "_saveProjectDialog");
			// 
			// _openDLLDialog
			// 
			resources.ApplyResources(this._openDLLDialog, "_openDLLDialog");
			this._openDLLDialog.Multiselect = true;
			// 
			// _dllHelpBox
			// 
			this._dllHelpBox.AutoPopDelay = 5000;
			this._dllHelpBox.InitialDelay = 500;
			this._dllHelpBox.ReshowDelay = 100;
			// 
			// _reducedProjectButton
			// 
			resources.ApplyResources(this._reducedProjectButton, "_reducedProjectButton");
			this._reducedProjectButton.Name = "_reducedProjectButton";
			this._reducedProjectButton.UseVisualStyleBackColor = true;
			// 
			// _openInterfacDRSDialog
			// 
			resources.ApplyResources(this._openInterfacDRSDialog, "_openInterfacDRSDialog");
			// 
			// NewProjectForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._reducedProjectButton);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._finishButton);
			this.Controls.Add(this._fullProjectButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._minimalProjectButton);
			this.Controls.Add(this._interfacDRSButton);
			this.Controls.Add(this._dllButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._interfacDRSTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._dllTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "NewProjectForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _interfacDRSTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _dllTextBox;
		private System.Windows.Forms.Button _interfacDRSButton;
		private System.Windows.Forms.Button _dllButton;
		private System.Windows.Forms.RadioButton _minimalProjectButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton _fullProjectButton;
		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _finishButton;
		private System.Windows.Forms.SaveFileDialog _saveProjectDialog;
		private System.Windows.Forms.OpenFileDialog _openDLLDialog;
		private System.Windows.Forms.ToolTip _dllHelpBox;
		private System.Windows.Forms.OpenFileDialog _openInterfacDRSDialog;
		private System.Windows.Forms.RadioButton _reducedProjectButton;
	}
}