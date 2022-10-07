namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmComissao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoDaPeca = new System.Windows.Forms.TextBox();
            this.txtPrecoDaPeca = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbIdentificacaoVendedor = new System.Windows.Forms.ComboBox();
            this.lblComissao = new System.Windows.Forms.Label();
            this.lblDescricaoDaPeca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação do vendedor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código da peça :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Preço unitário da peça :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantidade vendida :";
            // 
            // txtCodigoDaPeca
            // 
            this.txtCodigoDaPeca.Location = new System.Drawing.Point(218, 55);
            this.txtCodigoDaPeca.Name = "txtCodigoDaPeca";
            this.txtCodigoDaPeca.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoDaPeca.TabIndex = 1;
            // 
            // txtPrecoDaPeca
            // 
            this.txtPrecoDaPeca.Location = new System.Drawing.Point(218, 87);
            this.txtPrecoDaPeca.Name = "txtPrecoDaPeca";
            this.txtPrecoDaPeca.Size = new System.Drawing.Size(100, 23);
            this.txtPrecoDaPeca.TabIndex = 1;
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(218, 118);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadeVendida.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comissão :";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(21, 268);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // cmbIdentificacaoVendedor
            // 
            this.cmbIdentificacaoVendedor.FormattingEnabled = true;
            this.cmbIdentificacaoVendedor.Items.AddRange(new object[] {
            "Shamyra",
            "Jarlis",
            "Diogo",
            "Alessandra"});
            this.cmbIdentificacaoVendedor.Location = new System.Drawing.Point(218, 26);
            this.cmbIdentificacaoVendedor.Name = "cmbIdentificacaoVendedor";
            this.cmbIdentificacaoVendedor.Size = new System.Drawing.Size(100, 23);
            this.cmbIdentificacaoVendedor.TabIndex = 6;
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblComissao.Location = new System.Drawing.Point(107, 268);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(81, 21);
            this.lblComissao.TabIndex = 8;
            this.lblComissao.Text = "Comissao";
            // 
            // lblDescricaoDaPeca
            // 
            this.lblDescricaoDaPeca.AutoSize = true;
            this.lblDescricaoDaPeca.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDescricaoDaPeca.Location = new System.Drawing.Point(30, 174);
            this.lblDescricaoDaPeca.Name = "lblDescricaoDaPeca";
            this.lblDescricaoDaPeca.Size = new System.Drawing.Size(55, 21);
            this.lblDescricaoDaPeca.TabIndex = 9;
            this.lblDescricaoDaPeca.Text = "label6";
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(355, 347);
            this.Controls.Add(this.lblDescricaoDaPeca);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.cmbIdentificacaoVendedor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.txtPrecoDaPeca);
            this.Controls.Add(this.txtCodigoDaPeca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComissao";
            this.Text = "Comissão de peças";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigoDaPeca;
        private TextBox txtPrecoDaPeca;
        private TextBox txtQuantidadeVendida;
        private Label label5;
        private Button btnCalcular;
        private ComboBox cmbIdentificacaoVendedor;
        private Button button1;
        private Label lblComissao;
        private Label lblDescricaoDaPeca;
    }
}