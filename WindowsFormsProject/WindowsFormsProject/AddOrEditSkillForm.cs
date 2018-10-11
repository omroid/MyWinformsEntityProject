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
    public partial class AddOrEditSkillForm : Form
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
        public AddOrEditSkillForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOrEditSkillForm_Load(object sender, EventArgs e)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    List<int> employeeId = new List<int>();
                    var query = (from table in myJob.Employees
                                 select new { table.EmployeeId, table.FirstName, table.LastName }).ToList();

                    foreach (var employee in query)
                    {
                        cbSkillOf.Items.Add(string.Format("{0} {1} ", employee.FirstName, employee.LastName));
                        employeeId.Add(employee.EmployeeId);
                    }

                    cbSkillOf.Tag = employeeId.ToArray();

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
                        var query = (from table in myJob.Skills
                                     where table.SkillId == id
                                     select table).SingleOrDefault();

                        txtSkillName.Text = query.SkillName;
                        rtbDescription.Text = query.BriefDescription;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private bool ValidateOfNull()
        {
            if ((txtSkillName.Text=="")||(rtbDescription.Text=="")||(cbSkillOf.SelectedItem == null))
            {
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateOfNull())
            {

                using (MyJobEntities myJob = new MyJobEntities())
                {
                    try
                    {
                        int[] idArray = (int[])cbSkillOf.Tag;
                        var query = (from table in myJob.Skills
                                     where table.SkillId == id
                                     select table).SingleOrDefault();


                        if (DetectAddOrUpdate(id))
                        {
                            query.SkillName = txtSkillName.Text;
                            query.BriefDescription = rtbDescription.Text;
                            query.EmployeeId = idArray[cbSkillOf.SelectedIndex];

                            myJob.SaveChanges();
                            MessageBox.Show("updated Successfuly");
                        }
                        else
                        {
                            myJob.Skills.Add(new Skills { SkillName = txtSkillName.Text, BriefDescription = rtbDescription.Text, EmployeeId = idArray[cbSkillOf.SelectedIndex] });

                            myJob.SaveChanges();
                            MessageBox.Show("added Successfuly");
                        }
                        ucSkillsTable.RefreshTable(1);
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
    }
}
