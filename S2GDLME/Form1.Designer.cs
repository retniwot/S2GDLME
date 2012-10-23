namespace S2GDLME
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMapDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMap = new System.Windows.Forms.Label();
            this.picTileSelected = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTiles = new System.Windows.Forms.Panel();
            this.picObjects = new System.Windows.Forms.PictureBox();
            this.picTiles = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.lblSelectedObject = new System.Windows.Forms.Label();
            this.picObjectSelected = new System.Windows.Forms.PictureBox();
            this.lblph = new System.Windows.Forms.Label();
            this.lblObjectID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTileID = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.mapControl = new S2GDLME.MapControl();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileSelected)).BeginInit();
            this.panelTiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1274, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            this.menuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMain_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMapDataToolStripMenuItem,
            this.fillMapToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // viewMapDataToolStripMenuItem
            // 
            this.viewMapDataToolStripMenuItem.Name = "viewMapDataToolStripMenuItem";
            this.viewMapDataToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewMapDataToolStripMenuItem.Text = "View Map Data";
            this.viewMapDataToolStripMenuItem.Click += new System.EventHandler(this.viewMapDataToolStripMenuItem_Click);
            // 
            // fillMapToolStripMenuItem
            // 
            this.fillMapToolStripMenuItem.Name = "fillMapToolStripMenuItem";
            this.fillMapToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fillMapToolStripMenuItem.Text = "Fill Map";
            this.fillMapToolStripMenuItem.Click += new System.EventHandler(this.fillMapToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(-3, 33);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(31, 13);
            this.lblMap.TabIndex = 5;
            this.lblMap.Text = "Map:";
            this.lblMap.Click += new System.EventHandler(this.lblMap_Click);
            // 
            // picTileSelected
            // 
            this.picTileSelected.Location = new System.Drawing.Point(955, 49);
            this.picTileSelected.Name = "picTileSelected";
            this.picTileSelected.Size = new System.Drawing.Size(32, 32);
            this.picTileSelected.TabIndex = 3;
            this.picTileSelected.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(952, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected Tile:";
            // 
            // panelTiles
            // 
            this.panelTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTiles.Controls.Add(this.picObjects);
            this.panelTiles.Controls.Add(this.picTiles);
            this.panelTiles.Controls.Add(this.label2);
            this.panelTiles.Location = new System.Drawing.Point(955, 116);
            this.panelTiles.Name = "panelTiles";
            this.panelTiles.Size = new System.Drawing.Size(309, 555);
            this.panelTiles.TabIndex = 4;
            // 
            // picObjects
            // 
            this.picObjects.Location = new System.Drawing.Point(6, 25);
            this.picObjects.Name = "picObjects";
            this.picObjects.Size = new System.Drawing.Size(298, 555);
            this.picObjects.TabIndex = 9;
            this.picObjects.TabStop = false;
            this.picObjects.Visible = false;
            this.picObjects.Click += new System.EventHandler(this.picObjects_Click);
            // 
            // picTiles
            // 
            this.picTiles.Location = new System.Drawing.Point(6, 25);
            this.picTiles.Name = "picTiles";
            this.picTiles.Size = new System.Drawing.Size(249, 341);
            this.picTiles.TabIndex = 9;
            this.picTiles.TabStop = false;
            this.picTiles.Click += new System.EventHandler(this.picTiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TileSheet:";
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(1183, 70);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(81, 31);
            this.btnToggle.TabIndex = 8;
            this.btnToggle.Text = "Toggle Mode";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // lblSelectedObject
            // 
            this.lblSelectedObject.AutoSize = true;
            this.lblSelectedObject.Location = new System.Drawing.Point(1055, 33);
            this.lblSelectedObject.Name = "lblSelectedObject";
            this.lblSelectedObject.Size = new System.Drawing.Size(86, 13);
            this.lblSelectedObject.TabIndex = 9;
            this.lblSelectedObject.Text = "Selected Object:";
            // 
            // picObjectSelected
            // 
            this.picObjectSelected.Location = new System.Drawing.Point(1058, 49);
            this.picObjectSelected.Name = "picObjectSelected";
            this.picObjectSelected.Size = new System.Drawing.Size(32, 32);
            this.picObjectSelected.TabIndex = 10;
            this.picObjectSelected.TabStop = false;
            // 
            // lblph
            // 
            this.lblph.AutoSize = true;
            this.lblph.Location = new System.Drawing.Point(1096, 58);
            this.lblph.Name = "lblph";
            this.lblph.Size = new System.Drawing.Size(21, 13);
            this.lblph.TabIndex = 11;
            this.lblph.Text = "ID:";
            // 
            // lblObjectID
            // 
            this.lblObjectID.AutoSize = true;
            this.lblObjectID.Location = new System.Drawing.Point(1123, 58);
            this.lblObjectID.Name = "lblObjectID";
            this.lblObjectID.Size = new System.Drawing.Size(0, 13);
            this.lblObjectID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // lblTileID
            // 
            this.lblTileID.AutoSize = true;
            this.lblTileID.Location = new System.Drawing.Point(1020, 58);
            this.lblTileID.Name = "lblTileID";
            this.lblTileID.Size = new System.Drawing.Size(0, 13);
            this.lblTileID.TabIndex = 14;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(857, 24);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(0, 13);
            this.lblMode.TabIndex = 15;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 674);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1274, 22);
            this.statusMain.TabIndex = 16;
            this.statusMain.Text = "qqqqqqqqqq";
            this.statusMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusMain_ItemClicked);
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(12, 532);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(0, 13);
            this.lblStatusText.TabIndex = 17;
            // 
            // mapControl
            // 
            this.mapControl.Location = new System.Drawing.Point(0, 49);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(949, 622);
            this.mapControl.TabIndex = 0;
            this.mapControl.Text = "mapControl";
            this.mapControl.Click += new System.EventHandler(this.mapControl_Click);
            this.mapControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 696);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblTileID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblObjectID);
            this.Controls.Add(this.lblph);
            this.Controls.Add(this.picObjectSelected);
            this.Controls.Add(this.lblSelectedObject);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.panelTiles);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.picTileSelected);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S2DGL Map Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyPress);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileSelected)).EndInit();
            this.panelTiles.ResumeLayout(false);
            this.panelTiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.PictureBox picTileSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.PictureBox picTiles;
        private System.Windows.Forms.PictureBox picObjects;
        private System.Windows.Forms.Label lblSelectedObject;
        private System.Windows.Forms.PictureBox picObjectSelected;
        private System.Windows.Forms.Label lblph;
        private System.Windows.Forms.Label lblObjectID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTileID;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ToolStripMenuItem viewMapDataToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.ToolStripMenuItem fillMapToolStripMenuItem;
    }
}

