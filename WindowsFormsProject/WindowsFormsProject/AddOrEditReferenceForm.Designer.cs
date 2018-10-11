namespace WindowsFormsProject
{
    partial class AddOrEditReferenceForm
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblRecommandOf = new System.Windows.Forms.Label();
            this.cbRecommand = new System.Windows.Forms.ComboBox();
            this.picWorker = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancle.Location = new System.Drawing.Point(322, 301);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(76, 27);
            this.btnCancle.TabIndex = 42;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSubmit.Location = new System.Drawing.Point(212, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 27);
            this.btnSubmit.TabIndex = 41;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(212, 79);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(186, 20);
            this.txtLastName.TabIndex = 40;
            // 
            // txtFistName
            // 
            this.txtFistName.Location = new System.Drawing.Point(212, 30);
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.Size = new System.Drawing.Size(186, 20);
            this.txtFistName.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(212, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 38;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(212, 124);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(186, 20);
            this.txtAlias.TabIndex = 37;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLastName.Location = new System.Drawing.Point(208, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 36;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFirstName.Location = new System.Drawing.Point(208, 7);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 35;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmail.Location = new System.Drawing.Point(208, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAlias.Location = new System.Drawing.Point(208, 102);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(43, 20);
            this.lblAlias.TabIndex = 33;
            this.lblAlias.Text = "Alias";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(212, 215);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(186, 20);
            this.txtPosition.TabIndex = 44;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPosition.Location = new System.Drawing.Point(210, 192);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 20);
            this.lblPosition.TabIndex = 43;
            this.lblPosition.Text = "Position";
            // 
            // lblRecommandOf
            // 
            this.lblRecommandOf.AutoSize = true;
            this.lblRecommandOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRecommandOf.Location = new System.Drawing.Point(210, 237);
            this.lblRecommandOf.Name = "lblRecommandOf";
            this.lblRecommandOf.Size = new System.Drawing.Size(100, 20);
            this.lblRecommandOf.TabIndex = 45;
            this.lblRecommandOf.Text = "Recommand";
            // 
            // cbRecommand
            // 
            this.cbRecommand.FormattingEnabled = true;
            this.cbRecommand.Location = new System.Drawing.Point(214, 259);
            this.cbRecommand.Name = "cbRecommand";
            this.cbRecommand.Size = new System.Drawing.Size(184, 21);
            this.cbRecommand.TabIndex = 46;
            // 
            // picWorker
            // 
            this.picWorker.Image = global::WindowsFormsProject.Properties.Resources.contact_directory_icon_128;
            this.picWorker.Location = new System.Drawing.Point(12, 12);
            this.picWorker.Name = "picWorker";
            this.picWorker.Size = new System.Drawing.Size(147, 137);
            this.picWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWorker.TabIndex = 32;
            this.picWorker.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddOrEditReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 336);
            this.Controls.Add(this.cbRecommand);
            this.Controls.Add(this.lblRecommandOf);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFistName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.picWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrEditReferenceForm";
            this.Text = "AddOrEditReferenceForm";
            this.Load += new System.EventHandler(this.AddOrEditReferenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.PictureBox picWorker;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblRecommandOf;
        private System.Windows.Forms.ComboBox cbRecommand;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}