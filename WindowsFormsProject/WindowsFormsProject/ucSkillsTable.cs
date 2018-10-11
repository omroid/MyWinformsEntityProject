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
    public partial class ucSkillsTable : UserControl
    {
        static ucSkillsTable instance;
        public ucSkillsTable()
        {
            InitializeComponent();
        }
        public static void SetInstance(ucSkillsTable instance)
        {
            ucSkillsTable.instance = instance;
        }

        private void ucSkillsTable_Load(object sender, EventArgs e)
        {
            RefreshTable(int.Parse(lblPage.Tag.ToString()));
        }


        public static void RefreshTable(int page)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    //insert user controls to array(for looping the by for loop)
                    ucSkills[] skillsArray = new ucSkills[] { instance.ucSkills1, instance.ucSkills2, instance.ucSkills3, instance.ucSkills4 };
                    int startPosition = page * skillsArray.Length - skillsArray.Length;// find the starting position of employee 
                    int endPosition;
                    int skillsArrayindex = 0; // index for skills array 
                    instance.txtSearch.Text = "";

                    for (int i = 0; i < skillsArray.Length; i++)//make all user control unvisibled
                    {
                        skillsArray[i].Visible = false;
                    }
                    //linq query of all the employees
                    var query = (from table in myJob.Skills
                                 select table).ToArray();
                    //find the end position acourding to employee array
                    if (startPosition + skillsArray.Length > query.Length)
                    {
                        endPosition = query.Length;
                    }
                    else
                    {
                        endPosition = startPosition + skillsArray.Length;
                    }

                    //insert data to usercontrols
                    for (int i = startPosition; i < endPosition; i++)
                    {
                        skillsArray[skillsArrayindex].InsertParmeters(query[i].SkillId, query[i].SkillName, string.Format("{0} {1}",query[i].Employees.FirstName,query[i].Employees.LastName),query[i].BriefDescription);
                        skillsArrayindex++;
                    }
                    // fix the view page bar
                    instance.ChangePage(query.Length, page, skillsArray.Length);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }
        private void RefreshTableSearch(int page)
        {

            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    //insert user controls to array(for looping the by for loop)
                    ucSkills[] skillsArray = new ucSkills[] { instance.ucSkills1, instance.ucSkills2, instance.ucSkills3, instance.ucSkills4 };
                    int startPosition = page * skillsArray.Length - skillsArray.Length;// find the starting position of employee 
                    int endPosition;
                    int skillsArrayindex = 0; // index for skills array 
                

                    for (int i = 0; i < skillsArray.Length; i++)//make all user control unvisibled
                    {
                        skillsArray[i].Visible = false;
                    }
                    //linq query of all the employees
                    var query = (from table in myJob.Skills
                                 where table.SkillName==txtSearch.Text
                                 select table).ToArray();
                    //find the end position acourding to employee array
                    if (startPosition + skillsArray.Length > query.Length)
                    {
                        endPosition = query.Length;
                    }
                    else
                    {
                        endPosition = startPosition + skillsArray.Length;
                    }

                    //insert data to usercontrols
                    for (int i = startPosition; i < endPosition; i++)
                    {
                        skillsArray[skillsArrayindex].InsertParmeters(query[i].SkillId, query[i].SkillName, string.Format("{0} {1}", query[i].Employees.FirstName, query[i].Employees.LastName), query[i].BriefDescription);
                        skillsArrayindex++;
                    }
                    // fix the view page bar
                    instance.ChangePage(query.Length, page, skillsArray.Length);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void ChangePage(int queryLengh, int currentPage, int usercontrolCount)
        {
            int maxPage;

            if ((queryLengh % usercontrolCount == 0) && (queryLengh != 0)) //cheak the max page
            {
                maxPage = queryLengh / usercontrolCount;
            }
            else
            {
                maxPage = queryLengh / usercontrolCount + 1;
            }

            if (currentPage == maxPage) //cheak limit if max page 
            {
                lblNext.Enabled = false;
            }
            else
            {
                lblNext.Enabled = true;
            }

            if (currentPage == 1) //cheak limit of first page
            {
                lblBack.Enabled = false;

            }
            else
            {
                lblBack.Enabled = true;
            }


            lblPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
            lblPage.Tag = currentPage;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                RefreshTable(1);
            }
            else
            {
                RefreshTableSearch(1);
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

            PictureBox add = (PictureBox)sender;

            AddOrEditSkillForm editForm = new AddOrEditSkillForm(int.Parse(add.Tag.ToString()));
            editForm.ShowDialog();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by First Name")
            {
                txtSearch.Text = "";
            }
        }

        private void lblNext_Click(object sender, EventArgs e)
        {

            if ((txtSearch.Text == "")) //if you dont search
            {
                RefreshTable(int.Parse(lblPage.Tag.ToString()) + 1); //call refresh without search (page + 1 )
            }
            else
            {
                RefreshTableSearch(int.Parse(lblPage.Tag.ToString()) + 1); //call refresh with search (page + 1)
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {

            if ((txtSearch.Text == "")) //if you dont search
            {
                RefreshTable(int.Parse(lblPage.Tag.ToString()) - 1); //call  refresh without search (page -1)
            }
            else
            {
                RefreshTableSearch(int.Parse(lblPage.Tag.ToString()) - 1);//call refresh with search (page - 1)
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblBack.Enabled = false;
            lblNext.Enabled = false;
        }
    }
}
