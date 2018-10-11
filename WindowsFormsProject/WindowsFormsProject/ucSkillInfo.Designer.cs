namespace WindowsFormsProject
{
    partial class ucSkillInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSkillInfo));
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblSkillInfoOf = new System.Windows.Forms.Label();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbViewProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUrl.Location = new System.Drawing.Point(81, 66);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(25, 16);
            this.lblUrl.TabIndex = 16;
            this.lblUrl.Text = "Url";
            // 
            // lblSkillInfoOf
            // 
            this.lblSkillInfoOf.AutoSize = true;
            this.lblSkillInfoOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillInfoOf.Location = new System.Drawing.Point(81, 18);
            this.lblSkillInfoOf.Name = "lblSkillInfoOf";
            this.lblSkillInfoOf.Size = new System.Drawing.Size(96, 18);
            this.lblSkillInfoOf.TabIndex = 14;
            this.lblSkillInfoOf.Text = "Skill Info Of";
            // 
            // pbEdit
            // 
            this.pbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit.Image = global::WindowsFormsProject.Properties.Resources.edit_11_16;
            this.pbEdit.Location = new System.Drawing.Point(-1, 117);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(16, 16);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEdit.TabIndex = 18;
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
            this.pbDelete.TabIndex = 17;
            this.pbDelete.TabStop = false;
            this.pbDelete.Tag = "0";
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbViewProfile
            // 
            this.pbViewProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbViewProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbViewProfile.Image")));
            this.pbViewProfile.Location = new System.Drawing.Point(-1, 18);
            this.pbViewProfile.Name = "pbViewProfile";
            this.pbViewProfile.Size = new System.Drawing.Size(64, 64);
            this.pbViewProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewProfile.TabIndex = 13;
            this.pbViewProfile.TabStop = false;
            this.pbViewProfile.Tag = "0";
            // 
            // ucSkillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblSkillInfoOf);
            this.Controls.Add(this.pbViewProfile);
            this.Name = "ucSkillInfo";
            this.Size = new System.Drawing.Size(232, 132);
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblSkillInfoOf;
        private System.Windows.Forms.PictureBox pbViewProfile;
    }
}
