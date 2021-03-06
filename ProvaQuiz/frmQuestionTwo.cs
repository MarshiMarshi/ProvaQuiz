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
    public partial class frmQuestionTwo : Form
    {
        public frmQuestionTwo()
        {
            InitializeComponent();
        }

        public frmQuestionThree frm3 = new frmQuestionThree();

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm3.frm4.frm5.lstOpt.Remove(optAnswearA2);
            frm3.frm4.frm5.lstOpt.Add(optAnswearA2);

            frm3.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCollection frmList = Application.OpenForms;

            foreach (Form frm in frmList)
            {
                if (frm.Name == "frmQuestionOne")
                {
                    frm.Show();
                }
            }
        }

        private void frmQuestionTwo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
