
namespace ProvaQuiz
{
    partial class frmQuestionThree
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
            this.optAnswearE3 = new System.Windows.Forms.RadioButton();
            this.optAnswearD3 = new System.Windows.Forms.RadioButton();
            this.optAnswearC3 = new System.Windows.Forms.RadioButton();
            this.optAnswearB3 = new System.Windows.Forms.RadioButton();
            this.optAnswearA3 = new System.Windows.Forms.RadioButton();
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
            // optAnswearE3
            // 
            this.optAnswearE3.AutoSize = true;
            this.optAnswearE3.Location = new System.Drawing.Point(27, 208);
            this.optAnswearE3.Name = "optAnswearE3";
            this.optAnswearE3.Size = new System.Drawing.Size(65, 17);
            this.optAnswearE3.TabIndex = 5;
            this.optAnswearE3.Text = "E) 1318.";
            this.optAnswearE3.UseVisualStyleBackColor = true;
            // 
            // optAnswearD3
            // 
            this.optAnswearD3.AutoSize = true;
            this.optAnswearD3.Location = new System.Drawing.Point(27, 175);
            this.optAnswearD3.Name = "optAnswearD3";
            this.optAnswearD3.Size = new System.Drawing.Size(66, 17);
            this.optAnswearD3.TabIndex = 4;
            this.optAnswearD3.Text = "D) 1296.";
            this.optAnswearD3.UseVisualStyleBackColor = true;
            // 
            // optAnswearC3
            // 
            this.optAnswearC3.AutoSize = true;
            this.optAnswearC3.Location = new System.Drawing.Point(27, 142);
            this.optAnswearC3.Name = "optAnswearC3";
            this.optAnswearC3.Size = new System.Drawing.Size(65, 17);
            this.optAnswearC3.TabIndex = 3;
            this.optAnswearC3.Text = "C) 1300.";
            this.optAnswearC3.UseVisualStyleBackColor = true;
            // 
            // optAnswearB3
            // 
            this.optAnswearB3.AutoSize = true;
            this.optAnswearB3.Location = new System.Drawing.Point(27, 109);
            this.optAnswearB3.Name = "optAnswearB3";
            this.optAnswearB3.Size = new System.Drawing.Size(71, 17);
            this.optAnswearB3.TabIndex = 2;
            this.optAnswearB3.Text = "B) 12960.";
            this.optAnswearB3.UseVisualStyleBackColor = true;
            // 
            // optAnswearA3
            // 
            this.optAnswearA3.AutoSize = true;
            this.optAnswearA3.Location = new System.Drawing.Point(27, 76);
            this.optAnswearA3.Name = "optAnswearA3";
            this.optAnswearA3.Size = new System.Drawing.Size(71, 17);
            this.optAnswearA3.TabIndex = 1;
            this.optAnswearA3.Text = "A) 42069.";
            this.optAnswearA3.UseVisualStyleBackColor = true;
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(24, 23);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(144, 17);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "3- Quanto é 36^2?";
            // 
            // frmQuestionThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 324);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.optAnswearE3);
            this.Controls.Add(this.optAnswearD3);
            this.Controls.Add(this.optAnswearC3);
            this.Controls.Add(this.optAnswearB3);
            this.Controls.Add(this.optAnswearA3);
            this.Controls.Add(this.lblStatement);
            this.Name = "frmQuestionThree";
            this.Text = "Questão - 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuestionThree_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton optAnswearE3;
        private System.Windows.Forms.RadioButton optAnswearD3;
        private System.Windows.Forms.RadioButton optAnswearC3;
        private System.Windows.Forms.RadioButton optAnswearB3;
        private System.Windows.Forms.RadioButton optAnswearA3;
        private System.Windows.Forms.Label lblStatement;
    }
}