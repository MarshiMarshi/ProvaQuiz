﻿using System;
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
    public partial class frmQuestionOne : Form
    {
        public frmQuestionOne()
        {
            InitializeComponent();
        }

        private frmQuestionTwo frm2 = new frmQuestionTwo();

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2.frm3.frm4.frm5.lstOpt.Remove(optAnswearC);
            frm2.frm3.frm4.frm5.lstOpt.Add(optAnswearC);

            frm2.Show();
        }

        private void optAnswearE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optAnswearD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optAnswearC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optAnswearB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optAnswearA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblStatement_Click(object sender, EventArgs e)
        {

        }
    }
}
