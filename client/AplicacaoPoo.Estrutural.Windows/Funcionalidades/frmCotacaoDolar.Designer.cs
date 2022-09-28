namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmCotacaoDolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotacaoDolar));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegunddoValor = new System.Windows.Forms.Label();
            this.cmbMoeda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(29, 136);
            this.txtValor.Name = "txtValor";
            this.txtValor.PlaceholderText = "informe o valor";
            this.txtValor.Size = new System.Drawing.Size(115, 25);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(29, 24);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 15);
            this.lblPrimeiroValor.TabIndex = 6;
            // 
            // lblSegunddoValor
            // 
            this.lblSegunddoValor.AutoSize = true;
            this.lblSegunddoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegunddoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegunddoValor.Location = new System.Drawing.Point(24, 56);
            this.lblSegunddoValor.Name = "lblSegunddoValor";
            this.lblSegunddoValor.Size = new System.Drawing.Size(0, 30);
            this.lblSegunddoValor.TabIndex = 7;
            // 
            // cmbMoeda
            // 
            this.cmbMoeda.BackColor = System.Drawing.Color.White;
            this.cmbMoeda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoeda.ForeColor = System.Drawing.Color.Black;
            this.cmbMoeda.FormattingEnabled = true;
            this.cmbMoeda.Location = new System.Drawing.Point(144, 137);
            this.cmbMoeda.Name = "cmbMoeda";
            this.cmbMoeda.Size = new System.Drawing.Size(129, 23);
            this.cmbMoeda.TabIndex = 8;
            this.cmbMoeda.SelectedIndexChanged += new System.EventHandler(this.cmbMoeda_SelectedIndexChanged);
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(348, 250);
            this.Controls.Add(this.cmbMoeda);
            this.Controls.Add(this.lblSegunddoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.txtValor);
            this.Name = "frmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação do Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValor;
        private Label lblPrimeiroValor;
        private Label lblSegunddoValor;
        private ComboBox cmbMoeda;
    }
}