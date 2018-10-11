namespace WindowsFormsProject
{
    partial class ucSkills
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSkills));
            this.lblSkillOf = new System.Windows.Forms.Label();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.lblBriefDescription = new System.Windows.Forms.Label();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbViewProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkillOf
            // 
            this.lblSkillOf.AutoSize = true;
            this.lblSkillOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillOf.Location = new System.Drawing.Point(80, 55);
            this.lblSkillOf.Name = "lblSkillOf";
            this.lblSkillOf.Size = new System.Drawing.Size(58, 20);
            this.lblSkillOf.TabIndex = 9;
            this.lblSkillOf.Text = "Skill Of";
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillName.Location = new System.Drawing.Point(81, 18);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(89, 18);
            this.lblSkillName.TabIndex = 8;
            this.lblSkillName.Text = "Skill Name";
            // 
            // lblBriefDescription
            // 
            this.lblBriefDescription.AutoSize = true;
            this.lblBriefDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBriefDescription.Location = new System.Drawing.Point(81, 95);
            this.lblBriefDescription.Name = "lblBriefDescription";
            this.lblBriefDescription.Size = new System.Drawing.Size(106, 16);
            this.lblBriefDescription.TabIndex = 10;
            this.lblBriefDescription.Text = "BriefDescription:";
            // 
            // pbEdit
            // 
            this.pbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit.Image = global::WindowsFormsProject.Properties.Resources.edit_11_16;
            this.pbEdit.Location = new System.Drawing.Point(-1, 117);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(16, 16);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEdit.TabIndex = 12;
            this.pbEdit.TabStop = false;
            this.pbEdit.Tag = "0";
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDelete.Image = global::WindowsFormsProject.Properties.Resources.delete_remove_icon_16;
            this.pbDelete.Location = new System.Drawing.Point(217, -1);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(16, 16);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDelete.TabIndex = 11;
            this.pbDelete.TabStop = false;
            this.pbDelete.Tag = "0";
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbViewProfile
            // 
            this.pbViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbViewProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbViewProfile.Image")));
            this.pbViewProfile.Location = new System.Drawing.Point(-1, 18);
            this.pbViewProfile.Name = "pbViewProfile";
            this.pbViewProfile.Size = new System.Drawing.Size(64, 64);
            this.pbViewProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewProfile.TabIndex = 7;
            this.pbViewProfile.TabStop = false;
            this.pbViewProfile.Tag = "0";
            this.pbViewProfile.Click += new System.EventHandler(this.pbViewProfile_Click);
            // 
            // ucSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.lblBriefDescription);
            this.Controls.Add(this.lblSkillOf);
            this.Controls.Add(this.lblSkillName);
            this.Controls.Add(this.pbViewProfile);
            this.Name = "ucSkills";
            this.Size = new System.Drawing.Size(232, 132);
            this.Load += new System.EventHandler(this.ucSkills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.Label lblSkillOf;
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.PictureBox pbViewProfile;
        private System.Windows.Forms.Label lblBriefDescription;
    }
}
