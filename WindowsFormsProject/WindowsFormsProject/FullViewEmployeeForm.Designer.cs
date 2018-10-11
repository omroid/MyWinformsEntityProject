namespace WindowsFormsProject
{
    partial class FullViewEmployeeForm
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.cbSkills = new System.Windows.Forms.ComboBox();
            this.lblSkillInfo = new System.Windows.Forms.Label();
            this.rtbSkillInfo = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.picWorker = new System.Windows.Forms.PictureBox();
            this.lblReferences = new System.Windows.Forms.Label();
            this.cbReferences = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFullName.Location = new System.Drawing.Point(174, 12);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(104, 20);
            this.lblFullName.TabIndex = 35;
            this.lblFullName.Text = "Full Name : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmail.Location = new System.Drawing.Point(174, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 20);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email : ";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAlias.Location = new System.Drawing.Point(174, 40);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(59, 20);
            this.lblAlias.TabIndex = 33;
            this.lblAlias.Text = "Alias :  ";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkills.Location = new System.Drawing.Point(172, 139);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(45, 20);
            this.lblSkills.TabIndex = 36;
            this.lblSkills.Text = "Skills";
            // 
            // cbSkills
            // 
            this.cbSkills.FormattingEnabled = true;
            this.cbSkills.Location = new System.Drawing.Point(223, 138);
            this.cbSkills.Name = "cbSkills";
            this.cbSkills.Size = new System.Drawing.Size(269, 21);
            this.cbSkills.TabIndex = 39;
            this.cbSkills.Text = "Choose Skill...";
            this.cbSkills.SelectedIndexChanged += new System.EventHandler(this.cbSkills_SelectedIndexChanged);
            // 
            // lblSkillInfo
            // 
            this.lblSkillInfo.AutoSize = true;
            this.lblSkillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillInfo.Location = new System.Drawing.Point(111, 169);
            this.lblSkillInfo.Name = "lblSkillInfo";
            this.lblSkillInfo.Size = new System.Drawing.Size(67, 20);
            this.lblSkillInfo.TabIndex = 38;
            this.lblSkillInfo.Text = "Skill info";
            // 
            // rtbSkillInfo
            // 
            this.rtbSkillInfo.Location = new System.Drawing.Point(178, 172);
            this.rtbSkillInfo.Name = "rtbSkillInfo";
            this.rtbSkillInfo.ReadOnly = true;
            this.rtbSkillInfo.Size = new System.Drawing.Size(316, 116);
            this.rtbSkillInfo.TabIndex = 37;
            this.rtbSkillInfo.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(275, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picWorker
            // 
            this.picWorker.Image = global::WindowsFormsProject.Properties.Resources.user;
            this.picWorker.Location = new System.Drawing.Point(12, 12);
            this.picWorker.Name = "picWorker";
            this.picWorker.Size = new System.Drawing.Size(128, 115);
            this.picWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWorker.TabIndex = 32;
            this.picWorker.TabStop = false;
            // 
            // lblReferences
            // 
            this.lblReferences.AutoSize = true;
            this.lblReferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblReferences.Location = new System.Drawing.Point(174, 107);
            this.lblReferences.Name = "lblReferences";
            this.lblReferences.Size = new System.Drawing.Size(92, 20);
            this.lblReferences.TabIndex = 41;
            this.lblReferences.Text = "References";
            // 
            // cbReferences
            // 
            this.cbReferences.FormattingEnabled = true;
            this.cbReferences.Location = new System.Drawing.Point(272, 109);
            this.cbReferences.Name = "cbReferences";
            this.cbReferences.Size = new System.Drawing.Size(220, 21);
            this.cbReferences.TabIndex = 42;
            this.cbReferences.Text = "Choose Reference...";
            // 
            // FullViewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 321);
            this.Controls.Add(this.cbReferences);
            this.Controls.Add(this.lblReferences);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbSkills);
            this.Controls.Add(this.lblSkillInfo);
            this.Controls.Add(this.rtbSkillInfo);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.picWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullViewEmployeeForm";
            this.Text = "FullViewForm";
            this.Load += new System.EventHandler(this.FullViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.PictureBox picWorker;
        private System.Windows.Forms.ComboBox cbSkills;
        private System.Windows.Forms.Label lblSkillInfo;
        private System.Windows.Forms.RichTextBox rtbSkillInfo;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbReferences;
        private System.Windows.Forms.Label lblReferences;
    }
}