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
    public partial class ucSkills : UserControl
    {
        public ucSkills()
        {
            InitializeComponent();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            PictureBox x = (PictureBox)sender;

            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you want to delete {0} ?", this.lblSkillName.Text), string.Format("Deleting {0}", this.lblSkillName.Text), MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteById(int.Parse(x.Tag.ToString()));
            }
        }

        private void pbViewProfile_Click(object sender, EventArgs e)
        {
            PictureBox view = (PictureBox)sender;
            FullViewSkillsForm fullView = new FullViewSkillsForm(int.Parse(view.Tag.ToString()));
            fullView.ShowDialog();

        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            PictureBox edit = (PictureBox)sender;
            AddOrEditSkillForm editForm = new AddOrEditSkillForm(int.Parse(edit.Tag.ToString()));
            editForm.ShowDialog();
        }

        private void DeleteById(int id)
        {
            using (MyJobEntities myJob = new MyJobEntities())
            {
                try
                {
                    var query = (from table in myJob.Skills
                                 where table.SkillId == id
                                 select table).SingleOrDefault();


                    myJob.Skills.Remove(query);
                    myJob.SaveChanges();
                    MessageBox.Show("Deleting is done");

                    ucSkillsTable.RefreshTable(1);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void InsertParmeters(int id,string skillName,string skillOf,string briefDescription)
        {
            if (briefDescription.Length>15)
            {

                briefDescription = briefDescription.Remove(15);
                briefDescription = string.Format("{0}...", briefDescription);
            }

            lblSkillName.Text = skillName;
            lblBriefDescription.Text = briefDescription;
            lblSkillOf.Text = skillOf;
            pbDelete.Tag = id;
            pbViewProfile.Tag = id;
            pbEdit.Tag = id;
            this.Visible = true;
        }
        private void ucSkills_Load(object sender, EventArgs e)
        {

        }
    }
}
