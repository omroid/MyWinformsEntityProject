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
    public partial class AddOrEditSkillInfoForm : Form
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
        public AddOrEditSkillInfoForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOrEditSkillInfoForm_Load(object sender, EventArgs e)
        {

            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    List<int> skillsId = new List<int>();
                    var query = (from table in myJob.Skills
                                 select table).ToList();

                    foreach (var skill in query)
                    {
                        cbSkillInfoOf.Items.Add(skill.SkillName);
                        skillsId.Add(skill.SkillId);
                    }

                    cbSkillInfoOf.Tag = skillsId.ToArray();

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
                        var query = (from table in myJob.SkillsInfo
                                     where table.SkillInfoId == id
                                     select table).SingleOrDefault();

                        txtUrl.Text = query.URL;

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
                        int[] idArray = (int[])cbSkillInfoOf.Tag;
                        var query = (from table in myJob.SkillsInfo
                                     where table.SkillInfoId == id
                                     select table).SingleOrDefault();


                        if (DetectAddOrUpdate(id))
                        {
                            query.URL = txtUrl.Text;
                            query.SkillId = idArray[cbSkillInfoOf.SelectedIndex];

                            myJob.SaveChanges();
                            MessageBox.Show("updated Successfuly");
                        }
                        else
                        {
                            myJob.SkillsInfo.Add(new SkillsInfo { URL = txtUrl.Text, SkillId = idArray[cbSkillInfoOf.SelectedIndex] });
                        
                            myJob.SaveChanges();
                            MessageBox.Show("added Successfuly");
                        }
                        ucSkillInfoTable.RefreshTable(1);
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
            if ((txtUrl.Text == "") || (cbSkillInfoOf.SelectedItem == null))
            {
                return false;
            }

            return true;
        }
    }
}
