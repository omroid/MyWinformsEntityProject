namespace WindowsFormsProject
{
    partial class ucReferance
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbViewProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmail.Location = new System.Drawing.Point(81, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(118, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email@gmail.com";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAlias.Location = new System.Drawing.Point(80, 69);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(43, 20);
            this.lblAlias.TabIndex = 9;
            this.lblAlias.Text = "Alias";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFullName.Location = new System.Drawing.Point(81, 18);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(133, 18);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Name LastName";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPosition.Location = new System.Drawing.Point(80, 42);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 20);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "Position";
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
            this.pbViewProfile.Image = global::WindowsFormsProject.Properties.Resources.man1;
            this.pbViewProfile.Location = new System.Drawing.Point(-1, 18);
            this.pbViewProfile.Name = "pbViewProfile";
            this.pbViewProfile.Size = new System.Drawing.Size(64, 64);
            this.pbViewProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewProfile.TabIndex = 7;
            this.pbViewProfile.TabStop = false;
            this.pbViewProfile.Tag = "0";
            this.pbViewProfile.Click += new System.EventHandler(this.pbViewProfile_Click);
            // 
            // ucReferance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pbViewProfile);
            this.Name = "ucReferance";
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.PictureBox pbViewProfile;
        private System.Windows.Forms.Label lblPosition;
    }
}
