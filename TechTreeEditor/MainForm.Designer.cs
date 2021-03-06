﻿namespace TechTreeEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this._menuContainer = new System.Windows.Forms.ToolStripContainer();
			this._statusStrip = new System.Windows.Forms.StatusStrip();
			this._statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this._selectedNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this._renderPanel = new TechTreeEditor.RenderControl();
			this._toolBoxBar = new System.Windows.Forms.ToolStrip();
			this._newUnitButton = new System.Windows.Forms.ToolStripButton();
			this._newBuildingButton = new System.Windows.Forms.ToolStripButton();
			this._newResearchButton = new System.Windows.Forms.ToolStripButton();
			this._newEyeCandyButton = new System.Windows.Forms.ToolStripButton();
			this._newProjectileButton = new System.Windows.Forms.ToolStripButton();
			this._newDeadButton = new System.Windows.Forms.ToolStripButton();
			this._menuSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this._newLinkButton = new System.Windows.Forms.ToolStripButton();
			this._deleteLinkButton = new System.Windows.Forms.ToolStripButton();
			this._setNewTechTreeParentButton = new System.Windows.Forms.ToolStripButton();
			this._menuSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this._newMakeAvailDepButton = new System.Windows.Forms.ToolStripButton();
			this._newSuccResDepButton = new System.Windows.Forms.ToolStripButton();
			this._newBuildingDepButton = new System.Windows.Forms.ToolStripButton();
			this._deleteDepButton = new System.Windows.Forms.ToolStripButton();
			this._menuSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this._deleteElementButton = new System.Windows.Forms.ToolStripButton();
			this._civCopyBar = new System.Windows.Forms.ToolStrip();
			this._mainMenu = new System.Windows.Forms.MenuStrip();
			this._fileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._newProjectMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._openProjectMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._saveProjectMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._importDATMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._exportDATMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._importBalancingFileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._renderScreenshotMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._projectSettingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._exitMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._editMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._undoMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._redoMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._menuSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this._copyMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._pasteMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._pasteTreeMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._menuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this._lockAllIDsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._viewMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._unitRendererMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._pluginMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._helpMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._languageMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._languageGermanMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._languageEnglishMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._infoMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._projectToolBar = new System.Windows.Forms.ToolStrip();
			this._newProjectButton = new System.Windows.Forms.ToolStripButton();
			this._openProjectButton = new System.Windows.Forms.ToolStripButton();
			this._saveProjectButton = new System.Windows.Forms.ToolStripButton();
			this._exportDATButton = new System.Windows.Forms.ToolStripButton();
			this._mainToolBar = new System.Windows.Forms.ToolStrip();
			this._civSelectComboBox = new System.Windows.Forms.ToolStripComboBox();
			this._menuSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this._editGraphicsButton = new System.Windows.Forms.ToolStripButton();
			this._editCivBoniButton = new System.Windows.Forms.ToolStripButton();
			this._menuSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this._editorModeButton = new System.Windows.Forms.ToolStripButton();
			this._standardModeButton = new System.Windows.Forms.ToolStripButton();
			this._menuSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this._searchTextBox = new System.Windows.Forms.ToolStripTextBox();
			this._searchLabel = new System.Windows.Forms.ToolStripLabel();
			this._addToolsBar = new System.Windows.Forms.ToolStrip();
			this._ageUpButton = new System.Windows.Forms.ToolStripButton();
			this._ageDownButton = new System.Windows.Forms.ToolStripButton();
			this._menuSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this._editAttributesButton = new System.Windows.Forms.ToolStripButton();
			this._editElementPropertiesButton = new System.Windows.Forms.ToolStripButton();
			this._menuSeparator16 = new System.Windows.Forms.ToolStripSeparator();
			this._elementLeftButton = new System.Windows.Forms.ToolStripButton();
			this._elementRightButton = new System.Windows.Forms.ToolStripButton();
			this._techTreeElementContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._standardElementCheckButton = new System.Windows.Forms.ToolStripMenuItem();
			this._menuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this._showInEditorCheckButton = new System.Windows.Forms.ToolStripMenuItem();
			this._gaiaOnlyCheckButton = new System.Windows.Forms.ToolStripMenuItem();
			this._lockIDCheckButton = new System.Windows.Forms.ToolStripMenuItem();
			this._menuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this._blockForCivCheckButton = new System.Windows.Forms.ToolStripMenuItem();
			this._freeForCivCheckButton = new System.Windows.Forms.ToolStripMenuItem();
			this._menuSeparator15 = new System.Windows.Forms.ToolStripSeparator();
			this._showInNewTechTreeCheckButton = new System.Windows.Forms.ToolStripMenuItem();
			this._hideIfDisabledInNewTechTreeCheckButton = new System.Windows.Forms.ToolStripMenuItem();
			this._menuSeparator17 = new System.Windows.Forms.ToolStripSeparator();
			this._menuSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this._editAttributesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._editElementPropertiesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._menuSeparator14 = new System.Windows.Forms.ToolStripSeparator();
			this._sortChildrenMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._showUnitInRendererMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this._openProjectDialog = new System.Windows.Forms.OpenFileDialog();
			this._renderScreenshotDialog = new System.Windows.Forms.SaveFileDialog();
			this._openBalancingFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._menuContainer.BottomToolStripPanel.SuspendLayout();
			this._menuContainer.ContentPanel.SuspendLayout();
			this._menuContainer.LeftToolStripPanel.SuspendLayout();
			this._menuContainer.RightToolStripPanel.SuspendLayout();
			this._menuContainer.TopToolStripPanel.SuspendLayout();
			this._menuContainer.SuspendLayout();
			this._statusStrip.SuspendLayout();
			this._toolBoxBar.SuspendLayout();
			this._mainMenu.SuspendLayout();
			this._projectToolBar.SuspendLayout();
			this._mainToolBar.SuspendLayout();
			this._addToolsBar.SuspendLayout();
			this._techTreeElementContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// _menuContainer
			// 
			// 
			// _menuContainer.BottomToolStripPanel
			// 
			this._menuContainer.BottomToolStripPanel.Controls.Add(this._statusStrip);
			// 
			// _menuContainer.ContentPanel
			// 
			this._menuContainer.ContentPanel.Controls.Add(this._renderPanel);
			resources.ApplyResources(this._menuContainer.ContentPanel, "_menuContainer.ContentPanel");
			resources.ApplyResources(this._menuContainer, "_menuContainer");
			// 
			// _menuContainer.LeftToolStripPanel
			// 
			this._menuContainer.LeftToolStripPanel.Controls.Add(this._toolBoxBar);
			this._menuContainer.Name = "_menuContainer";
			// 
			// _menuContainer.RightToolStripPanel
			// 
			this._menuContainer.RightToolStripPanel.Controls.Add(this._civCopyBar);
			// 
			// _menuContainer.TopToolStripPanel
			// 
			this._menuContainer.TopToolStripPanel.Controls.Add(this._mainMenu);
			this._menuContainer.TopToolStripPanel.Controls.Add(this._projectToolBar);
			this._menuContainer.TopToolStripPanel.Controls.Add(this._mainToolBar);
			this._menuContainer.TopToolStripPanel.Controls.Add(this._addToolsBar);
			// 
			// _statusStrip
			// 
			resources.ApplyResources(this._statusStrip, "_statusStrip");
			this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusLabel,
            this._selectedNameLabel});
			this._statusStrip.Name = "_statusStrip";
			// 
			// _statusLabel
			// 
			resources.ApplyResources(this._statusLabel, "_statusLabel");
			this._statusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._statusLabel.Name = "_statusLabel";
			// 
			// _selectedNameLabel
			// 
			this._selectedNameLabel.Name = "_selectedNameLabel";
			resources.ApplyResources(this._selectedNameLabel, "_selectedNameLabel");
			// 
			// _renderPanel
			// 
			resources.ApplyResources(this._renderPanel, "_renderPanel");
			this._renderPanel.Name = "_renderPanel";
			this._renderPanel.SelectionChanged += new TechTreeEditor.RenderControl.SelectionChangedEventHandler(this._renderPanel_SelectionChanged);
			this._renderPanel.DoubleClick += new System.EventHandler(this._renderPanel_DoubleClick);
			this._renderPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this._renderPanel_KeyDown);
			this._renderPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this._renderPanel_MouseClick);
			// 
			// _toolBoxBar
			// 
			resources.ApplyResources(this._toolBoxBar, "_toolBoxBar");
			this._toolBoxBar.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._toolBoxBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newUnitButton,
            this._newBuildingButton,
            this._newResearchButton,
            this._newEyeCandyButton,
            this._newProjectileButton,
            this._newDeadButton,
            this._menuSeparator7,
            this._newLinkButton,
            this._deleteLinkButton,
            this._setNewTechTreeParentButton,
            this._menuSeparator8,
            this._newMakeAvailDepButton,
            this._newSuccResDepButton,
            this._newBuildingDepButton,
            this._deleteDepButton,
            this._menuSeparator9,
            this._deleteElementButton});
			this._toolBoxBar.Name = "_toolBoxBar";
			// 
			// _newUnitButton
			// 
			this._newUnitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newUnitButton, "_newUnitButton");
			this._newUnitButton.Name = "_newUnitButton";
			this._newUnitButton.Click += new System.EventHandler(this._newUnitButton_Click);
			// 
			// _newBuildingButton
			// 
			this._newBuildingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newBuildingButton, "_newBuildingButton");
			this._newBuildingButton.Name = "_newBuildingButton";
			this._newBuildingButton.Click += new System.EventHandler(this._newBuildingButton_Click);
			// 
			// _newResearchButton
			// 
			this._newResearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newResearchButton, "_newResearchButton");
			this._newResearchButton.Name = "_newResearchButton";
			this._newResearchButton.Click += new System.EventHandler(this._newResearchButton_Click);
			// 
			// _newEyeCandyButton
			// 
			this._newEyeCandyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newEyeCandyButton, "_newEyeCandyButton");
			this._newEyeCandyButton.Image = global::TechTreeEditor.Icons.NewEyeCandy;
			this._newEyeCandyButton.Name = "_newEyeCandyButton";
			this._newEyeCandyButton.Click += new System.EventHandler(this._newEyeCandyButton_Click);
			// 
			// _newProjectileButton
			// 
			this._newProjectileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newProjectileButton, "_newProjectileButton");
			this._newProjectileButton.Image = global::TechTreeEditor.Icons.NewProjectile;
			this._newProjectileButton.Name = "_newProjectileButton";
			this._newProjectileButton.Click += new System.EventHandler(this._newProjectileButton_Click);
			// 
			// _newDeadButton
			// 
			this._newDeadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newDeadButton, "_newDeadButton");
			this._newDeadButton.Image = global::TechTreeEditor.Icons.NewDead;
			this._newDeadButton.Name = "_newDeadButton";
			this._newDeadButton.Click += new System.EventHandler(this._newDeadButton_Click);
			// 
			// _menuSeparator7
			// 
			this._menuSeparator7.Name = "_menuSeparator7";
			resources.ApplyResources(this._menuSeparator7, "_menuSeparator7");
			// 
			// _newLinkButton
			// 
			this._newLinkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newLinkButton, "_newLinkButton");
			this._newLinkButton.Name = "_newLinkButton";
			this._newLinkButton.Click += new System.EventHandler(this._newLinkButton_Click);
			// 
			// _deleteLinkButton
			// 
			this._deleteLinkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._deleteLinkButton, "_deleteLinkButton");
			this._deleteLinkButton.Name = "_deleteLinkButton";
			this._deleteLinkButton.Click += new System.EventHandler(this._deleteLinkButton_Click);
			// 
			// _setNewTechTreeParentButton
			// 
			this._setNewTechTreeParentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._setNewTechTreeParentButton, "_setNewTechTreeParentButton");
			this._setNewTechTreeParentButton.Image = global::TechTreeEditor.Icons.SetAlternateNewTechTreeParent;
			this._setNewTechTreeParentButton.Name = "_setNewTechTreeParentButton";
			this._setNewTechTreeParentButton.Click += new System.EventHandler(this._setNewTechTreeParentButton_Click);
			// 
			// _menuSeparator8
			// 
			this._menuSeparator8.Name = "_menuSeparator8";
			resources.ApplyResources(this._menuSeparator8, "_menuSeparator8");
			// 
			// _newMakeAvailDepButton
			// 
			this._newMakeAvailDepButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newMakeAvailDepButton, "_newMakeAvailDepButton");
			this._newMakeAvailDepButton.Image = global::TechTreeEditor.Icons.MakeAvailDependency;
			this._newMakeAvailDepButton.Name = "_newMakeAvailDepButton";
			this._newMakeAvailDepButton.Click += new System.EventHandler(this._newMakeAvailDepButton_Click);
			// 
			// _newSuccResDepButton
			// 
			this._newSuccResDepButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newSuccResDepButton, "_newSuccResDepButton");
			this._newSuccResDepButton.Image = global::TechTreeEditor.Icons.UpgradeDependency;
			this._newSuccResDepButton.Name = "_newSuccResDepButton";
			this._newSuccResDepButton.Click += new System.EventHandler(this._newSuccResDepButton_Click);
			// 
			// _newBuildingDepButton
			// 
			this._newBuildingDepButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._newBuildingDepButton, "_newBuildingDepButton");
			this._newBuildingDepButton.Image = global::TechTreeEditor.Icons.BuildingDependeny;
			this._newBuildingDepButton.Name = "_newBuildingDepButton";
			this._newBuildingDepButton.Click += new System.EventHandler(this._newBuildingDepButton_Click);
			// 
			// _deleteDepButton
			// 
			this._deleteDepButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._deleteDepButton, "_deleteDepButton");
			this._deleteDepButton.Image = global::TechTreeEditor.Icons.DeleteDependency;
			this._deleteDepButton.Name = "_deleteDepButton";
			this._deleteDepButton.Click += new System.EventHandler(this._deleteDepButton_Click);
			// 
			// _menuSeparator9
			// 
			this._menuSeparator9.Name = "_menuSeparator9";
			resources.ApplyResources(this._menuSeparator9, "_menuSeparator9");
			// 
			// _deleteElementButton
			// 
			this._deleteElementButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._deleteElementButton, "_deleteElementButton");
			this._deleteElementButton.Image = global::TechTreeEditor.Icons.DeleteElement;
			this._deleteElementButton.Name = "_deleteElementButton";
			this._deleteElementButton.Click += new System.EventHandler(this._deleteElementButton_Click);
			// 
			// _civCopyBar
			// 
			resources.ApplyResources(this._civCopyBar, "_civCopyBar");
			this._civCopyBar.Name = "_civCopyBar";
			// 
			// _mainMenu
			// 
			resources.ApplyResources(this._mainMenu, "_mainMenu");
			this._mainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenuButton,
            this._editMenuButton,
            this._viewMenuButton,
            this._pluginMenuButton,
            this._helpMenuButton});
			this._mainMenu.Name = "_mainMenu";
			// 
			// _fileMenuButton
			// 
			this._fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newProjectMenuButton,
            this._openProjectMenuButton,
            this._saveProjectMenuButton,
            this._importDATMenuButton,
            this._exportDATMenuButton,
            this._importBalancingFileMenuButton,
            this._renderScreenshotMenuButton,
            this._projectSettingsMenuButton,
            this._menuSeparator1,
            this._exitMenuButton});
			this._fileMenuButton.Name = "_fileMenuButton";
			resources.ApplyResources(this._fileMenuButton, "_fileMenuButton");
			// 
			// _newProjectMenuButton
			// 
			this._newProjectMenuButton.Image = global::TechTreeEditor.Icons.NewProject;
			this._newProjectMenuButton.Name = "_newProjectMenuButton";
			resources.ApplyResources(this._newProjectMenuButton, "_newProjectMenuButton");
			this._newProjectMenuButton.Click += new System.EventHandler(this._newProjectMenuButton_Click);
			// 
			// _openProjectMenuButton
			// 
			resources.ApplyResources(this._openProjectMenuButton, "_openProjectMenuButton");
			this._openProjectMenuButton.Name = "_openProjectMenuButton";
			this._openProjectMenuButton.Click += new System.EventHandler(this._openProjectMenuButton_Click);
			// 
			// _saveProjectMenuButton
			// 
			resources.ApplyResources(this._saveProjectMenuButton, "_saveProjectMenuButton");
			this._saveProjectMenuButton.Name = "_saveProjectMenuButton";
			this._saveProjectMenuButton.Click += new System.EventHandler(this._saveProjectMenuButton_Click);
			// 
			// _importDATMenuButton
			// 
			this._importDATMenuButton.Image = global::TechTreeEditor.Icons.ImportProject;
			this._importDATMenuButton.Name = "_importDATMenuButton";
			resources.ApplyResources(this._importDATMenuButton, "_importDATMenuButton");
			this._importDATMenuButton.Click += new System.EventHandler(this._importDATMenuButton_Click);
			// 
			// _exportDATMenuButton
			// 
			resources.ApplyResources(this._exportDATMenuButton, "_exportDATMenuButton");
			this._exportDATMenuButton.Image = global::TechTreeEditor.Icons.ExportProject;
			this._exportDATMenuButton.Name = "_exportDATMenuButton";
			this._exportDATMenuButton.Click += new System.EventHandler(this._exportDATMenuButton_Click);
			// 
			// _importBalancingFileMenuButton
			// 
			resources.ApplyResources(this._importBalancingFileMenuButton, "_importBalancingFileMenuButton");
			this._importBalancingFileMenuButton.Image = global::TechTreeEditor.Icons.ImportBalancingFile;
			this._importBalancingFileMenuButton.Name = "_importBalancingFileMenuButton";
			this._importBalancingFileMenuButton.Click += new System.EventHandler(this._importBalancingFileMenuButton_Click);
			// 
			// _renderScreenshotMenuButton
			// 
			resources.ApplyResources(this._renderScreenshotMenuButton, "_renderScreenshotMenuButton");
			this._renderScreenshotMenuButton.Image = global::TechTreeEditor.Icons.RenderScreenshot;
			this._renderScreenshotMenuButton.Name = "_renderScreenshotMenuButton";
			this._renderScreenshotMenuButton.Click += new System.EventHandler(this._renderScreenshotMenuButton_Click);
			// 
			// _projectSettingsMenuButton
			// 
			resources.ApplyResources(this._projectSettingsMenuButton, "_projectSettingsMenuButton");
			this._projectSettingsMenuButton.Image = global::TechTreeEditor.Icons.ProjectSettings;
			this._projectSettingsMenuButton.Name = "_projectSettingsMenuButton";
			this._projectSettingsMenuButton.Click += new System.EventHandler(this._projectSettingsButton_Click);
			// 
			// _menuSeparator1
			// 
			this._menuSeparator1.Name = "_menuSeparator1";
			resources.ApplyResources(this._menuSeparator1, "_menuSeparator1");
			// 
			// _exitMenuButton
			// 
			resources.ApplyResources(this._exitMenuButton, "_exitMenuButton");
			this._exitMenuButton.Name = "_exitMenuButton";
			this._exitMenuButton.Click += new System.EventHandler(this._exitMenuButton_Click);
			// 
			// _editMenuButton
			// 
			this._editMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._undoMenuButton,
            this._redoMenuButton,
            this._menuSeparator13,
            this._copyMenuButton,
            this._pasteMenuButton,
            this._pasteTreeMenuButton,
            this._menuSeparator2,
            this._lockAllIDsMenuButton});
			this._editMenuButton.Name = "_editMenuButton";
			resources.ApplyResources(this._editMenuButton, "_editMenuButton");
			// 
			// _undoMenuButton
			// 
			resources.ApplyResources(this._undoMenuButton, "_undoMenuButton");
			this._undoMenuButton.Name = "_undoMenuButton";
			// 
			// _redoMenuButton
			// 
			resources.ApplyResources(this._redoMenuButton, "_redoMenuButton");
			this._redoMenuButton.Name = "_redoMenuButton";
			// 
			// _menuSeparator13
			// 
			this._menuSeparator13.Name = "_menuSeparator13";
			resources.ApplyResources(this._menuSeparator13, "_menuSeparator13");
			// 
			// _copyMenuButton
			// 
			resources.ApplyResources(this._copyMenuButton, "_copyMenuButton");
			this._copyMenuButton.Image = global::TechTreeEditor.Icons.Copy;
			this._copyMenuButton.Name = "_copyMenuButton";
			this._copyMenuButton.Click += new System.EventHandler(this._copyMenuButton_Click);
			// 
			// _pasteMenuButton
			// 
			resources.ApplyResources(this._pasteMenuButton, "_pasteMenuButton");
			this._pasteMenuButton.Image = global::TechTreeEditor.Icons.PasteElement;
			this._pasteMenuButton.Name = "_pasteMenuButton";
			this._pasteMenuButton.Click += new System.EventHandler(this._pasteMenuButton_Click);
			// 
			// _pasteTreeMenuButton
			// 
			resources.ApplyResources(this._pasteTreeMenuButton, "_pasteTreeMenuButton");
			this._pasteTreeMenuButton.Image = global::TechTreeEditor.Icons.PasteTree;
			this._pasteTreeMenuButton.Name = "_pasteTreeMenuButton";
			this._pasteTreeMenuButton.Click += new System.EventHandler(this._pasteTreeMenuButton_Click);
			// 
			// _menuSeparator2
			// 
			this._menuSeparator2.Name = "_menuSeparator2";
			resources.ApplyResources(this._menuSeparator2, "_menuSeparator2");
			// 
			// _lockAllIDsMenuButton
			// 
			resources.ApplyResources(this._lockAllIDsMenuButton, "_lockAllIDsMenuButton");
			this._lockAllIDsMenuButton.Image = global::TechTreeEditor.Icons.LockAll;
			this._lockAllIDsMenuButton.Name = "_lockAllIDsMenuButton";
			this._lockAllIDsMenuButton.Click += new System.EventHandler(this._lockAllIDsMenuButton_Click);
			// 
			// _viewMenuButton
			// 
			this._viewMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._unitRendererMenuButton});
			this._viewMenuButton.Name = "_viewMenuButton";
			resources.ApplyResources(this._viewMenuButton, "_viewMenuButton");
			// 
			// _unitRendererMenuButton
			// 
			resources.ApplyResources(this._unitRendererMenuButton, "_unitRendererMenuButton");
			this._unitRendererMenuButton.Image = global::TechTreeEditor.Icons.RenderWindow;
			this._unitRendererMenuButton.Name = "_unitRendererMenuButton";
			this._unitRendererMenuButton.Click += new System.EventHandler(this._unitRendererMenuButton_Click);
			// 
			// _pluginMenuButton
			// 
			resources.ApplyResources(this._pluginMenuButton, "_pluginMenuButton");
			this._pluginMenuButton.Name = "_pluginMenuButton";
			// 
			// _helpMenuButton
			// 
			this._helpMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._languageMenuButton,
            this._infoMenuButton});
			this._helpMenuButton.Name = "_helpMenuButton";
			resources.ApplyResources(this._helpMenuButton, "_helpMenuButton");
			// 
			// _languageMenuButton
			// 
			this._languageMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._languageGermanMenuButton,
            this._languageEnglishMenuButton});
			this._languageMenuButton.Image = global::TechTreeEditor.Icons.LanguageSelection;
			this._languageMenuButton.Name = "_languageMenuButton";
			resources.ApplyResources(this._languageMenuButton, "_languageMenuButton");
			// 
			// _languageGermanMenuButton
			// 
			this._languageGermanMenuButton.CheckOnClick = true;
			this._languageGermanMenuButton.Image = global::TechTreeEditor.Icons.LanguageGerman;
			this._languageGermanMenuButton.Name = "_languageGermanMenuButton";
			resources.ApplyResources(this._languageGermanMenuButton, "_languageGermanMenuButton");
			this._languageGermanMenuButton.CheckedChanged += new System.EventHandler(this._languageGermanMenuButton_CheckedChanged);
			// 
			// _languageEnglishMenuButton
			// 
			this._languageEnglishMenuButton.CheckOnClick = true;
			this._languageEnglishMenuButton.Image = global::TechTreeEditor.Icons.LanguageEnglish;
			this._languageEnglishMenuButton.Name = "_languageEnglishMenuButton";
			resources.ApplyResources(this._languageEnglishMenuButton, "_languageEnglishMenuButton");
			this._languageEnglishMenuButton.CheckedChanged += new System.EventHandler(this._languageEnglishMenuButton_CheckedChanged);
			// 
			// _infoMenuButton
			// 
			resources.ApplyResources(this._infoMenuButton, "_infoMenuButton");
			this._infoMenuButton.Name = "_infoMenuButton";
			this._infoMenuButton.Click += new System.EventHandler(this._infoMenuButton_Click);
			// 
			// _projectToolBar
			// 
			resources.ApplyResources(this._projectToolBar, "_projectToolBar");
			this._projectToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._projectToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newProjectButton,
            this._openProjectButton,
            this._saveProjectButton,
            this._exportDATButton});
			this._projectToolBar.Name = "_projectToolBar";
			// 
			// _newProjectButton
			// 
			this._newProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._newProjectButton.Image = global::TechTreeEditor.Icons.NewProject;
			resources.ApplyResources(this._newProjectButton, "_newProjectButton");
			this._newProjectButton.Name = "_newProjectButton";
			this._newProjectButton.Click += new System.EventHandler(this._newProjectButton_Click);
			// 
			// _openProjectButton
			// 
			this._openProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._openProjectButton, "_openProjectButton");
			this._openProjectButton.Name = "_openProjectButton";
			this._openProjectButton.Click += new System.EventHandler(this._openProjectButton_Click);
			// 
			// _saveProjectButton
			// 
			this._saveProjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._saveProjectButton, "_saveProjectButton");
			this._saveProjectButton.Name = "_saveProjectButton";
			this._saveProjectButton.Click += new System.EventHandler(this._saveProjectButton_Click);
			// 
			// _exportDATButton
			// 
			this._exportDATButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._exportDATButton, "_exportDATButton");
			this._exportDATButton.Image = global::TechTreeEditor.Icons.ExportProject;
			this._exportDATButton.Name = "_exportDATButton";
			this._exportDATButton.Click += new System.EventHandler(this._exportDATButton_Click);
			// 
			// _mainToolBar
			// 
			resources.ApplyResources(this._mainToolBar, "_mainToolBar");
			this._mainToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._civSelectComboBox,
            this._menuSeparator12,
            this._editGraphicsButton,
            this._editCivBoniButton,
            this._menuSeparator5,
            this._editorModeButton,
            this._standardModeButton,
            this._menuSeparator6,
            this._searchTextBox,
            this._searchLabel});
			this._mainToolBar.Name = "_mainToolBar";
			// 
			// _civSelectComboBox
			// 
			this._civSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this._civSelectComboBox, "_civSelectComboBox");
			this._civSelectComboBox.Name = "_civSelectComboBox";
			this._civSelectComboBox.SelectedIndexChanged += new System.EventHandler(this._civSelectComboBox_SelectedIndexChanged);
			// 
			// _menuSeparator12
			// 
			this._menuSeparator12.Name = "_menuSeparator12";
			resources.ApplyResources(this._menuSeparator12, "_menuSeparator12");
			// 
			// _editGraphicsButton
			// 
			this._editGraphicsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._editGraphicsButton, "_editGraphicsButton");
			this._editGraphicsButton.Image = global::TechTreeEditor.Icons.EditGraphics;
			this._editGraphicsButton.Name = "_editGraphicsButton";
			this._editGraphicsButton.Click += new System.EventHandler(this._editGraphicsButton_Click);
			// 
			// _editCivBoniButton
			// 
			this._editCivBoniButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._editCivBoniButton, "_editCivBoniButton");
			this._editCivBoniButton.Image = global::TechTreeEditor.Icons.EditCivBoni;
			this._editCivBoniButton.Name = "_editCivBoniButton";
			this._editCivBoniButton.Click += new System.EventHandler(this._editCivBoniButton_Click);
			// 
			// _menuSeparator5
			// 
			this._menuSeparator5.Name = "_menuSeparator5";
			resources.ApplyResources(this._menuSeparator5, "_menuSeparator5");
			// 
			// _editorModeButton
			// 
			this._editorModeButton.Checked = true;
			this._editorModeButton.CheckOnClick = true;
			this._editorModeButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this._editorModeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._editorModeButton, "_editorModeButton");
			this._editorModeButton.Name = "_editorModeButton";
			this._editorModeButton.CheckedChanged += new System.EventHandler(this._editorModeButton_CheckedChanged);
			// 
			// _standardModeButton
			// 
			this._standardModeButton.CheckOnClick = true;
			this._standardModeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._standardModeButton, "_standardModeButton");
			this._standardModeButton.Name = "_standardModeButton";
			this._standardModeButton.CheckedChanged += new System.EventHandler(this._standardModeButton_CheckedChanged);
			// 
			// _menuSeparator6
			// 
			this._menuSeparator6.Name = "_menuSeparator6";
			resources.ApplyResources(this._menuSeparator6, "_menuSeparator6");
			// 
			// _searchTextBox
			// 
			resources.ApplyResources(this._searchTextBox, "_searchTextBox");
			this._searchTextBox.Name = "_searchTextBox";
			this._searchTextBox.TextChanged += new System.EventHandler(this._searchTextBox_TextChanged);
			// 
			// _searchLabel
			// 
			resources.ApplyResources(this._searchLabel, "_searchLabel");
			this._searchLabel.BackColor = System.Drawing.Color.Transparent;
			this._searchLabel.BackgroundImage = global::TechTreeEditor.Icons.Search;
			this._searchLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._searchLabel.Name = "_searchLabel";
			// 
			// _addToolsBar
			// 
			resources.ApplyResources(this._addToolsBar, "_addToolsBar");
			this._addToolsBar.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._addToolsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ageUpButton,
            this._ageDownButton,
            this._menuSeparator11,
            this._editAttributesButton,
            this._editElementPropertiesButton,
            this._menuSeparator16,
            this._elementLeftButton,
            this._elementRightButton});
			this._addToolsBar.Name = "_addToolsBar";
			// 
			// _ageUpButton
			// 
			this._ageUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._ageUpButton, "_ageUpButton");
			this._ageUpButton.Image = global::TechTreeEditor.Icons.AgeUp;
			this._ageUpButton.Name = "_ageUpButton";
			this._ageUpButton.Click += new System.EventHandler(this._ageUpButton_Click);
			// 
			// _ageDownButton
			// 
			this._ageDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._ageDownButton, "_ageDownButton");
			this._ageDownButton.Image = global::TechTreeEditor.Icons.AgeDown;
			this._ageDownButton.Name = "_ageDownButton";
			this._ageDownButton.Click += new System.EventHandler(this._ageDownButton_Click);
			// 
			// _menuSeparator11
			// 
			this._menuSeparator11.Name = "_menuSeparator11";
			resources.ApplyResources(this._menuSeparator11, "_menuSeparator11");
			// 
			// _editAttributesButton
			// 
			this._editAttributesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._editAttributesButton, "_editAttributesButton");
			this._editAttributesButton.Image = global::TechTreeEditor.Icons.EditAttributes;
			this._editAttributesButton.Name = "_editAttributesButton";
			this._editAttributesButton.Click += new System.EventHandler(this._editAttributesButton_Click);
			// 
			// _editElementPropertiesButton
			// 
			this._editElementPropertiesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._editElementPropertiesButton, "_editElementPropertiesButton");
			this._editElementPropertiesButton.Image = global::TechTreeEditor.Icons.EditElementBig;
			this._editElementPropertiesButton.Name = "_editElementPropertiesButton";
			this._editElementPropertiesButton.Click += new System.EventHandler(this._editElementPropertiesButton_Click);
			// 
			// _menuSeparator16
			// 
			this._menuSeparator16.Name = "_menuSeparator16";
			resources.ApplyResources(this._menuSeparator16, "_menuSeparator16");
			// 
			// _elementLeftButton
			// 
			this._elementLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._elementLeftButton, "_elementLeftButton");
			this._elementLeftButton.Image = global::TechTreeEditor.Icons.MoveLeft;
			this._elementLeftButton.Name = "_elementLeftButton";
			this._elementLeftButton.Click += new System.EventHandler(this._elementLeftButton_Click);
			// 
			// _elementRightButton
			// 
			this._elementRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this._elementRightButton, "_elementRightButton");
			this._elementRightButton.Image = global::TechTreeEditor.Icons.MoveRight;
			this._elementRightButton.Name = "_elementRightButton";
			this._elementRightButton.Click += new System.EventHandler(this._elementRightButton_Click);
			// 
			// _techTreeElementContextMenu
			// 
			this._techTreeElementContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._standardElementCheckButton,
            this._menuSeparator3,
            this._showInEditorCheckButton,
            this._gaiaOnlyCheckButton,
            this._lockIDCheckButton,
            this._menuSeparator4,
            this._blockForCivCheckButton,
            this._freeForCivCheckButton,
            this._menuSeparator15,
            this._showInNewTechTreeCheckButton,
            this._menuSeparator10,
            this._editAttributesMenuButton,
            this._editElementPropertiesMenuButton,
            this._menuSeparator14,
            this._sortChildrenMenuButton,
            this._showUnitInRendererMenuButton});
			this._techTreeElementContextMenu.Name = "_techTreeElementContextMenu";
			resources.ApplyResources(this._techTreeElementContextMenu, "_techTreeElementContextMenu");
			this._techTreeElementContextMenu.MouseEnter += new System.EventHandler(this._techTreeElementContextMenu_MouseEnter);
			this._techTreeElementContextMenu.MouseLeave += new System.EventHandler(this._techTreeElementContextMenu_MouseLeave);
			// 
			// _standardElementCheckButton
			// 
			this._standardElementCheckButton.CheckOnClick = true;
			resources.ApplyResources(this._standardElementCheckButton, "_standardElementCheckButton");
			this._standardElementCheckButton.Name = "_standardElementCheckButton";
			this._standardElementCheckButton.CheckedChanged += new System.EventHandler(this._standardElementCheckButton_CheckedChanged);
			// 
			// _menuSeparator3
			// 
			this._menuSeparator3.Name = "_menuSeparator3";
			resources.ApplyResources(this._menuSeparator3, "_menuSeparator3");
			// 
			// _showInEditorCheckButton
			// 
			this._showInEditorCheckButton.CheckOnClick = true;
			resources.ApplyResources(this._showInEditorCheckButton, "_showInEditorCheckButton");
			this._showInEditorCheckButton.Name = "_showInEditorCheckButton";
			this._showInEditorCheckButton.CheckedChanged += new System.EventHandler(this._showInEditorCheckButton_CheckedChanged);
			// 
			// _gaiaOnlyCheckButton
			// 
			this._gaiaOnlyCheckButton.CheckOnClick = true;
			resources.ApplyResources(this._gaiaOnlyCheckButton, "_gaiaOnlyCheckButton");
			this._gaiaOnlyCheckButton.Name = "_gaiaOnlyCheckButton";
			this._gaiaOnlyCheckButton.CheckedChanged += new System.EventHandler(this._gaiaOnlyCheckButton_CheckedChanged);
			// 
			// _lockIDCheckButton
			// 
			this._lockIDCheckButton.CheckOnClick = true;
			resources.ApplyResources(this._lockIDCheckButton, "_lockIDCheckButton");
			this._lockIDCheckButton.Name = "_lockIDCheckButton";
			this._lockIDCheckButton.CheckedChanged += new System.EventHandler(this._lockIDCheckButton_CheckedChanged);
			// 
			// _menuSeparator4
			// 
			this._menuSeparator4.Name = "_menuSeparator4";
			resources.ApplyResources(this._menuSeparator4, "_menuSeparator4");
			// 
			// _blockForCivCheckButton
			// 
			this._blockForCivCheckButton.CheckOnClick = true;
			resources.ApplyResources(this._blockForCivCheckButton, "_blockForCivCheckButton");
			this._blockForCivCheckButton.Name = "_blockForCivCheckButton";
			this._blockForCivCheckButton.CheckedChanged += new System.EventHandler(this._blockForCivCheckButton_CheckedChanged);
			// 
			// _freeForCivCheckButton
			// 
			this._freeForCivCheckButton.CheckOnClick = true;
			resources.ApplyResources(this._freeForCivCheckButton, "_freeForCivCheckButton");
			this._freeForCivCheckButton.Name = "_freeForCivCheckButton";
			this._freeForCivCheckButton.CheckedChanged += new System.EventHandler(this._freeForCivCheckButton_CheckedChanged);
			// 
			// _menuSeparator15
			// 
			this._menuSeparator15.Name = "_menuSeparator15";
			resources.ApplyResources(this._menuSeparator15, "_menuSeparator15");
			// 
			// _showInNewTechTreeCheckButton
			// 
			this._showInNewTechTreeCheckButton.CheckOnClick = true;
			this._showInNewTechTreeCheckButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._hideIfDisabledInNewTechTreeCheckButton,
            this._menuSeparator17});
			this._showInNewTechTreeCheckButton.Image = global::TechTreeEditor.Icons.ShowInNewTechTree;
			this._showInNewTechTreeCheckButton.Name = "_showInNewTechTreeCheckButton";
			resources.ApplyResources(this._showInNewTechTreeCheckButton, "_showInNewTechTreeCheckButton");
			this._showInNewTechTreeCheckButton.CheckedChanged += new System.EventHandler(this._showInNewTechTreeCheckButton_CheckedChanged);
			// 
			// _hideIfDisabledInNewTechTreeCheckButton
			// 
			this._hideIfDisabledInNewTechTreeCheckButton.CheckOnClick = true;
			this._hideIfDisabledInNewTechTreeCheckButton.Image = global::TechTreeEditor.Icons.HideIfDisabledInNewTechTree;
			this._hideIfDisabledInNewTechTreeCheckButton.Name = "_hideIfDisabledInNewTechTreeCheckButton";
			resources.ApplyResources(this._hideIfDisabledInNewTechTreeCheckButton, "_hideIfDisabledInNewTechTreeCheckButton");
			this._hideIfDisabledInNewTechTreeCheckButton.CheckedChanged += new System.EventHandler(this._hideIfDisabledInNewTechTreeCheckButton_CheckedChanged);
			// 
			// _menuSeparator17
			// 
			this._menuSeparator17.Name = "_menuSeparator17";
			resources.ApplyResources(this._menuSeparator17, "_menuSeparator17");
			// 
			// _menuSeparator10
			// 
			this._menuSeparator10.Name = "_menuSeparator10";
			resources.ApplyResources(this._menuSeparator10, "_menuSeparator10");
			// 
			// _editAttributesMenuButton
			// 
			this._editAttributesMenuButton.Image = global::TechTreeEditor.Icons.EditAttributesSmall;
			this._editAttributesMenuButton.Name = "_editAttributesMenuButton";
			resources.ApplyResources(this._editAttributesMenuButton, "_editAttributesMenuButton");
			this._editAttributesMenuButton.Click += new System.EventHandler(this._editAttributesMenuButton_Click);
			// 
			// _editElementPropertiesMenuButton
			// 
			this._editElementPropertiesMenuButton.Image = global::TechTreeEditor.Icons.EditElementSmall;
			this._editElementPropertiesMenuButton.Name = "_editElementPropertiesMenuButton";
			resources.ApplyResources(this._editElementPropertiesMenuButton, "_editElementPropertiesMenuButton");
			this._editElementPropertiesMenuButton.Click += new System.EventHandler(this._editElementPropertiesMenuButton_Click);
			// 
			// _menuSeparator14
			// 
			this._menuSeparator14.Name = "_menuSeparator14";
			resources.ApplyResources(this._menuSeparator14, "_menuSeparator14");
			// 
			// _sortChildrenMenuButton
			// 
			this._sortChildrenMenuButton.Image = global::TechTreeEditor.Icons.SortChildren;
			this._sortChildrenMenuButton.Name = "_sortChildrenMenuButton";
			resources.ApplyResources(this._sortChildrenMenuButton, "_sortChildrenMenuButton");
			this._sortChildrenMenuButton.Click += new System.EventHandler(this._sortChildrenMenuButton_Click);
			// 
			// _showUnitInRendererMenuButton
			// 
			this._showUnitInRendererMenuButton.Image = global::TechTreeEditor.Icons.SetRenderUnit;
			this._showUnitInRendererMenuButton.Name = "_showUnitInRendererMenuButton";
			resources.ApplyResources(this._showUnitInRendererMenuButton, "_showUnitInRendererMenuButton");
			this._showUnitInRendererMenuButton.Click += new System.EventHandler(this._showUnitInRendererMenuButton_Click);
			// 
			// _openProjectDialog
			// 
			resources.ApplyResources(this._openProjectDialog, "_openProjectDialog");
			// 
			// _renderScreenshotDialog
			// 
			resources.ApplyResources(this._renderScreenshotDialog, "_renderScreenshotDialog");
			// 
			// _openBalancingFileDialog
			// 
			resources.ApplyResources(this._openBalancingFileDialog, "_openBalancingFileDialog");
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._menuContainer);
			this.MainMenuStrip = this._mainMenu;
			this.Name = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this._menuContainer.BottomToolStripPanel.ResumeLayout(false);
			this._menuContainer.BottomToolStripPanel.PerformLayout();
			this._menuContainer.ContentPanel.ResumeLayout(false);
			this._menuContainer.LeftToolStripPanel.ResumeLayout(false);
			this._menuContainer.LeftToolStripPanel.PerformLayout();
			this._menuContainer.RightToolStripPanel.ResumeLayout(false);
			this._menuContainer.RightToolStripPanel.PerformLayout();
			this._menuContainer.TopToolStripPanel.ResumeLayout(false);
			this._menuContainer.TopToolStripPanel.PerformLayout();
			this._menuContainer.ResumeLayout(false);
			this._menuContainer.PerformLayout();
			this._statusStrip.ResumeLayout(false);
			this._statusStrip.PerformLayout();
			this._toolBoxBar.ResumeLayout(false);
			this._toolBoxBar.PerformLayout();
			this._mainMenu.ResumeLayout(false);
			this._mainMenu.PerformLayout();
			this._projectToolBar.ResumeLayout(false);
			this._projectToolBar.PerformLayout();
			this._mainToolBar.ResumeLayout(false);
			this._mainToolBar.PerformLayout();
			this._addToolsBar.ResumeLayout(false);
			this._addToolsBar.PerformLayout();
			this._techTreeElementContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer _menuContainer;
		private System.Windows.Forms.MenuStrip _mainMenu;
		private System.Windows.Forms.ToolStripMenuItem _fileMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _exitMenuButton;
		private System.Windows.Forms.StatusStrip _statusStrip;
		private System.Windows.Forms.ToolStrip _mainToolBar;
		private System.Windows.Forms.ToolStripComboBox _civSelectComboBox;
		private System.Windows.Forms.ToolStripStatusLabel _statusLabel;
		private System.Windows.Forms.ContextMenuStrip _techTreeElementContextMenu;
		private System.Windows.Forms.ToolStripMenuItem _standardElementCheckButton;
		private System.Windows.Forms.ToolStripStatusLabel _selectedNameLabel;
		private System.Windows.Forms.ToolStripMenuItem _importDATMenuButton;
		private RenderControl _renderPanel;
		private System.Windows.Forms.ToolStripMenuItem _openProjectMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _saveProjectMenuButton;
		private System.Windows.Forms.OpenFileDialog _openProjectDialog;
		private System.Windows.Forms.ToolStrip _toolBoxBar;
		private System.Windows.Forms.ToolStripMenuItem _editMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _undoMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _redoMenuButton;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator1;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator2;
		private System.Windows.Forms.ToolStrip _projectToolBar;
		private System.Windows.Forms.ToolStripButton _openProjectButton;
		private System.Windows.Forms.ToolStripButton _saveProjectButton;
		private System.Windows.Forms.ToolStripMenuItem _helpMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _infoMenuButton;
		private System.Windows.Forms.ToolStripButton _newBuildingButton;
		private System.Windows.Forms.ToolStripButton _newUnitButton;
		private System.Windows.Forms.ToolStripButton _newResearchButton;
		private System.Windows.Forms.ToolStripButton _newLinkButton;
		private System.Windows.Forms.ToolStripButton _deleteLinkButton;
		private System.Windows.Forms.ToolStripButton _deleteElementButton;
		private System.Windows.Forms.ToolStripButton _editorModeButton;
		private System.Windows.Forms.ToolStripButton _standardModeButton;
		private System.Windows.Forms.ToolStripMenuItem _showInEditorCheckButton;
		private System.Windows.Forms.ToolStripMenuItem _gaiaOnlyCheckButton;
		private System.Windows.Forms.ToolStripMenuItem _lockIDCheckButton;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator3;
		private System.Windows.Forms.ToolStripMenuItem _blockForCivCheckButton;
		private System.Windows.Forms.ToolStripMenuItem _freeForCivCheckButton;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator4;
		private System.Windows.Forms.ToolStrip _addToolsBar;
		private System.Windows.Forms.ToolStripButton _ageUpButton;
		private System.Windows.Forms.ToolStripButton _ageDownButton;
		private System.Windows.Forms.ToolStripButton _newEyeCandyButton;
		private System.Windows.Forms.ToolStripButton _newMakeAvailDepButton;
		private System.Windows.Forms.ToolStripButton _newSuccResDepButton;
		private System.Windows.Forms.ToolStripButton _newBuildingDepButton;
		private System.Windows.Forms.ToolStripButton _deleteDepButton;
		private System.Windows.Forms.ToolStripButton _newProjectileButton;
		private System.Windows.Forms.ToolStripButton _newDeadButton;
		private System.Windows.Forms.ToolStripTextBox _searchTextBox;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator5;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator6;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator7;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator8;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator9;
		private System.Windows.Forms.ToolStripLabel _searchLabel;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator10;
		private System.Windows.Forms.ToolStripMenuItem _editAttributesMenuButton;
		private System.Windows.Forms.ToolStrip _civCopyBar;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator11;
		private System.Windows.Forms.ToolStripButton _editAttributesButton;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator12;
		private System.Windows.Forms.ToolStripButton _editGraphicsButton;
		private System.Windows.Forms.ToolStripMenuItem _editElementPropertiesMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _lockAllIDsMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _exportDATMenuButton;
		private System.Windows.Forms.ToolStripButton _exportDATButton;
		private System.Windows.Forms.ToolStripButton _editElementPropertiesButton;
		private System.Windows.Forms.ToolStripButton _editCivBoniButton;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator13;
		private System.Windows.Forms.ToolStripMenuItem _pasteTreeMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _copyMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _pasteMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _pluginMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _renderScreenshotMenuButton;
		private System.Windows.Forms.SaveFileDialog _renderScreenshotDialog;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator14;
		private System.Windows.Forms.ToolStripMenuItem _sortChildrenMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _projectSettingsMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _viewMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _unitRendererMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _showUnitInRendererMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _newProjectMenuButton;
		private System.Windows.Forms.ToolStripButton _newProjectButton;
		private System.Windows.Forms.ToolStripMenuItem _languageMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _languageGermanMenuButton;
		private System.Windows.Forms.ToolStripMenuItem _languageEnglishMenuButton;
		private System.Windows.Forms.ToolStripButton _setNewTechTreeParentButton;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator15;
		private System.Windows.Forms.ToolStripMenuItem _showInNewTechTreeCheckButton;
		private System.Windows.Forms.ToolStripMenuItem _hideIfDisabledInNewTechTreeCheckButton;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator16;
		private System.Windows.Forms.ToolStripButton _elementLeftButton;
		private System.Windows.Forms.ToolStripButton _elementRightButton;
		private System.Windows.Forms.ToolStripSeparator _menuSeparator17;
		private System.Windows.Forms.ToolStripMenuItem _importBalancingFileMenuButton;
		private System.Windows.Forms.OpenFileDialog _openBalancingFileDialog;
	}
}

