using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{

    public partial class AddOrEditEmployeeForm : Form
    {
        private int id;
        private bool DetectAddOrUpdate(int id)        /// return true for update and false for add
        {
            if (id > 0)
            {
                return true;
            }
            return false;
        }
        public AddOrEditEmployeeForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            if (DetectAddOrUpdate(this.id))     //true = update, false = add
            {
                using (MyJobEntities myJob = new MyJobEntities())
                {
                    try
                    {
                        var query = (from table in myJob.Employees
                                     where table.EmployeeId == id
                                     select table).SingleOrDefault();

                        txtFistName.Text = query.FirstName;
                        txtLastName.Text = query.LastName;
                        txtAlias.Text = query.Alias;
                        txtEmail.Text = query.Email;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateOfNull())
            {

            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    var query = (from table in myJob.Employees
                                 where table.EmployeeId == id
                                 select table).SingleOrDefault();

               
                    if (DetectAddOrUpdate(id))
                    {
                        query.FirstName = txtFistName.Text;
                        query.LastName = txtLastName.Text;
                        query.Alias = txtAlias.Text;
                        query.Email = txtEmail.Text;

                        myJob.SaveChanges();
                        MessageBox.Show("updated Successfuly");
                    }
                    else
                    {
                        myJob.Employees.Add(new Employees { FirstName = txtFistName.Text, LastName = txtLastName.Text, Alias = txtAlias.Text, Email = txtEmail.Text });
                        myJob.SaveChanges();
                        MessageBox.Show("added Successfuly");
                    }
                    ucEmployeesTable.RefreshTable(1);
                    this.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            }
            else
            {
                MessageBox.Show("please fill all fields");
            }
        }

        private bool ValidateOfNull()
        {
            if ((txtFistName.Text == "") || (txtLastName.Text == "") || (txtAlias.Text == "") ||
                (txtEmail.Text == ""))
            {
                return false;
            }

            return true;
        }
    }
}
