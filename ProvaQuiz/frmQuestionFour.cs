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
    public partial class frmQuestionFour : Form
    {
        public frmQuestionFour()
        {
            InitializeComponent();
        }

        public frmQuestionFive frm5 = new frmQuestionFive();

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm5.lstOpt.Remove(optAnswearD4);
            frm5.lstOpt.Add(optAnswearD4);

            frm5.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCollection frmList = Application.OpenForms;

            foreach (Form frm in frmList)
            {
                if (frm.Name == "frmQuestionThree")
                {
                    frm.Show();
                }
            }
        }

        private void frmQuestionFour_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
