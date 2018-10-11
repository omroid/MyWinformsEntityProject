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
    public partial class FullViewSkillsForm : Form
    {
        private int id;
        public FullViewSkillsForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullViewSkillsForm_Load(object sender, EventArgs e)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {

                    var query = (from table in myJob.Skills
                                 where table.SkillId == id
                                 select table).SingleOrDefault();

                    lblSkillName.Text += query.SkillName;
                    rtbDescription.Text += query.BriefDescription;                
                    lblSkillOf.Text +=string.Format("{0} {1}",query.Employees.FirstName,query.Employees.LastName);

                    foreach (var urls in query.SkillsInfo)
                    {
                        cbUrl.Items.Add(urls.URL);
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
