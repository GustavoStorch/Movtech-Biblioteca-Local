namespace CadastroLocal
{
    partial class FormCadLocal
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
            this.lblCodLocal = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodLocal = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtgDadosLocal = new System.Windows.Forms.DataGridView();
            this.colCodLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodLocal
            // 
            this.lblCodLocal.AutoSize = true;
            this.lblCodLocal.Location = new System.Drawing.Point(8, 8);
            this.lblCodLocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodLocal.Name = "lblCodLocal";
            this.lblCodLocal.Size = new System.Drawing.Size(43, 13);
            this.lblCodLocal.TabIndex = 1;
            this.lblCodLocal.Text = "Código:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(8, 32);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtCodLocal
            // 
            this.txtCodLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodLocal.Enabled = false;
            this.txtCodLocal.Location = new System.Drawing.Point(69, 5);
            this.txtCodLocal.MaxLength = 3;
            this.txtCodLocal.Name = "txtCodLocal";
            this.txtCodLocal.Size = new System.Drawing.Size(38, 20);
            this.txtCodLocal.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(69, 29);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(475, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(467, 55);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 22);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(384, 55);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 22);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtgDadosLocal
            // 
            this.dtgDadosLocal.AllowUserToAddRows = false;
            this.dtgDadosLocal.AllowUserToDeleteRows = false;
            this.dtgDadosLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodLocal,
            this.colNomeLocal});
            this.dtgDadosLocal.Location = new System.Drawing.Point(11, 82);
            this.dtgDadosLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgDadosLocal.MultiSelect = false;
            this.dtgDadosLocal.Name = "dtgDadosLocal";
            this.dtgDadosLocal.ReadOnly = true;
            this.dtgDadosLocal.RowHeadersWidth = 62;
            this.dtgDadosLocal.RowTemplate.Height = 28;
            this.dtgDadosLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosLocal.Size = new System.Drawing.Size(533, 242);
            this.dtgDadosLocal.TabIndex = 5;
            this.dtgDadosLocal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosLocal_CellDoubleClick);
            // 
            // colCodLocal
            // 
            this.colCodLocal.FillWeight = 50F;
            this.colCodLocal.HeaderText = "Código";
            this.colCodLocal.MinimumWidth = 8;
            this.colCodLocal.Name = "colCodLocal";
            this.colCodLocal.ReadOnly = true;
            // 
            // colNomeLocal
            // 
            this.colNomeLocal.HeaderText = "Local";
            this.colNomeLocal.MinimumWidth = 8;
            this.colNomeLocal.Name = "colNomeLocal";
            this.colNomeLocal.ReadOnly = true;
            // 
            // FormCadLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 327);
            this.Controls.Add(this.dtgDadosLocal);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodLocal);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodLocal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Local";
            this.Load += new System.EventHandler(this.FormCadLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodLocal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodLocal;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtgDadosLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
    }
}

