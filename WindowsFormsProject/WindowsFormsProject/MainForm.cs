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
    public partial class mainForm : Form
    {
        UserControl[] panels;
        public mainForm()
        {
            InitializeComponent();
            panels = new UserControl[]
            {ucEmployeesTableLayer,ucReferenceTableLayer,ucSkillsTableLayer,ucSkillInfoTableLayer};

            ucEmployeesTable.SetInstance(ucEmployeesTableLayer);
            ucReferenceTable.SetInstance(ucReferenceTableLayer);
            ucSkillsTable.SetInstance(ucSkillsTableLayer);
            ucSkillInfoTable.SetInstance(ucSkillInfoTableLayer);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void ChangePanel(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            int lastButtonClickedIndex = 0;

            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i].Visible == true)
                {
                    lastButtonClickedIndex = i;
                    break;
                }
            }

            if (int.Parse(current.Tag.ToString()) != lastButtonClickedIndex)
            {
                btEffectClose.HideSync(panels[lastButtonClickedIndex]);
                btEffectShow.ShowSync(panels[int.Parse(current.Tag.ToString())]);
            }

        }

  
    }
}
