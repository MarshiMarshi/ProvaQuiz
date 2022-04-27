
namespace ProvaQuiz
{
    partial class frmQuestionFour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.optAnswearE4 = new System.Windows.Forms.RadioButton();
            this.optAnswearD4 = new System.Windows.Forms.RadioButton();
            this.optAnswearC4 = new System.Windows.Forms.RadioButton();
            this.optAnswearB4 = new System.Windows.Forms.RadioButton();
            this.optAnswearA4 = new System.Windows.Forms.RadioButton();
            this.lblStatement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(66, 269);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(97, 33);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(178, 269);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 33);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Continuar";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // optAnswearE4
            // 
            this.optAnswearE4.AutoSize = true;
            this.optAnswearE4.Location = new System.Drawing.Point(27, 208);
            this.optAnswearE4.Name = "optAnswearE4";
            this.optAnswearE4.Size = new System.Drawing.Size(47, 17);
            this.optAnswearE4.TabIndex = 5;
            this.optAnswearE4.Text = "E) 6.";
            this.optAnswearE4.UseVisualStyleBackColor = true;
            // 
            // optAnswearD4
            // 
            this.optAnswearD4.AutoSize = true;
            this.optAnswearD4.Location = new System.Drawing.Point(27, 175);
            this.optAnswearD4.Name = "optAnswearD4";
            this.optAnswearD4.Size = new System.Drawing.Size(48, 17);
            this.optAnswearD4.TabIndex = 4;
            this.optAnswearD4.Text = "D) 2.";
            this.optAnswearD4.UseVisualStyleBackColor = true;
            // 
            // optAnswearC4
            // 
            this.optAnswearC4.AutoSize = true;
            this.optAnswearC4.Location = new System.Drawing.Point(27, 142);
            this.optAnswearC4.Name = "optAnswearC4";
            this.optAnswearC4.Size = new System.Drawing.Size(50, 17);
            this.optAnswearC4.TabIndex = 3;
            this.optAnswearC4.Text = "C) -4.";
            this.optAnswearC4.UseVisualStyleBackColor = true;
            // 
            // optAnswearB4
            // 
            this.optAnswearB4.AutoSize = true;
            this.optAnswearB4.Location = new System.Drawing.Point(27, 109);
            this.optAnswearB4.Name = "optAnswearB4";
            this.optAnswearB4.Size = new System.Drawing.Size(50, 17);
            this.optAnswearB4.TabIndex = 2;
            this.optAnswearB4.Text = "B) -2.";
            this.optAnswearB4.UseVisualStyleBackColor = true;
            // 
            // optAnswearA4
            // 
            this.optAnswearA4.AutoSize = true;
            this.optAnswearA4.Location = new System.Drawing.Point(27, 76);
            this.optAnswearA4.Name = "optAnswearA4";
            this.optAnswearA4.Size = new System.Drawing.Size(47, 17);
            this.optAnswearA4.TabIndex = 1;
            this.optAnswearA4.Text = "A) 4.";
            this.optAnswearA4.UseVisualStyleBackColor = true;
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(24, 23);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(186, 17);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "4- Quanto é x^2 - 4 = 0?";
            // 
            // frmQuestionFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 324);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.optAnswearE4);
            this.Controls.Add(this.optAnswearD4);
            this.Controls.Add(this.optAnswearC4);
            this.Controls.Add(this.optAnswearB4);
            this.Controls.Add(this.optAnswearA4);
            this.Controls.Add(this.lblStatement);
            this.Name = "frmQuestionFour";
            this.Text = "Questão - 4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuestionFour_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton optAnswearE4;
        private System.Windows.Forms.RadioButton optAnswearD4;
        private System.Windows.Forms.RadioButton optAnswearC4;
        private System.Windows.Forms.RadioButton optAnswearB4;
        private System.Windows.Forms.RadioButton optAnswearA4;
        private System.Windows.Forms.Label lblStatement;
    }
}