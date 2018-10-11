namespace WindowsFormsProject
{
    partial class AddOrEditSkillInfoForm
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
            this.lblSkillInfoOf = new System.Windows.Forms.Label();
            this.cbSkillInfoOf = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.picWorker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkillInfoOf
            // 
            this.lblSkillInfoOf.AutoSize = true;
            this.lblSkillInfoOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillInfoOf.Location = new System.Drawing.Point(209, 16);
            this.lblSkillInfoOf.Name = "lblSkillInfoOf";
            this.lblSkillInfoOf.Size = new System.Drawing.Size(88, 20);
            this.lblSkillInfoOf.TabIndex = 43;
            this.lblSkillInfoOf.Text = "Skill info Of";
            // 
            // cbSkillInfoOf
            // 
            this.cbSkillInfoOf.FormattingEnabled = true;
            this.cbSkillInfoOf.Location = new System.Drawing.Point(212, 42);
            this.cbSkillInfoOf.Name = "cbSkillInfoOf";
            this.cbSkillInfoOf.Size = new System.Drawing.Size(186, 21);
            this.cbSkillInfoOf.TabIndex = 42;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancle.Location = new System.Drawing.Point(311, 155);
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
            this.btnSubmit.Location = new System.Drawing.Point(214, 155);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 27);
            this.btnSubmit.TabIndex = 39;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(213, 103);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(186, 20);
            this.txtUrl.TabIndex = 45;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUrl.Location = new System.Drawing.Point(209, 80);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 20);
            this.lblUrl.TabIndex = 44;
            this.lblUrl.Text = "Url";
            // 
            // picWorker
            // 
            this.picWorker.Image = global::WindowsFormsProject.Properties.Resources.contact_directory_icon_128;
            this.picWorker.Location = new System.Drawing.Point(12, 12);
            this.picWorker.Name = "picWorker";
            this.picWorker.Size = new System.Drawing.Size(147, 137);
            this.picWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWorker.TabIndex = 35;
            this.picWorker.TabStop = false;
            // 
            // AddOrEditSkillInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 207);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblSkillInfoOf);
            this.Controls.Add(this.cbSkillInfoOf);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.picWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrEditSkillInfoForm";
            this.Text = "AddOrEditSkillInfoForm";
            this.Load += new System.EventHandler(this.AddOrEditSkillInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkillInfoOf;
        private System.Windows.Forms.ComboBox cbSkillInfoOf;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox picWorker;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
    }
}