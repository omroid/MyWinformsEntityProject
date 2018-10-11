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
    public partial class ucSkillInfo : UserControl
    {
        public ucSkillInfo()
        {
            InitializeComponent();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
               PictureBox x = (PictureBox)sender;

            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you want to delete skill info Of{0} ?",this.lblSkillInfoOf.Text), string.Format("Deleting skill Info Of {0}",this.lblSkillInfoOf.Text), MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteById(int.Parse(x.Tag.ToString()));
            }
        }


        public void InsertParmeters(int id,string url ,string skillOf)
        {
            lblSkillInfoOf.Text = skillOf;
            lblUrl.Text = url;
            pbViewProfile.Tag = id;
            pbEdit.Tag = id;
            pbDelete.Tag = id;
            this.Visible = true;
        }

        private void DeleteById(int id)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {

                    var query = (from table in myJob.SkillsInfo
                                 where table.SkillInfoId == id
                                 select table).SingleOrDefault();


                    myJob.SkillsInfo.Remove(query);
                    myJob.SaveChanges();
                    MessageBox.Show("Deleting is done");

                   ucSkillInfoTable.RefreshTable(1);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            PictureBox edit = (PictureBox)sender;
            AddOrEditSkillInfoForm editForm = new AddOrEditSkillInfoForm(int.Parse(edit.Tag.ToString()));
            editForm.ShowDialog();
        }
    }
}
