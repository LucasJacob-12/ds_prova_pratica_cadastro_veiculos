namespace GerenciadorVeiculos
{
    partial class Form1
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecoBase = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(61, 109);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(176, 20);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.Text = "Insira o modelo";
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(61, 159);
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Size = new System.Drawing.Size(176, 20);
            this.txtPrecoBase.TabIndex = 1;
            this.txtPrecoBase.Text = "Insira o preço base";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.cmbTipo.Location = new System.Drawing.Point(64, 61);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(173, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(61, 215);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(176, 20);
            this.txtParametro.TabIndex = 3;
            this.txtParametro.Text = "Insira o parâmetro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(64, 273);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 39);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar Veículo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecione o tipo do veículo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtPrecoBase);
            this.Controls.Add(this.txtModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPrecoBase;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
    }
}

