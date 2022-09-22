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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmbIdentificacaoVendedor = new System.Windows.Forms.ComboBox();
            this.lbxComissao = new System.Windows.Forms.ListBox();
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
            this.label5.Location = new System.Drawing.Point(21, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comissão :";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(21, 177);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SpringGreen;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(143, 281);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 5;
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
            // lbxComissao
            // 
            this.lbxComissao.FormattingEnabled = true;
            this.lbxComissao.ItemHeight = 15;
            this.lbxComissao.Location = new System.Drawing.Point(110, 154);
            this.lbxComissao.Name = "lbxComissao";
            this.lbxComissao.Size = new System.Drawing.Size(339, 169);
            this.lbxComissao.TabIndex = 7;
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(470, 334);
            this.Controls.Add(this.lbxComissao);
            this.Controls.Add(this.cmbIdentificacaoVendedor);
            this.Controls.Add(this.textBox5);
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
        private TextBox textBox5;
        private ComboBox cmbIdentificacaoVendedor;
        private ListBox lbxComissao;
    }
}