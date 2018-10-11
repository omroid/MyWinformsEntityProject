namespace WindowsFormsProject
{
    partial class FullViewSkillsForm
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
            this.lblSkillOf = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBriefDescription = new System.Windows.Forms.Label();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.picWorker = new System.Windows.Forms.PictureBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.cbUrl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkillOf
            // 
            this.lblSkillOf.AutoSize = true;
            this.lblSkillOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillOf.Location = new System.Drawing.Point(209, 57);
            this.lblSkillOf.Name = "lblSkillOf";
            this.lblSkillOf.Size = new System.Drawing.Size(70, 20);
            this.lblSkillOf.TabIndex = 52;
            this.lblSkillOf.Text = "Skill Of : ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.Location = new System.Drawing.Point(238, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 27);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBriefDescription
            // 
            this.lblBriefDescription.AutoSize = true;
            this.lblBriefDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBriefDescription.Location = new System.Drawing.Point(209, 147);
            this.lblBriefDescription.Name = "lblBriefDescription";
            this.lblBriefDescription.Size = new System.Drawing.Size(126, 20);
            this.lblBriefDescription.TabIndex = 46;
            this.lblBriefDescription.Text = "Brief Description";
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillName.Location = new System.Drawing.Point(209, 12);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(91, 20);
            this.lblSkillName.TabIndex = 45;
            this.lblSkillName.Text = "Skill Name: ";
            // 
            // picWorker
            // 
            this.picWorker.Image = global::WindowsFormsProject.Properties.Resources.contact_directory_icon_128;
            this.picWorker.Location = new System.Drawing.Point(12, 12);
            this.picWorker.Name = "picWorker";
            this.picWorker.Size = new System.Drawing.Size(128, 128);
            this.picWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWorker.TabIndex = 44;
            this.picWorker.TabStop = false;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUrl.Location = new System.Drawing.Point(209, 103);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 20);
            this.lblUrl.TabIndex = 53;
            this.lblUrl.Text = "Url";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(213, 170);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(216, 107);
            this.rtbDescription.TabIndex = 54;
            this.rtbDescription.Text = "";
            // 
            // cbUrl
            // 
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(238, 105);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(191, 21);
            this.cbUrl.TabIndex = 55;
            // 
            // FullViewSkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 334);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblSkillOf);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblBriefDescription);
            this.Controls.Add(this.lblSkillName);
            this.Controls.Add(this.picWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullViewSkillsForm";
            this.Text = "FullViewSkillsForm";
            this.Load += new System.EventHandler(this.FullViewSkillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkillOf;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBriefDescription;
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.PictureBox picWorker;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.ComboBox cbUrl;
    }
}