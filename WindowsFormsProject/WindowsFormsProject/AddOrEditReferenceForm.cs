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
    public partial class AddOrEditReferenceForm : Form
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
        public AddOrEditReferenceForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void AddOrEditReferenceForm_Load(object sender, EventArgs e)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    List<int> employeeId = new List<int>();
                    var query = (from table in myJob.Employees
                                 select new { table.EmployeeId, table.FirstName,table.LastName }).ToList();

                    foreach (var employee in query)
                    {
                        cbRecommand.Items.Add(string.Format("{0} {1} ",employee.FirstName,employee.LastName));
                        employeeId.Add(employee.EmployeeId);
                    }

                    cbRecommand.Tag = employeeId.ToArray();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            if (DetectAddOrUpdate(this.id))     //true = update, false = add
            {
                using (MyJobEntities myJob = new MyJobEntities())
                {
                    try
                    {
                        var query = (from table in myJob.Reference
                                     where table.ReferenceId == id
                                     select table).SingleOrDefault();

                        txtFistName.Text = query.FirstName;
                        txtLastName.Text = query.LastName;
                        txtAlias.Text = query.Alias;
                        txtPosition.Text = query.Position;
                        txtEmail.Text = query.Email;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
           
            }


        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateOfNull())
            {


                using (MyJobEntities myJob = new MyJobEntities())
                {
                    try
                    {
                        int[] idArray = (int[])cbRecommand.Tag;
                        var query = (from table in myJob.Reference
                                     where table.ReferenceId == id
                                     select table).SingleOrDefault();


                        if (DetectAddOrUpdate(id))
                        {
                            query.FirstName = txtFistName.Text;
                            query.LastName = txtLastName.Text;
                            query.Alias = txtAlias.Text;
                            query.Position = txtPosition.Text;
                            query.Email = txtEmail.Text;
                            query.EmployeeId = idArray[cbRecommand.SelectedIndex];

                            myJob.SaveChanges();
                            MessageBox.Show("updated Successfuly");
                        }
                        else
                        {
                            myJob.Reference.Add(new Reference { FirstName = txtFistName.Text, LastName = txtLastName.Text, Alias = txtAlias.Text, Position = txtPosition.Text, Email = txtEmail.Text, EmployeeId = idArray[cbRecommand.SelectedIndex] });
                            myJob.SaveChanges();
                            MessageBox.Show("added Successfuly");
                        }
                        ucReferenceTable.RefreshTable(1);
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
                MessageBox.Show("please fill all fileds");
            }
        }


        private bool ValidateOfNull()
        {
            if ((txtFistName.Text == "") || (txtLastName.Text == "") || (txtAlias.Text == "") || (txtPosition.Text == "") ||
                (txtEmail.Text == "")||(cbRecommand.SelectedItem==null))
            {
                return false;
            }

            return true;
        }
    }
}
