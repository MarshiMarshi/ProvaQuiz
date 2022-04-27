
namespace ProvaQuiz
{
    partial class frmQuestionOne
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStatement = new System.Windows.Forms.Label();
            this.optAnswearA = new System.Windows.Forms.RadioButton();
            this.optAnswearB = new System.Windows.Forms.RadioButton();
            this.optAnswearC = new System.Windows.Forms.RadioButton();
            this.optAnswearD = new System.Windows.Forms.RadioButton();
            this.optAnswearE = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(35, 33);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(146, 17);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "1- Quanto é 2 + 2?";
            // 
            // optAnswearA
            // 
            this.optAnswearA.AutoSize = true;
            this.optAnswearA.Location = new System.Drawing.Point(38, 86);
            this.optAnswearA.Name = "optAnswearA";
            this.optAnswearA.Size = new System.Drawing.Size(47, 17);
            this.optAnswearA.TabIndex = 1;
            this.optAnswearA.Text = "A) 2.";
            this.optAnswearA.UseVisualStyleBackColor = true;
            // 
            // optAnswearB
            // 
            this.optAnswearB.AutoSize = true;
            this.optAnswearB.Location = new System.Drawing.Point(38, 119);
            this.optAnswearB.Name = "optAnswearB";
            this.optAnswearB.Size = new System.Drawing.Size(50, 17);
            this.optAnswearB.TabIndex = 2;
            this.optAnswearB.Text = "B) -4.";
            this.optAnswearB.UseVisualStyleBackColor = true;
            // 
            // optAnswearC
            // 
            this.optAnswearC.AutoSize = true;
            this.optAnswearC.Location = new System.Drawing.Point(38, 152);
            this.optAnswearC.Name = "optAnswearC";
            this.optAnswearC.Size = new System.Drawing.Size(73, 17);
            this.optAnswearC.TabIndex = 3;
            this.optAnswearC.Text = "C) <\"(((><.";
            this.optAnswearC.UseVisualStyleBackColor = true;
            // 
            // optAnswearD
            // 
            this.optAnswearD.AutoSize = true;
            this.optAnswearD.Location = new System.Drawing.Point(38, 185);
            this.optAnswearD.Name = "optAnswearD";
            this.optAnswearD.Size = new System.Drawing.Size(48, 17);
            this.optAnswearD.TabIndex = 4;
            this.optAnswearD.Text = "D) 4.";
            this.optAnswearD.UseVisualStyleBackColor = true;
            // 
            // optAnswearE
            // 
            this.optAnswearE.AutoSize = true;
            this.optAnswearE.Location = new System.Drawing.Point(38, 218);
            this.optAnswearE.Name = "optAnswearE";
            this.optAnswearE.Size = new System.Drawing.Size(47, 17);
            this.optAnswearE.TabIndex = 5;
            this.optAnswearE.Text = "E) 0.";
            this.optAnswearE.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(138, 279);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(148, 33);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Continuar";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmQuestionOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 324);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.optAnswearE);
            this.Controls.Add(this.optAnswearD);
            this.Controls.Add(this.optAnswearC);
            this.Controls.Add(this.optAnswearB);
            this.Controls.Add(this.optAnswearA);
            this.Controls.Add(this.lblStatement);
            this.Name = "frmQuestionOne";
            this.Text = "Questão - 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.RadioButton optAnswearA;
        private System.Windows.Forms.RadioButton optAnswearB;
        private System.Windows.Forms.RadioButton optAnswearC;
        private System.Windows.Forms.RadioButton optAnswearD;
        private System.Windows.Forms.RadioButton optAnswearE;
        private System.Windows.Forms.Button btnNext;
    }
}

