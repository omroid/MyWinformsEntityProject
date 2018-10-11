namespace WindowsFormsProject
{
    partial class AddOrEditSkillForm
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
            this.cbSkillOf = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.lblBriefDescription = new System.Windows.Forms.Label();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.picSkill = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkillOf
            // 
            this.lblSkillOf.AutoSize = true;
            this.lblSkillOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillOf.Location = new System.Drawing.Point(213, 55);
            this.lblSkillOf.Name = "lblSkillOf";
            this.lblSkillOf.Size = new System.Drawing.Size(58, 20);
            this.lblSkillOf.TabIndex = 43;
            this.lblSkillOf.Text = "Skill Of";
            // 
            // cbSkillOf
            // 
            this.cbSkillOf.FormattingEnabled = true;
            this.cbSkillOf.Location = new System.Drawing.Point(216, 81);
            this.cbSkillOf.Name = "cbSkillOf";
            this.cbSkillOf.Size = new System.Drawing.Size(186, 21);
            this.cbSkillOf.TabIndex = 42;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(216, 149);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(198, 93);
            this.rtbDescription.TabIndex = 41;
            this.rtbDescription.Text = "";
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancle.Location = new System.Drawing.Point(314, 248);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(76, 27);
            this.btnCancle.TabIndex = 40;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSubmit.Location = new System.Drawing.Point(217, 248);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 27);
            this.btnSubmit.TabIndex = 39;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSkillName
            // 
            this.txtSkillName.Location = new System.Drawing.Point(216, 32);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(186, 20);
            this.txtSkillName.TabIndex = 38;
            // 
            // lblBriefDescription
            // 
            this.lblBriefDescription.AutoSize = true;
            this.lblBriefDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBriefDescription.Location = new System.Drawing.Point(212, 126);
            this.lblBriefDescription.Name = "lblBriefDescription";
            this.lblBriefDescription.Size = new System.Drawing.Size(126, 20);
            this.lblBriefDescription.TabIndex = 37;
            this.lblBriefDescription.Text = "Brief Description";
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillName.Location = new System.Drawing.Point(212, 9);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(83, 20);
            this.lblSkillName.TabIndex = 36;
            this.lblSkillName.Text = "Skill Name";
            // 
            // picSkill
            // 
            this.picSkill.Image = global::WindowsFormsProject.Properties.Resources.contact_directory_icon_128;
            this.picSkill.Location = new System.Drawing.Point(16, 4);
            this.picSkill.Name = "picSkill";
            this.picSkill.Size = new System.Drawing.Size(147, 137);
            this.picSkill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSkill.TabIndex = 35;
            this.picSkill.TabStop = false;
            // 
            // AddOrEditSkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 278);
            this.Controls.Add(this.lblSkillOf);
            this.Controls.Add(this.cbSkillOf);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSkillName);
            this.Controls.Add(this.lblBriefDescription);
            this.Controls.Add(this.lblSkillName);
            this.Controls.Add(this.picSkill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrEditSkillForm";
            this.Text = "AddOrEditSkillForm";
            this.Load += new System.EventHandler(this.AddOrEditSkillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSkill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkillOf;
        private System.Windows.Forms.ComboBox cbSkillOf;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.Label lblBriefDescription;
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.PictureBox picSkill;
    }
}