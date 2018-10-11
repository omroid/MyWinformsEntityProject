namespace WindowsFormsProject
{
    partial class ucReferenceTable
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.ucReferance3 = new WindowsFormsProject.ucReferance();
            this.ucReferance1 = new WindowsFormsProject.ucReferance();
            this.ucReferance2 = new WindowsFormsProject.ucReferance();
            this.ucReferance4 = new WindowsFormsProject.ucReferance();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(157, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(462, 20);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.Text = "Search by First Name";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(356, 328);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(30, 13);
            this.lblPage.TabIndex = 28;
            this.lblPage.Tag = "1";
            this.lblPage.Text = "1/10";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Location = new System.Drawing.Point(331, 328);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(19, 13);
            this.lblBack.TabIndex = 27;
            this.lblBack.Text = "<<";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNext.Location = new System.Drawing.Point(392, 328);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(19, 13);
            this.lblNext.TabIndex = 26;
            this.lblNext.Text = ">>";
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::WindowsFormsProject.Properties.Resources.google_web_search_16;
            this.pbSearch.Location = new System.Drawing.Point(127, 12);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(24, 24);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSearch.TabIndex = 31;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::WindowsFormsProject.Properties.Resources.ad_user_add_new_plus_icon_24;
            this.pbAdd.Location = new System.Drawing.Point(0, 0);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(24, 24);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdd.TabIndex = 29;
            this.pbAdd.TabStop = false;
            this.pbAdd.Tag = "0";
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // ucReferance3
            // 
            this.ucReferance3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucReferance3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucReferance3.Location = new System.Drawing.Point(127, 191);
            this.ucReferance3.Name = "ucReferance3";
            this.ucReferance3.Size = new System.Drawing.Size(234, 134);
            this.ucReferance3.TabIndex = 32;
            this.ucReferance3.Visible = false;
            // 
            // ucReferance1
            // 
            this.ucReferance1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucReferance1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucReferance1.Location = new System.Drawing.Point(127, 42);
            this.ucReferance1.Name = "ucReferance1";
            this.ucReferance1.Size = new System.Drawing.Size(234, 134);
            this.ucReferance1.TabIndex = 33;
            this.ucReferance1.Visible = false;
            // 
            // ucReferance2
            // 
            this.ucReferance2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucReferance2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucReferance2.Location = new System.Drawing.Point(385, 42);
            this.ucReferance2.Name = "ucReferance2";
            this.ucReferance2.Size = new System.Drawing.Size(234, 134);
            this.ucReferance2.TabIndex = 34;
            this.ucReferance2.Visible = false;
            // 
            // ucReferance4
            // 
            this.ucReferance4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucReferance4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucReferance4.Location = new System.Drawing.Point(385, 191);
            this.ucReferance4.Name = "ucReferance4";
            this.ucReferance4.Size = new System.Drawing.Size(234, 134);
            this.ucReferance4.TabIndex = 35;
            this.ucReferance4.Visible = false;
            // 
            // ucReferenceTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucReferance4);
            this.Controls.Add(this.ucReferance2);
            this.Controls.Add(this.ucReferance1);
            this.Controls.Add(this.ucReferance3);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblNext);
            this.Name = "ucReferenceTable";
            this.Size = new System.Drawing.Size(756, 369);
            this.Load += new System.EventHandler(this.ucReferenceTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblNext;
        private ucReferance ucReferance3;
        private ucReferance ucReferance1;
        private ucReferance ucReferance2;
        private ucReferance ucReferance4;
    }
}
