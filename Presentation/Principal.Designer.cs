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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastroString = new System.Windows.Forms.Button();
            this.dtgPrincipal = new System.Windows.Forms.DataGridView();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantidadeRegistros = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidadeRegistros = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.colPK_Parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConexao = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnCadastroString.TabIndex = 2;
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
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dtgPrincipal.ColumnHeadersHeight = 30;
            this.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPK_Parametro,
            this.colCheck,
            this.colDescricao,
            this.colConexao});
            this.dtgPrincipal.Location = new System.Drawing.Point(12, 12);
            this.dtgPrincipal.Name = "dtgPrincipal";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dtgPrincipal.RowHeadersVisible = false;
            this.dtgPrincipal.RowHeadersWidth = 60;
            this.dtgPrincipal.Size = new System.Drawing.Size(760, 132);
            this.dtgPrincipal.TabIndex = 1;
            this.dtgPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPrincipal_CellContentClick);
            this.dtgPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgPrincipal_DataBindingComplete);
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBenchmark.Location = new System.Drawing.Point(622, 151);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(150, 46);
            this.btnBenchmark.TabIndex = 4;
            this.btnBenchmark.Text = "Iniciar Benchmark";
            this.btnBenchmark.UseVisualStyleBackColor = true;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            // 
            // dtgResultado
            // 
            this.dtgResultado.AllowUserToAddRows = false;
            this.dtgResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dtgResultado.ColumnHeadersHeight = 30;
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtgResultado.Location = new System.Drawing.Point(12, 203);
            this.dtgResultado.Name = "dtgResultado";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dtgResultado.RowHeadersVisible = false;
            this.dtgResultado.RowHeadersWidth = 60;
            this.dtgResultado.Size = new System.Drawing.Size(760, 301);
            this.dtgResultado.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_Parametro";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.Format = "N0";
            dataGridViewCellStyle41.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle41;
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
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Format = "N0";
            dataGridViewCellStyle42.NullValue = false;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle42;
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
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridViewTextBoxColumn2.HeaderText = "Conexão";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txtQuantidadeRegistros
            // 
            this.txtQuantidadeRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeRegistros.Location = new System.Drawing.Point(487, 177);
            this.txtQuantidadeRegistros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidadeRegistros.Name = "txtQuantidadeRegistros";
            this.txtQuantidadeRegistros.Size = new System.Drawing.Size(120, 20);
            this.txtQuantidadeRegistros.TabIndex = 3;
            this.txtQuantidadeRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidadeRegistros.Value = new decimal(new int[] {
            1,
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
            // colPK_Parametro
            // 
            this.colPK_Parametro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPK_Parametro.DataPropertyName = "PK_Parametro";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.Format = "N0";
            dataGridViewCellStyle35.NullValue = null;
            this.colPK_Parametro.DefaultCellStyle = dataGridViewCellStyle35;
            this.colPK_Parametro.HeaderText = "PK_Parametro";
            this.colPK_Parametro.MinimumWidth = 80;
            this.colPK_Parametro.Name = "colPK_Parametro";
            this.colPK_Parametro.ReadOnly = true;
            this.colPK_Parametro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPK_Parametro.Visible = false;
            this.colPK_Parametro.Width = 80;
            // 
            // colCheck
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.NullValue = "False";
            this.colCheck.DefaultCellStyle = dataGridViewCellStyle36;
            this.colCheck.FalseValue = "0";
            this.colCheck.HeaderText = "Teste";
            this.colCheck.MinimumWidth = 50;
            this.colCheck.Name = "colCheck";
            this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCheck.TrueValue = "1";
            this.colCheck.Width = 50;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDescricao.DefaultCellStyle = dataGridViewCellStyle37;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.MinimumWidth = 200;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescricao.Width = 200;
            // 
            // colConexao
            // 
            this.colConexao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colConexao.DataPropertyName = "Conexao";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colConexao.DefaultCellStyle = dataGridViewCellStyle38;
            this.colConexao.HeaderText = "Conexão";
            this.colConexao.Name = "colConexao";
            this.colConexao.ReadOnly = true;
            this.colConexao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroString;
        private System.Windows.Forms.DataGridView dtgPrincipal;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.NumericUpDown txtQuantidadeRegistros;
        private System.Windows.Forms.Label lblQuantidadeRegistros;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_Parametro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConexao;
    }
}

