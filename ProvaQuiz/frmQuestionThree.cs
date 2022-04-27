using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaQuiz
{
    public partial class frmQuestionThree : Form
    {
        public frmQuestionThree()
        {
            InitializeComponent();
        }

        public frmQuestionFour frm4 = new frmQuestionFour();

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm4.frm5.lstOpt.Remove(optAnswearD3);
            frm4.frm5.lstOpt.Add(optAnswearD3);

            frm4.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCollection frmList = Application.OpenForms;

            foreach (Form frm in frmList)
            {
                if (frm.Name == "frmQuestionTwo")
                {
                    frm.Show();
                }
            }
        }

        private void frmQuestionThree_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void optAnswearD3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
