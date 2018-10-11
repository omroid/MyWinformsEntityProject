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
    public partial class ucEmployeesTable : UserControl
    {
       static ucEmployeesTable instance;
       

        public ucEmployeesTable()
        {
            InitializeComponent();
        }

        public static void SetInstance(ucEmployeesTable instance)
        {
            ucEmployeesTable.instance = instance;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
          
            PictureBox add = (PictureBox)sender;
            AddOrEditEmployeeForm editForm = new AddOrEditEmployeeForm(int.Parse(add.Tag.ToString()));
            editForm.ShowDialog();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by First Name")
            {
                txtSearch.Text = "";
            }

        }

        private void ucEmployeesTable_Load(object sender, EventArgs e)
        {
            RefreshTable(int.Parse(lblPage.Tag.ToString()));
        }

    

        private void ChangePage(int queryLengh,int currentPage,int usercontrolCount)
        {
            int maxPage;

            if ((queryLengh % usercontrolCount == 0)&& (queryLengh!=0)) //cheak the max page
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

        private void lblNext_Click(object sender, EventArgs e)
        {
    
            if ((txtSearch.Text=="")) //if you dont search
            {
            RefreshTable(int.Parse(lblPage.Tag.ToString())+1); //call  refresh without search (page + 1 )
            }
            else
            {
                RefreshTableSearch(int.Parse(lblPage.Tag.ToString())+1); //call refresh with search (page + 1)
            }

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
    
            if ((txtSearch.Text == "")) //if you dont search
            {
                RefreshTable(int.Parse(lblPage.Tag.ToString())-1); //call  refresh without search (page -1)
            }
            else
            {
                RefreshTableSearch(int.Parse(lblPage.Tag.ToString())-1);//call refresh with search (page - 1)
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if ((txtSearch.Text == "") || txtSearch.Text == "Search by First Name")
            {
                RefreshTable(1);
            }
            else
            {
                RefreshTableSearch(1);
            }
        }

        public static void RefreshTable(int page)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                  
                    //insert user controls to array(for looping the by for loop)
                    ucEmployee[] employeeArray = new ucEmployee[] { instance.ucEmployeeOne, instance.ucEmployeeTwo, instance.ucEmployeeThree, instance.ucEmployeeFour };
                    int startPosition = page * employeeArray.Length - employeeArray.Length;// find the starting position of employee 
                    int endPosition;
                    int employeeArrayindex = 0; // index for employee array only
                    instance.txtSearch.Text = "";

                    for (int i = 0; i < employeeArray.Length; i++)//make all user control unvisibled
                    {
                        employeeArray[i].Visible = false;
                    }
                    //linq query of all the employees
                    var query = (from table in myJob.Employees
                                 select new { table.EmployeeId, table.FirstName, table.LastName, table.Alias, table.Email }).ToArray();
                    //find the end position acourding to employee array
                    if (startPosition + employeeArray.Length > query.Length)
                    {
                        endPosition = query.Length;
                    }
                    else
                    {
                        endPosition = startPosition + employeeArray.Length;
                    }

                    //insert data to usercontrols
                    for (int i = startPosition; i < endPosition; i++)
                    {
                        employeeArray[employeeArrayindex].InsertParmeters(query[i].EmployeeId, query[i].FirstName, query[i].LastName, query[i].Alias, query[i].Email);
                        employeeArrayindex++;
                    }
                    // fix the view page bar
                    instance.ChangePage(query.Length, page, employeeArray.Length);
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
                    ucEmployee[] employeeArray = new ucEmployee[] { instance.ucEmployeeOne, instance.ucEmployeeTwo, instance.ucEmployeeThree, instance.ucEmployeeFour };
                    int startPosition = page * employeeArray.Length - employeeArray.Length;// find the starting position of employee 
                    int endPosition;
                    int employeeArrayindex = 0; // index for employee array only


                    for (int i = 0; i < employeeArray.Length; i++)//make all user control unvisibled
                    {
                        employeeArray[i].Visible = false;
                    }
                    //linq query to search employee by first name
                    var query = (from table in myJob.Employees
                                 where table.FirstName==txtSearch.Text
                                 select new { table.EmployeeId, table.FirstName, table.LastName, table.Alias, table.Email }).ToArray();
                    //find the end position acourding to employee array
                    if (startPosition + employeeArray.Length > query.Length)
                    {
                        endPosition = query.Length;
                    }
                    else
                    {
                        endPosition = startPosition + employeeArray.Length;
                    }

                    //insert data to usercontrols
                    for (int i = startPosition; i < endPosition; i++)
                    {
                        employeeArray[employeeArrayindex].InsertParmeters(query[i].EmployeeId, query[i].FirstName, query[i].LastName, query[i].Alias, query[i].Email);
                        employeeArrayindex++;
                    }
                    // fix the view page bar
                    instance.ChangePage(query.Length, page, employeeArray.Length);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblBack.Enabled = false;
            lblNext.Enabled = false;
        }
    }
}
