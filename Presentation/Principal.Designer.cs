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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastroString = new System.Windows.Forms.Button();
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.colPK_Parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colConexao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantidadeRegistros = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidadeRegistros = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastroString
            // 
            this.btnCadastroString.Location = new System.Drawing.Point(12, 151);
            this.btnCadastroString.Name = "btnCadastroString";
            this.btnCadastroString.Size = new System.Drawing.Size(150, 46);
            this.btnCadastroString.TabIndex = 0;
            this.btnCadastroString.Text = "Cadastrar String Conexão";
            this.btnCadastroString.UseVisualStyleBackColor = true;
            this.btnCadastroString.Click += new System.EventHandler(this.btnCadastroString_Click);
            // 
            // dtgPrincipal
            // 
            this.dtgPrincipal.AllowUserToAddRows = false;
            this.dtgPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPrincipal.ColumnHeadersHeight = 30;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPK_Parametro,
            this.colTestar,
            this.colConexao});
            this.dtgPrincipal.Location = new System.Drawing.Point(12, 12);
            this.dtgPrincipal.Name = "dtgPrincipal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgPrincipal.RowHeadersVisible = false;
            this.dtgPrincipal.RowHeadersWidth = 60;
            this.dtgPrincipal.Size = new System.Drawing.Size(760, 132);
            this.dtgPrincipal.TabIndex = 8;
            // 
            // colPK_Parametro
            // 
            this.colPK_Parametro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPK_Parametro.DataPropertyName = "PK_Parametro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colPK_Parametro.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPK_Parametro.HeaderText = "PK_Parametro";
            this.colPK_Parametro.MinimumWidth = 80;
            this.colPK_Parametro.Name = "colPK_Parametro";
            this.colPK_Parametro.ReadOnly = true;
            this.colPK_Parametro.Visible = false;
            this.colPK_Parametro.Width = 80;
            // 
            // colTestar
            // 
            this.colTestar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTestar.DataPropertyName = "Testar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = false;
            this.colTestar.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTestar.HeaderText = "Testar";
            this.colTestar.MinimumWidth = 50;
            this.colTestar.Name = "colTestar";
            this.colTestar.ReadOnly = true;
            this.colTestar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTestar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTestar.Width = 50;
            // 
            // colConexao
            // 
            this.colConexao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colConexao.DataPropertyName = "Conexao";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colConexao.DefaultCellStyle = dataGridViewCellStyle4;
            this.colConexao.HeaderText = "Conexão";
            this.colConexao.Name = "colConexao";
            this.colConexao.ReadOnly = true;
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBenchmark.Location = new System.Drawing.Point(622, 151);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(150, 46);
            this.btnBenchmark.TabIndex = 9;
            this.btnBenchmark.Text = "Iniciar Benchmark";
            this.btnBenchmark.UseVisualStyleBackColor = true;
            // 
            // dtgResultado
            // 
            this.dtgResultado.AllowUserToAddRows = false;
            this.dtgResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgResultado.ColumnHeadersHeight = 30;
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtgResultado.Location = new System.Drawing.Point(12, 203);
            this.dtgResultado.Name = "dtgResultado";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgResultado.RowHeadersVisible = false;
            this.dtgResultado.RowHeadersWidth = 60;
            this.dtgResultado.Size = new System.Drawing.Size(760, 301);
            this.dtgResultado.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_Parametro";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "PK_Parametro";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Testar";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = false;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Testar";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 50;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Conexao";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "Conexão";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txtQuantidadeRegistros
            // 
            this.txtQuantidadeRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeRegistros.Location = new System.Drawing.Point(487, 177);
            this.txtQuantidadeRegistros.Name = "txtQuantidadeRegistros";
            this.txtQuantidadeRegistros.Size = new System.Drawing.Size(120, 20);
            this.txtQuantidadeRegistros.TabIndex = 11;
            this.txtQuantidadeRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidadeRegistros.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblQuantidadeRegistros
            // 
            this.lblQuantidadeRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantidadeRegistros.AutoSize = true;
            this.lblQuantidadeRegistros.Location = new System.Drawing.Point(484, 161);
            this.lblQuantidadeRegistros.Name = "lblQuantidadeRegistros";
            this.lblQuantidadeRegistros.Size = new System.Drawing.Size(109, 13);
            this.lblQuantidadeRegistros.TabIndex = 12;
            this.lblQuantidadeRegistros.Text = "Quantidade Registros";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 509);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Quantidade: 0";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 529);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblQuantidadeRegistros);
            this.Controls.Add(this.txtQuantidadeRegistros);
            this.Controls.Add(this.dtgResultado);
            this.Controls.Add(this.btnBenchmark);
            this.Controls.Add(this.dtgPrincipal);
            this.Controls.Add(this.btnCadastroString);
            this.Name = "Principal";
            this.Text = "Performance Test";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroString;
        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_Parametro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTestar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConexao;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.NumericUpDown txtQuantidadeRegistros;
        private System.Windows.Forms.Label lblQuantidadeRegistros;
        private System.Windows.Forms.Label lblStatus;
    }
}

