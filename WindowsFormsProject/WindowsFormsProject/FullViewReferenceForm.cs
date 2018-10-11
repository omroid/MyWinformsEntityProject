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
    public partial class FullViewReferenceForm : Form
    {
        private int id;
      
        public FullViewReferenceForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FullViewReferenceForm_Load(object sender, EventArgs e)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {

                    var query = (from table in myJob.Reference
                                 where table.ReferenceId == id
                                 select table).SingleOrDefault();

                    lblFullName.Text += string.Format("{0} {1}", query.FirstName, query.LastName);
                    lblAlias.Text += query.Alias;
                    lblEmail.Text += query.Email;
                    lblPosition.Text += query.Position;
                    lblRecommand.Text +=string.Format("{0} {1}", query.Employees.FirstName,query.Employees.LastName);



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
    }
}
