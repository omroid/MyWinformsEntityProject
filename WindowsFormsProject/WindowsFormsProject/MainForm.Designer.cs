namespace WindowsFormsProject
{
    partial class mainForm
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
            System.Windows.Forms.Panel panelTable;
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.ucSkillsTableLayer = new WindowsFormsProject.ucSkillsTable();
            this.ucSkillInfoTableLayer = new WindowsFormsProject.ucSkillInfoTable();
            this.ucReferenceTableLayer = new WindowsFormsProject.ucReferenceTable();
            this.ucEmployeesTableLayer = new WindowsFormsProject.ucEmployeesTable();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pbButtonTooBar = new System.Windows.Forms.PictureBox();
            this.lblButtonToolBar = new System.Windows.Forms.Label();
            this.btnTbl14 = new System.Windows.Forms.Button();
            this.btnTbl3 = new System.Windows.Forms.Button();
            this.btnTbl2 = new System.Windows.Forms.Button();
            this.btnTbl1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTopPanel = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btEffectShow = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btEffectClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            panelTable = new System.Windows.Forms.Panel();
            panelTable.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbButtonTooBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            panelTable.BackColor = System.Drawing.Color.Gainsboro;
            panelTable.Controls.Add(this.ucSkillsTableLayer);
            panelTable.Controls.Add(this.ucSkillInfoTableLayer);
            panelTable.Controls.Add(this.ucReferenceTableLayer);
            panelTable.Controls.Add(this.ucEmployeesTableLayer);
            this.btEffectClose.SetDecoration(panelTable, BunifuAnimatorNS.DecorationType.None);
            this.btEffectShow.SetDecoration(panelTable, BunifuAnimatorNS.DecorationType.None);
            panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            panelTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            panelTable.Location = new System.Drawing.Point(192, 0);
            panelTable.Name = "panelTable";
            panelTable.Size = new System.Drawing.Size(756, 401);
            panelTable.TabIndex = 2;
            // 
            // ucSkillsTableLayer
            // 
            this.btEffectShow.SetDecoration(this.ucSkillsTableLayer, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.ucSkillsTableLayer, BunifuAnimatorNS.DecorationType.None);
            this.ucSkillsTableLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucSkillsTableLayer.Location = new System.Drawing.Point(0, -1075);
            this.ucSkillsTableLayer.Name = "ucSkillsTableLayer";
            this.ucSkillsTableLayer.Size = new System.Drawing.Size(756, 369);
            this.ucSkillsTableLayer.TabIndex = 3;
            this.ucSkillsTableLayer.Visible = false;
            // 
            // ucSkillInfoTableLayer
            // 
            this.btEffectShow.SetDecoration(this.ucSkillInfoTableLayer, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.ucSkillInfoTableLayer, BunifuAnimatorNS.DecorationType.None);
            this.ucSkillInfoTableLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucSkillInfoTableLayer.Location = new System.Drawing.Point(0, -706);
            this.ucSkillInfoTableLayer.Name = "ucSkillInfoTableLayer";
            this.ucSkillInfoTableLayer.Size = new System.Drawing.Size(756, 369);
            this.ucSkillInfoTableLayer.TabIndex = 2;
            this.ucSkillInfoTableLayer.Visible = false;
            // 
            // ucReferenceTableLayer
            // 
            this.btEffectShow.SetDecoration(this.ucReferenceTableLayer, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.ucReferenceTableLayer, BunifuAnimatorNS.DecorationType.None);
            this.ucReferenceTableLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucReferenceTableLayer.Location = new System.Drawing.Point(0, -337);
            this.ucReferenceTableLayer.Name = "ucReferenceTableLayer";
            this.ucReferenceTableLayer.Size = new System.Drawing.Size(756, 369);
            this.ucReferenceTableLayer.TabIndex = 1;
            this.ucReferenceTableLayer.Visible = false;
            // 
            // ucEmployeesTableLayer
            // 
            this.btEffectShow.SetDecoration(this.ucEmployeesTableLayer, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.ucEmployeesTableLayer, BunifuAnimatorNS.DecorationType.None);
            this.ucEmployeesTableLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucEmployeesTableLayer.Location = new System.Drawing.Point(0, 32);
            this.ucEmployeesTableLayer.Name = "ucEmployeesTableLayer";
            this.ucEmployeesTableLayer.Size = new System.Drawing.Size(756, 369);
            this.ucEmployeesTableLayer.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidePanel.Controls.Add(this.pbButtonTooBar);
            this.sidePanel.Controls.Add(this.lblButtonToolBar);
            this.sidePanel.Controls.Add(this.btnTbl14);
            this.sidePanel.Controls.Add(this.btnTbl3);
            this.sidePanel.Controls.Add(this.btnTbl2);
            this.sidePanel.Controls.Add(this.btnTbl1);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.btEffectClose.SetDecoration(this.sidePanel, BunifuAnimatorNS.DecorationType.None);
            this.btEffectShow.SetDecoration(this.sidePanel, BunifuAnimatorNS.DecorationType.None);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(192, 401);
            this.sidePanel.TabIndex = 0;
            // 
            // pbButtonTooBar
            // 
            this.pbButtonTooBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(146)))), ((int)(((byte)(49)))));
            this.btEffectShow.SetDecoration(this.pbButtonTooBar, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.pbButtonTooBar, BunifuAnimatorNS.DecorationType.None);
            this.pbButtonTooBar.Image = global::WindowsFormsProject.Properties.Resources.db_Server;
            this.pbButtonTooBar.Location = new System.Drawing.Point(3, 3);
            this.pbButtonTooBar.Name = "pbButtonTooBar";
            this.pbButtonTooBar.Size = new System.Drawing.Size(39, 37);
            this.pbButtonTooBar.TabIndex = 12;
            this.pbButtonTooBar.TabStop = false;
            // 
            // lblButtonToolBar
            // 
            this.lblButtonToolBar.AutoSize = true;
            this.lblButtonToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(146)))), ((int)(((byte)(49)))));
            this.btEffectShow.SetDecoration(this.lblButtonToolBar, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.lblButtonToolBar, BunifuAnimatorNS.DecorationType.None);
            this.lblButtonToolBar.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtonToolBar.ForeColor = System.Drawing.Color.White;
            this.lblButtonToolBar.Location = new System.Drawing.Point(40, 9);
            this.lblButtonToolBar.Name = "lblButtonToolBar";
            this.lblButtonToolBar.Size = new System.Drawing.Size(148, 23);
            this.lblButtonToolBar.TabIndex = 0;
            this.lblButtonToolBar.Text = "My SQL Tables";
            // 
            // btnTbl14
            // 
            this.btEffectShow.SetDecoration(this.btnTbl14, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.btnTbl14, BunifuAnimatorNS.DecorationType.None);
            this.btnTbl14.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTbl14.FlatAppearance.BorderSize = 0;
            this.btnTbl14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTbl14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTbl14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTbl14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTbl14.ForeColor = System.Drawing.Color.White;
            this.btnTbl14.Location = new System.Drawing.Point(0, 196);
            this.btnTbl14.Name = "btnTbl14";
            this.btnTbl14.Size = new System.Drawing.Size(192, 50);
            this.btnTbl14.TabIndex = 11;
            this.btnTbl14.Tag = "3";
            this.btnTbl14.Text = "Skill Info";
            this.btnTbl14.UseVisualStyleBackColor = true;
            this.btnTbl14.Click += new System.EventHandler(this.ChangePanel);
            // 
            // btnTbl3
            // 
            this.btEffectShow.SetDecoration(this.btnTbl3, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.btnTbl3, BunifuAnimatorNS.DecorationType.None);
            this.btnTbl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTbl3.FlatAppearance.BorderSize = 0;
            this.btnTbl3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTbl3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTbl3.ForeColor = System.Drawing.Color.White;
            this.btnTbl3.Location = new System.Drawing.Point(0, 146);
            this.btnTbl3.Name = "btnTbl3";
            this.btnTbl3.Size = new System.Drawing.Size(192, 50);
            this.btnTbl3.TabIndex = 10;
            this.btnTbl3.Tag = "2";
            this.btnTbl3.Text = "Skills";
            this.btnTbl3.UseVisualStyleBackColor = true;
            this.btnTbl3.Click += new System.EventHandler(this.ChangePanel);
            // 
            // btnTbl2
            // 
            this.btEffectShow.SetDecoration(this.btnTbl2, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.btnTbl2, BunifuAnimatorNS.DecorationType.None);
            this.btnTbl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTbl2.FlatAppearance.BorderSize = 0;
            this.btnTbl2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTbl2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTbl2.ForeColor = System.Drawing.Color.White;
            this.btnTbl2.Location = new System.Drawing.Point(0, 96);
            this.btnTbl2.Name = "btnTbl2";
            this.btnTbl2.Size = new System.Drawing.Size(192, 50);
            this.btnTbl2.TabIndex = 9;
            this.btnTbl2.Tag = "1";
            this.btnTbl2.Text = "Reference";
            this.btnTbl2.UseVisualStyleBackColor = true;
            this.btnTbl2.Click += new System.EventHandler(this.ChangePanel);
            // 
            // btnTbl1
            // 
            this.btnTbl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btEffectShow.SetDecoration(this.btnTbl1, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.btnTbl1, BunifuAnimatorNS.DecorationType.None);
            this.btnTbl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTbl1.FlatAppearance.BorderSize = 0;
            this.btnTbl1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTbl1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTbl1.ForeColor = System.Drawing.Color.White;
            this.btnTbl1.Location = new System.Drawing.Point(0, 46);
            this.btnTbl1.Name = "btnTbl1";
            this.btnTbl1.Size = new System.Drawing.Size(192, 50);
            this.btnTbl1.TabIndex = 8;
            this.btnTbl1.Tag = "0";
            this.btnTbl1.Text = "Employees";
            this.btnTbl1.UseVisualStyleBackColor = true;
            this.btnTbl1.Click += new System.EventHandler(this.ChangePanel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(146)))), ((int)(((byte)(49)))));
            this.btEffectShow.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 46);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnMini);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblTopPanel);
            this.btEffectClose.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.btEffectShow.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlTop.Location = new System.Drawing.Point(192, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(756, 32);
            this.pnlTop.TabIndex = 3;
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.White;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btEffectShow.SetDecoration(this.btnMini, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.btnMini, BunifuAnimatorNS.DecorationType.None);
            this.btnMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.Black;
            this.btnMini.Location = new System.Drawing.Point(716, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(20, 32);
            this.btnMini.TabIndex = 14;
            this.btnMini.Text = "_";
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btEffectShow.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(736, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 32);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblTopPanel
            // 
            this.lblTopPanel.AutoSize = true;
            this.lblTopPanel.BackColor = System.Drawing.Color.White;
            this.btEffectShow.SetDecoration(this.lblTopPanel, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this.lblTopPanel, BunifuAnimatorNS.DecorationType.None);
            this.lblTopPanel.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPanel.ForeColor = System.Drawing.Color.Black;
            this.lblTopPanel.Location = new System.Drawing.Point(267, 3);
            this.lblTopPanel.Name = "lblTopPanel";
            this.lblTopPanel.Size = new System.Drawing.Size(150, 18);
            this.lblTopPanel.TabIndex = 13;
            this.lblTopPanel.Text = "My Winform Project";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btEffectShow
            // 
            this.btEffectShow.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.btEffectShow.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.btEffectShow.DefaultAnimation = animation3;
            // 
            // btEffectClose
            // 
            this.btEffectClose.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.btEffectClose.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.btEffectClose.DefaultAnimation = animation4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 401);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(panelTable);
            this.Controls.Add(this.sidePanel);
            this.btEffectShow.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.btEffectClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            panelTable.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbButtonTooBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnTbl14;
        private System.Windows.Forms.Button btnTbl3;
        private System.Windows.Forms.Button btnTbl2;
        private System.Windows.Forms.Button btnTbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbButtonTooBar;
        private System.Windows.Forms.Label lblButtonToolBar;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTopPanel;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ucEmployeesTable ucEmployeesTableLayer;
        private ucReferenceTable ucReferenceTableLayer;
        private ucSkillsTable ucSkillsTableLayer;
        private ucSkillInfoTable ucSkillInfoTableLayer;
        private BunifuAnimatorNS.BunifuTransition btEffectShow;
        private BunifuAnimatorNS.BunifuTransition btEffectClose;
    }
}

