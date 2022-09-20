namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmPrincipal
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
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComissao
            // 
            this.btnComissao.BackColor = System.Drawing.Color.SpringGreen;
            this.btnComissao.Location = new System.Drawing.Point(33, 78);
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
            this.btnDolar.Location = new System.Drawing.Point(33, 19);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(113, 48);
            this.btnDolar.TabIndex = 1;
            this.btnDolar.Text = "Cotação do Dolar";
            this.btnDolar.UseVisualStyleBackColor = false;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Khaki;
            this.btnSair.Location = new System.Drawing.Point(33, 138);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 49);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(177, 214);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnComissao);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnComissao;
        private Button btnDolar;
        private Button btnSair;
    }
}