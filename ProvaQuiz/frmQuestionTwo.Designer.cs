
namespace ProvaQuiz
{
    partial class frmQuestionTwo
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
            this.optAnswearE2 = new System.Windows.Forms.RadioButton();
            this.optAnswearD2 = new System.Windows.Forms.RadioButton();
            this.optAnswearC2 = new System.Windows.Forms.RadioButton();
            this.optAnswearB2 = new System.Windows.Forms.RadioButton();
            this.optAnswearA2 = new System.Windows.Forms.RadioButton();
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
            // optAnswearE2
            // 
            this.optAnswearE2.AutoSize = true;
            this.optAnswearE2.Location = new System.Drawing.Point(27, 208);
            this.optAnswearE2.Name = "optAnswearE2";
            this.optAnswearE2.Size = new System.Drawing.Size(53, 17);
            this.optAnswearE2.TabIndex = 5;
            this.optAnswearE2.Text = "E) 13.";
            this.optAnswearE2.UseVisualStyleBackColor = true;
            // 
            // optAnswearD2
            // 
            this.optAnswearD2.AutoSize = true;
            this.optAnswearD2.Location = new System.Drawing.Point(27, 175);
            this.optAnswearD2.Name = "optAnswearD2";
            this.optAnswearD2.Size = new System.Drawing.Size(54, 17);
            this.optAnswearD2.TabIndex = 4;
            this.optAnswearD2.Text = "D) 12.";
            this.optAnswearD2.UseVisualStyleBackColor = true;
            // 
            // optAnswearC2
            // 
            this.optAnswearC2.AutoSize = true;
            this.optAnswearC2.Location = new System.Drawing.Point(27, 142);
            this.optAnswearC2.Name = "optAnswearC2";
            this.optAnswearC2.Size = new System.Drawing.Size(53, 17);
            this.optAnswearC2.TabIndex = 3;
            this.optAnswearC2.Text = "C) 14.";
            this.optAnswearC2.UseVisualStyleBackColor = true;
            // 
            // optAnswearB2
            // 
            this.optAnswearB2.AutoSize = true;
            this.optAnswearB2.Location = new System.Drawing.Point(27, 109);
            this.optAnswearB2.Name = "optAnswearB2";
            this.optAnswearB2.Size = new System.Drawing.Size(53, 17);
            this.optAnswearB2.TabIndex = 2;
            this.optAnswearB2.Text = "B) 36.";
            this.optAnswearB2.UseVisualStyleBackColor = true;
            // 
            // optAnswearA2
            // 
            this.optAnswearA2.AutoSize = true;
            this.optAnswearA2.Location = new System.Drawing.Point(27, 76);
            this.optAnswearA2.Name = "optAnswearA2";
            this.optAnswearA2.Size = new System.Drawing.Size(47, 17);
            this.optAnswearA2.TabIndex = 1;
            this.optAnswearA2.Text = "A) 6.";
            this.optAnswearA2.UseVisualStyleBackColor = true;
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(24, 23);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(200, 17);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "2- Quanto é √(256 - 220)?";
            // 
            // frmQuestionTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 324);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.optAnswearE2);
            this.Controls.Add(this.optAnswearD2);
            this.Controls.Add(this.optAnswearC2);
            this.Controls.Add(this.optAnswearB2);
            this.Controls.Add(this.optAnswearA2);
            this.Controls.Add(this.lblStatement);
            this.Name = "frmQuestionTwo";
            this.Text = "Questão - 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuestionTwo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton optAnswearE2;
        private System.Windows.Forms.RadioButton optAnswearD2;
        private System.Windows.Forms.RadioButton optAnswearC2;
        private System.Windows.Forms.RadioButton optAnswearB2;
        private System.Windows.Forms.RadioButton optAnswearA2;
        private System.Windows.Forms.Label lblStatement;
    }
}