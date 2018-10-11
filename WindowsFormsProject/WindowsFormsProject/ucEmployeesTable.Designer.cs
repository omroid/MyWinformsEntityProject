namespace WindowsFormsProject
{
    partial class ucEmployeesTable
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
            this.ucEmployeeFour = new WindowsFormsProject.ucEmployee();
            this.ucEmployeeTwo = new WindowsFormsProject.ucEmployee();
            this.ucEmployeeOne = new WindowsFormsProject.ucEmployee();
            this.ucEmployeeThree = new WindowsFormsProject.ucEmployee();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(157, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(462, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "Search by First Name";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ucEmployeeFour
            // 
            this.ucEmployeeFour.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucEmployeeFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucEmployeeFour.Location = new System.Drawing.Point(385, 191);
            this.ucEmployeeFour.Name = "ucEmployeeFour";
            this.ucEmployeeFour.Size = new System.Drawing.Size(234, 134);
            this.ucEmployeeFour.TabIndex = 15;
            this.ucEmployeeFour.Visible = false;
            // 
            // ucEmployeeTwo
            // 
            this.ucEmployeeTwo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucEmployeeTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucEmployeeTwo.Location = new System.Drawing.Point(385, 42);
            this.ucEmployeeTwo.Name = "ucEmployeeTwo";
            this.ucEmployeeTwo.Size = new System.Drawing.Size(234, 134);
            this.ucEmployeeTwo.TabIndex = 14;
            this.ucEmployeeTwo.Visible = false;
            // 
            // ucEmployeeOne
            // 
            this.ucEmployeeOne.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucEmployeeOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucEmployeeOne.Location = new System.Drawing.Point(127, 42);
            this.ucEmployeeOne.Name = "ucEmployeeOne";
            this.ucEmployeeOne.Size = new System.Drawing.Size(234, 134);
            this.ucEmployeeOne.TabIndex = 13;
            this.ucEmployeeOne.Visible = false;
            // 
            // ucEmployeeThree
            // 
            this.ucEmployeeThree.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucEmployeeThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucEmployeeThree.Location = new System.Drawing.Point(127, 191);
            this.ucEmployeeThree.Name = "ucEmployeeThree";
            this.ucEmployeeThree.Size = new System.Drawing.Size(234, 134);
            this.ucEmployeeThree.TabIndex = 12;
            this.ucEmployeeThree.Visible = false;
            // 
            // pbSearch
            // 
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::WindowsFormsProject.Properties.Resources.google_web_search_16;
            this.pbSearch.Location = new System.Drawing.Point(127, 12);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(24, 24);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSearch.TabIndex = 21;
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
            this.pbAdd.TabIndex = 19;
            this.pbAdd.TabStop = false;
            this.pbAdd.Tag = "0";
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(356, 328);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(30, 13);
            this.lblPage.TabIndex = 31;
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
            this.lblBack.TabIndex = 30;
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
            this.lblNext.TabIndex = 29;
            this.lblNext.Text = ">>";
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // ucEmployeesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.ucEmployeeFour);
            this.Controls.Add(this.ucEmployeeTwo);
            this.Controls.Add(this.ucEmployeeOne);
            this.Controls.Add(this.ucEmployeeThree);
            this.Name = "ucEmployeesTable";
            this.Size = new System.Drawing.Size(756, 369);
            this.Load += new System.EventHandler(this.ucEmployeesTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbAdd;
        private ucEmployee ucEmployeeFour;
        private ucEmployee ucEmployeeTwo;
        private ucEmployee ucEmployeeOne;
        private ucEmployee ucEmployeeThree;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblNext;
    }
}
