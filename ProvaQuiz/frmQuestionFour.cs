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

        //private int score = 0;
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
            lstOpt.Remove(optAnswearD4);
            lstOpt.Add(optAnswearD4);

            MessageBox.Show($"Sua pontuação foi: {optCheck(0)}.", "Pontuação da Porva", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
