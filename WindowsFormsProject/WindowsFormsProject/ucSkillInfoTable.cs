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
    public partial class ucSkillInfoTable : UserControl
    {
        static ucSkillInfoTable instance;
        public ucSkillInfoTable()
        {
            InitializeComponent();
        }

        public static void SetInstance(ucSkillInfoTable instance)
        {
            ucSkillInfoTable.instance = instance;
        }
        private void ucSkillInfoTable_Load(object sender, EventArgs e)
        {
            RefreshTable(int.Parse(lblPage.Tag.ToString()));
        }




        private void pbAdd_Click(object sender, EventArgs e)
        {

            PictureBox add = (PictureBox)sender;

            AddOrEditSkillInfoForm editForm = new AddOrEditSkillInfoForm(int.Parse(add.Tag.ToString()));
            editForm.ShowDialog();
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



        public static void RefreshTable(int page)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    //insert user controls to array(for looping the by for loop)
                    ucSkillInfo[] skillInfoArray = new ucSkillInfo[] { instance.ucSkillInfo1, instance.ucSkillInfo2, instance.ucSkillInfo3, instance.ucSkillInfo4,};
                    int startPosition = page * skillInfoArray.Length - skillInfoArray.Length;// find the starting position of employee 
                    int endPosition;
                    int EmployeeArrayindex = 0; // index for employee array only
                    instance.txtSearch.Text = "";

                    for (int i = 0; i < skillInfoArray.Length; i++)//make all user control unvisibled
                    {
                        skillInfoArray[i].Visible = false;
                    }
                    //linq query of all the employees
                    var query = (from table in myJob.SkillsInfo
                                 select table).ToArray();
                    //find the end position acourding to employee array
                    if (startPosition + skillInfoArray.Length > query.Length)
                    {
                        endPosition = query.Length;
                    }
                    else
                    {
                        endPosition = startPosition + skillInfoArray.Length;
                    }

                    //insert data to usercontrols
                    for (int i = startPosition; i < endPosition; i++)
                    {
                        skillInfoArray[EmployeeArrayindex].InsertParmeters(query[i].SkillInfoId, query[i].URL, query[i].Skills.SkillName);
                        EmployeeArrayindex++;
                    }
                    // fix the view page bar
                    instance.ChangePage(query.Length, page, skillInfoArray.Length);
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
                    ucSkillInfo[] skillInfoArray = new ucSkillInfo[] { instance.ucSkillInfo1, instance.ucSkillInfo2, instance.ucSkillInfo3, instance.ucSkillInfo4, };
                    int startPosition = page * skillInfoArray.Length - skillInfoArray.Length;// find the starting position of employee 
                    int endPosition;
                    int EmployeeArrayindex = 0; // index for employee array only


                    for (int i = 0; i < skillInfoArray.Length; i++)//make all user control unvisibled
                    {
                        skillInfoArray[i].Visible = false;
                    }
                    //linq query of all the employees
                    var query = (from table in myJob.SkillsInfo
                                 where table.URL == txtSearch.Text
                                 select table).ToArray();
                    //find the end position acourding to employee array
                    if (startPosition + skillInfoArray.Length > query.Length)
                    {
                        endPosition = query.Length;
                    }
                    else
                    {
                        endPosition = startPosition + skillInfoArray.Length;
                    }

                    //insert data to usercontrols
                    for (int i = startPosition; i < endPosition; i++)
                    {
                        skillInfoArray[EmployeeArrayindex].InsertParmeters(query[i].SkillInfoId, query[i].URL, query[i].Skills.SkillName);
                        EmployeeArrayindex++;
                    }
                    // fix the view page bar
                    instance.ChangePage(query.Length, page, skillInfoArray.Length);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblBack.Enabled = false;
            lblNext.Enabled = false;
        }

    }
}
