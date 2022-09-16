namespace AplicacaoPoo.Estrutural.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComissao = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComissao
            // 
            this.btnComissao.BackColor = System.Drawing.Color.SpringGreen;
            this.btnComissao.Location = new System.Drawing.Point(37, 118);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(113, 49);
            this.btnComissao.TabIndex = 0;
            this.btnComissao.Text = "Comissão de peças";
            this.btnComissao.UseVisualStyleBackColor = false;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.BackColor = System.Drawing.Color.LightCoral;
            this.btnDolar.Location = new System.Drawing.Point(37, 33);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(113, 48);
            this.btnDolar.TabIndex = 1;
            this.btnDolar.Text = "Cotação do Dolar";
            this.btnDolar.UseVisualStyleBackColor = false;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(194, 205);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnComissao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnComissao;
        private Button btnDolar;
    }
}