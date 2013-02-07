﻿namespace Chocolatey.Explorer.View
{
    partial class PackageManager
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.packagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availablePackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installedPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.PackageGrid = new System.Windows.Forms.DataGridView();
            this.IsInstalled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstalledVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageTabControl = new System.Windows.Forms.TabControl();
            this.tabAvailable = new System.Windows.Forms.TabPage();
            this.tabInstalled = new System.Windows.Forms.TabPage();
            this.packageTabsImageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInstallUninstall = new System.Windows.Forms.CheckBox();
            this.installUninstallImageList = new System.Windows.Forms.ImageList(this.components);
            this.txtPowershellOutput = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblProgressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.packageVersionPanel = new Chocolatey.Explorer.View.PackageVersionPanel();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PackageGrid)).BeginInit();
            this.packageTabControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packagesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1021, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // packagesToolStripMenuItem
            // 
            this.packagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availablePackagesToolStripMenuItem,
            this.installedPackagesToolStripMenuItem});
            this.packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            this.packagesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.packagesToolStripMenuItem.Text = "&Packages";
            // 
            // availablePackagesToolStripMenuItem
            // 
            this.availablePackagesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("availablePackagesToolStripMenuItem.Image")));
            this.availablePackagesToolStripMenuItem.Name = "availablePackagesToolStripMenuItem";
            this.availablePackagesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.availablePackagesToolStripMenuItem.Text = "&Available packages";
            this.availablePackagesToolStripMenuItem.Click += new System.EventHandler(this.availablePackages_Click);
            // 
            // installedPackagesToolStripMenuItem
            // 
            this.installedPackagesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("installedPackagesToolStripMenuItem.Image")));
            this.installedPackagesToolStripMenuItem.Name = "installedPackagesToolStripMenuItem";
            this.installedPackagesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.installedPackagesToolStripMenuItem.Text = "&Installed packages";
            this.installedPackagesToolStripMenuItem.Click += new System.EventHandler(this.installedPackages_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.helpToolStripMenuItem1.Text = "H&elp";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.help_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settings_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.PackageGrid);
            this.mainSplitContainer.Panel1.Controls.Add(this.packageTabControl);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.packageVersionPanel);
            this.mainSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.mainSplitContainer.Panel2.Controls.Add(this.txtPowershellOutput);
            this.mainSplitContainer.Size = new System.Drawing.Size(1021, 449);
            this.mainSplitContainer.SplitterDistance = 387;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // PackageGrid
            // 
            this.PackageGrid.AllowUserToAddRows = false;
            this.PackageGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PackageGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PackageGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PackageGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PackageGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PackageGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PackageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackageGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsInstalled,
            this.Column1,
            this.InstalledVersion});
            this.PackageGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PackageGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PackageGrid.GridColor = System.Drawing.SystemColors.Control;
            this.PackageGrid.Location = new System.Drawing.Point(0, 25);
            this.PackageGrid.MultiSelect = false;
            this.PackageGrid.Name = "PackageGrid";
            this.PackageGrid.ReadOnly = true;
            this.PackageGrid.RowHeadersVisible = false;
            this.PackageGrid.RowTemplate.ReadOnly = true;
            this.PackageGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PackageGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PackageGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PackageGrid.ShowCellErrors = false;
            this.PackageGrid.ShowCellToolTips = false;
            this.PackageGrid.ShowEditingIcon = false;
            this.PackageGrid.ShowRowErrors = false;
            this.PackageGrid.Size = new System.Drawing.Size(387, 424);
            this.PackageGrid.TabIndex = 2;
            this.PackageGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PackageGrid_CellContentClick);
            this.PackageGrid.SelectionChanged += new System.EventHandler(this.PackageGrid_SelectionChanged);
            this.PackageGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PackageGrid_KeyPress);
            // 
            // IsInstalled
            // 
            this.IsInstalled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IsInstalled.DataPropertyName = "IsInstalled";
            this.IsInstalled.HeaderText = "Installed";
            this.IsInstalled.Name = "IsInstalled";
            this.IsInstalled.ReadOnly = true;
            this.IsInstalled.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsInstalled.Width = 64;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InstalledVersion
            // 
            this.InstalledVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InstalledVersion.DataPropertyName = "InstalledVersion";
            dataGridViewCellStyle4.NullValue = "no version";
            this.InstalledVersion.DefaultCellStyle = dataGridViewCellStyle4;
            this.InstalledVersion.HeaderText = "Installed Version";
            this.InstalledVersion.Name = "InstalledVersion";
            this.InstalledVersion.ReadOnly = true;
            this.InstalledVersion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InstalledVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InstalledVersion.Width = 102;
            // 
            // packageTabControl
            // 
            this.packageTabControl.Controls.Add(this.tabAvailable);
            this.packageTabControl.Controls.Add(this.tabInstalled);
            this.packageTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.packageTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageTabControl.ImageList = this.packageTabsImageList;
            this.packageTabControl.Location = new System.Drawing.Point(0, 0);
            this.packageTabControl.Name = "packageTabControl";
            this.packageTabControl.SelectedIndex = 0;
            this.packageTabControl.Size = new System.Drawing.Size(387, 25);
            this.packageTabControl.TabIndex = 1;
            this.packageTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.packageTabControl_Selected);
            // 
            // tabAvailable
            // 
            this.tabAvailable.ImageIndex = 0;
            this.tabAvailable.Location = new System.Drawing.Point(4, 25);
            this.tabAvailable.Name = "tabAvailable";
            this.tabAvailable.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailable.Size = new System.Drawing.Size(379, 0);
            this.tabAvailable.TabIndex = 1;
            this.tabAvailable.Text = "Available packages";
            this.tabAvailable.UseVisualStyleBackColor = true;
            // 
            // tabInstalled
            // 
            this.tabInstalled.ImageIndex = 1;
            this.tabInstalled.Location = new System.Drawing.Point(4, 25);
            this.tabInstalled.Name = "tabInstalled";
            this.tabInstalled.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstalled.Size = new System.Drawing.Size(379, 0);
            this.tabInstalled.TabIndex = 0;
            this.tabInstalled.Text = "Installed packages";
            this.tabInstalled.UseVisualStyleBackColor = true;
            // 
            // packageTabsImageList
            // 
            this.packageTabsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("packageTabsImageList.ImageStream")));
            this.packageTabsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.packageTabsImageList.Images.SetKeyName(0, "chocolateyicon.ico");
            this.packageTabsImageList.Images.SetKeyName(1, "monitor.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInstallUninstall, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 62);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(309, 56);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // btnInstallUninstall
            // 
            this.btnInstallUninstall.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnInstallUninstall.AutoCheck = false;
            this.btnInstallUninstall.AutoSize = true;
            this.btnInstallUninstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstallUninstall.ImageIndex = 0;
            this.btnInstallUninstall.ImageList = this.installUninstallImageList;
            this.btnInstallUninstall.Location = new System.Drawing.Point(318, 3);
            this.btnInstallUninstall.Name = "btnInstallUninstall";
            this.btnInstallUninstall.Size = new System.Drawing.Size(309, 56);
            this.btnInstallUninstall.TabIndex = 2;
            this.btnInstallUninstall.Text = "Install";
            this.btnInstallUninstall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInstallUninstall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInstallUninstall.UseVisualStyleBackColor = true;
            this.btnInstallUninstall.CheckStateChanged += new System.EventHandler(this.btnInstallUninstall_CheckStateChanged);
            this.btnInstallUninstall.Click += new System.EventHandler(this.buttonInstallUninstall_Click);
            // 
            // installUninstallImageList
            // 
            this.installUninstallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("installUninstallImageList.ImageStream")));
            this.installUninstallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.installUninstallImageList.Images.SetKeyName(0, "add.png");
            this.installUninstallImageList.Images.SetKeyName(1, "delete.png");
            // 
            // txtPowershellOutput
            // 
            this.txtPowershellOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPowershellOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPowershellOutput.Location = new System.Drawing.Point(0, 141);
            this.txtPowershellOutput.Multiline = true;
            this.txtPowershellOutput.Name = "txtPowershellOutput";
            this.txtPowershellOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPowershellOutput.Size = new System.Drawing.Size(630, 308);
            this.txtPowershellOutput.TabIndex = 3;
            this.txtPowershellOutput.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProgressbar,
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 473);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblProgressbar
            // 
            this.lblProgressbar.Name = "lblProgressbar";
            this.lblProgressbar.Size = new System.Drawing.Size(200, 16);
            this.lblProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(804, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // packageVersionPanel
            // 
            this.packageVersionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageVersionPanel.Location = new System.Drawing.Point(0, 0);
            this.packageVersionPanel.Name = "packageVersionPanel";
            this.packageVersionPanel.Size = new System.Drawing.Size(630, 79);
            this.packageVersionPanel.TabIndex = 6;
            // 
            // PackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 495);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "PackageManager";
            this.Text = "Chocolatey PackageManager";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PackageGrid)).EndInit();
            this.packageTabControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem packagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availablePackagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installedPackagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPowershellOutput;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar lblProgressbar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl packageTabControl;
        private System.Windows.Forms.TabPage tabInstalled;
        private System.Windows.Forms.TabPage tabAvailable;
        private System.Windows.Forms.CheckBox btnInstallUninstall;
        private System.Windows.Forms.ImageList installUninstallImageList;
        private System.Windows.Forms.ImageList packageTabsImageList;
        private PackageVersionPanel packageVersionPanel;
        private System.Windows.Forms.DataGridView PackageGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsInstalled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstalledVersion;
    }
}