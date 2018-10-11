using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class ucEmployee : UserControl
    {
    
        public ucEmployee()
        {
            InitializeComponent();
           
        }

        public void InsertParmeters(int id,string firstName,string lastName,string alias,string email)
        {
            lblFullName.Text = string.Format("{0} {1}", firstName, lastName);
            lblAlias.Text = alias;
            lblEmail.Text = email;
            pbDelete.Tag = id;
            pbViewProfile.Tag = id;
            pbEdit.Tag = id;
            this.Visible = true;
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            PictureBox x = (PictureBox)sender;

            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you want to delete {0} ?",this.lblFullName.Text), string.Format("Deleting {0}",this.lblFullName.Text), MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteById(int.Parse(x.Tag.ToString()));
            }
       
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            PictureBox edit = (PictureBox)sender;
            AddOrEditEmployeeForm editForm = new AddOrEditEmployeeForm(int.Parse(edit.Tag.ToString()));
            editForm.ShowDialog();
        }

        private void pbViewProfile_Click(object sender, EventArgs e)
        {
            PictureBox view = (PictureBox)sender;
            FullViewEmployeeForm fullView = new FullViewEmployeeForm(int.Parse(view.Tag.ToString()));
            fullView.ShowDialog();
        }

        private void DeleteById(int id)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {

           
                var query = (from table in myJob.Employees
                             where table.EmployeeId == id
                             select table).SingleOrDefault();


                myJob.Employees.Remove(query);
                myJob.SaveChanges();
                MessageBox.Show("Deleting is done");

                   
                ucEmployeesTable.RefreshTable(1);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
