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
    public partial class frmQuestionFive : Form
    {
        public frmQuestionFive()
        {
            InitializeComponent();
        }

        public List<RadioButton> lstOpt = new List<RadioButton>();

        private int optCheck(int score)
        {
            foreach (RadioButton opt in lstOpt)
            {
                if (opt.Checked)
                {
                    score++;
                }
            }

            return score;
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            lstOpt.Remove(optAnswearB5);
            lstOpt.Add(optAnswearB5);

            MessageBox.Show($"Sua pontuação foi: {optCheck(0)}.", "Pontuação da Porva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCollection frmList = Application.OpenForms;

            foreach (Form frm in frmList)
            {
                if (frm.Name == "frmQuestionFour")
                {
                    frm.Show();
                }
            }
        }

        private void frmQuestionFive_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
