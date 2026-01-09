namespace Presentation
{
    partial class Principal
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
            this.btnTestar = new System.Windows.Forms.Button();
            this.txtStringConexao = new System.Windows.Forms.TextBox();
            this.cboAmbiente = new System.Windows.Forms.ComboBox();
            this.txtQtdRegistro = new System.Windows.Forms.NumericUpDown();
            this.lblTituloStringConexao = new System.Windows.Forms.Label();
            this.lblTituloQuantidadeRegistros = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(555, 58);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(215, 37);
            this.btnTestar.TabIndex = 0;
            this.btnTestar.Text = "Executar Testes";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // txtStringConexao
            // 
            this.txtStringConexao.Location = new System.Drawing.Point(12, 25);
            this.txtStringConexao.Name = "txtStringConexao";
            this.txtStringConexao.Size = new System.Drawing.Size(758, 20);
            this.txtStringConexao.TabIndex = 1;
            // 
            // cboAmbiente
            // 
            this.cboAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAmbiente.FormattingEnabled = true;
            this.cboAmbiente.Location = new System.Drawing.Point(12, 74);
            this.cboAmbiente.Name = "cboAmbiente";
            this.cboAmbiente.Size = new System.Drawing.Size(140, 21);
            this.cboAmbiente.TabIndex = 2;
            this.cboAmbiente.SelectedValueChanged += new System.EventHandler(this.cboAmbiente_SelectedValueChanged);
            // 
            // txtQtdRegistro
            // 
            this.txtQtdRegistro.Location = new System.Drawing.Point(176, 75);
            this.txtQtdRegistro.Name = "txtQtdRegistro";
            this.txtQtdRegistro.Size = new System.Drawing.Size(120, 20);
            this.txtQtdRegistro.TabIndex = 3;
            // 
            // lblTituloStringConexao
            // 
            this.lblTituloStringConexao.AutoSize = true;
            this.lblTituloStringConexao.Location = new System.Drawing.Point(12, 9);
            this.lblTituloStringConexao.Name = "lblTituloStringConexao";
            this.lblTituloStringConexao.Size = new System.Drawing.Size(140, 13);
            this.lblTituloStringConexao.TabIndex = 5;
            this.lblTituloStringConexao.Text = "StringConexao - SQL Server";
            // 
            // lblTituloQuantidadeRegistros
            // 
            this.lblTituloQuantidadeRegistros.AutoSize = true;
            this.lblTituloQuantidadeRegistros.Location = new System.Drawing.Point(176, 59);
            this.lblTituloQuantidadeRegistros.Name = "lblTituloQuantidadeRegistros";
            this.lblTituloQuantidadeRegistros.Size = new System.Drawing.Size(109, 13);
            this.lblTituloQuantidadeRegistros.TabIndex = 7;
            this.lblTituloQuantidadeRegistros.Text = "Quantidade Registros";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 58);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Ambiente";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 159);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status: ";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 181);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTituloQuantidadeRegistros);
            this.Controls.Add(this.lblTituloStringConexao);
            this.Controls.Add(this.txtQtdRegistro);
            this.Controls.Add(this.cboAmbiente);
            this.Controls.Add(this.txtStringConexao);
            this.Controls.Add(this.btnTestar);
            this.Name = "Principal";
            this.Text = "Performance Test";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.TextBox txtStringConexao;
        private System.Windows.Forms.ComboBox cboAmbiente;
        private System.Windows.Forms.NumericUpDown txtQtdRegistro;
        private System.Windows.Forms.Label lblTituloStringConexao;
        private System.Windows.Forms.Label lblTituloQuantidadeRegistros;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblStatus;
    }
}

