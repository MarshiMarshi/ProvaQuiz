
namespace ProvaQuiz
{
    partial class frmQuestionFive
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
            this.optAnswearE5 = new System.Windows.Forms.RadioButton();
            this.optAnswearD5 = new System.Windows.Forms.RadioButton();
            this.optAnswearC5 = new System.Windows.Forms.RadioButton();
            this.optAnswearB5 = new System.Windows.Forms.RadioButton();
            this.optAnswearA5 = new System.Windows.Forms.RadioButton();
            this.lblStatement = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optAnswearE5
            // 
            this.optAnswearE5.AutoSize = true;
            this.optAnswearE5.Location = new System.Drawing.Point(27, 208);
            this.optAnswearE5.Name = "optAnswearE5";
            this.optAnswearE5.Size = new System.Drawing.Size(47, 17);
            this.optAnswearE5.TabIndex = 12;
            this.optAnswearE5.Text = "E) 0.";
            this.optAnswearE5.UseVisualStyleBackColor = true;
            // 
            // optAnswearD5
            // 
            this.optAnswearD5.AutoSize = true;
            this.optAnswearD5.Location = new System.Drawing.Point(27, 175);
            this.optAnswearD5.Name = "optAnswearD5";
            this.optAnswearD5.Size = new System.Drawing.Size(48, 17);
            this.optAnswearD5.TabIndex = 11;
            this.optAnswearD5.Text = "D) 4.";
            this.optAnswearD5.UseVisualStyleBackColor = true;
            // 
            // optAnswearC5
            // 
            this.optAnswearC5.AutoSize = true;
            this.optAnswearC5.Location = new System.Drawing.Point(27, 142);
            this.optAnswearC5.Name = "optAnswearC5";
            this.optAnswearC5.Size = new System.Drawing.Size(73, 17);
            this.optAnswearC5.TabIndex = 10;
            this.optAnswearC5.Text = "C) <\"(((><.";
            this.optAnswearC5.UseVisualStyleBackColor = true;
            // 
            // optAnswearB5
            // 
            this.optAnswearB5.AutoSize = true;
            this.optAnswearB5.Location = new System.Drawing.Point(27, 109);
            this.optAnswearB5.Name = "optAnswearB5";
            this.optAnswearB5.Size = new System.Drawing.Size(50, 17);
            this.optAnswearB5.TabIndex = 9;
            this.optAnswearB5.Text = "B) -4.";
            this.optAnswearB5.UseVisualStyleBackColor = true;
            // 
            // optAnswearA5
            // 
            this.optAnswearA5.AutoSize = true;
            this.optAnswearA5.Location = new System.Drawing.Point(27, 76);
            this.optAnswearA5.Name = "optAnswearA5";
            this.optAnswearA5.Size = new System.Drawing.Size(47, 17);
            this.optAnswearA5.TabIndex = 8;
            this.optAnswearA5.Text = "A) 2.";
            this.optAnswearA5.UseVisualStyleBackColor = true;
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(24, 23);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(146, 17);
            this.lblStatement.TabIndex = 7;
            this.lblStatement.Text = "5- Quanto é 2 + 2?";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(73, 279);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(97, 33);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(185, 279);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(97, 33);
            this.btnFinalize.TabIndex = 13;
            this.btnFinalize.Text = "Finalizar";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // frmQuestionFive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 324);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.optAnswearE5);
            this.Controls.Add(this.optAnswearD5);
            this.Controls.Add(this.optAnswearC5);
            this.Controls.Add(this.optAnswearB5);
            this.Controls.Add(this.optAnswearA5);
            this.Controls.Add(this.lblStatement);
            this.Name = "frmQuestionFive";
            this.Text = "Questão - 5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuestionFive_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optAnswearE5;
        private System.Windows.Forms.RadioButton optAnswearD5;
        private System.Windows.Forms.RadioButton optAnswearC5;
        private System.Windows.Forms.RadioButton optAnswearB5;
        private System.Windows.Forms.RadioButton optAnswearA5;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnFinalize;
    }
}