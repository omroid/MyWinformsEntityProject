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
    public partial class FullViewEmployeeForm : Form
    {
        private int id;

        public FullViewEmployeeForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FullViewForm_Load(object sender, EventArgs e)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    List<int> skillIdList = new List<int>();

                    var query = (from table in myJob.Employees
                                where table.EmployeeId == id
                                select table).SingleOrDefault();

                    lblFullName.Text += string.Format("{0} {1}", query.FirstName, query.LastName);
                    lblAlias.Text += query.Alias;
                    lblEmail.Text += query.Email;
                  

                    foreach (var skill in query.Skills)
                    {
                        cbSkills.Items.Add(skill.SkillName);
                        skillIdList.Add(skill.SkillId);
                    }
                    cbSkills.Tag = skillIdList.ToArray();
                    foreach (var reference in query.Reference)
                    {
                        cbReferences.Items.Add(reference.FirstName);
                    }


                    
                    
        
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {

                try
                {
                    rtbSkillInfo.Text = "";
                    int[] arrayForData = (int[])cbSkills.Tag;
                    int selectedIndex = arrayForData[cbSkills.SelectedIndex];



                    var query = from table in myJob.SkillsInfo
                                 where table.SkillId == selectedIndex
                                select table;

                    foreach (var item in query)
                    {
                        rtbSkillInfo.Text += string.Format("{0}\n", item.URL);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
