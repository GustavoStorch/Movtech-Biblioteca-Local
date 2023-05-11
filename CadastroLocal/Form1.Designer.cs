namespace CadastroLocal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCadLocal = new System.Windows.Forms.Label();
            this.lblCodLocal = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodLocal = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gridCadLocal = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCadLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadLocal
            // 
            this.lblCadLocal.AutoSize = true;
            this.lblCadLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadLocal.Location = new System.Drawing.Point(501, 41);
            this.lblCadLocal.Name = "lblCadLocal";
            this.lblCadLocal.Size = new System.Drawing.Size(215, 36);
            this.lblCadLocal.TabIndex = 0;
            this.lblCadLocal.Text = "Cadastro Local";
            // 
            // lblCodLocal
            // 
            this.lblCodLocal.AutoSize = true;
            this.lblCodLocal.Location = new System.Drawing.Point(128, 145);
            this.lblCodLocal.Name = "lblCodLocal";
            this.lblCodLocal.Size = new System.Drawing.Size(63, 20);
            this.lblCodLocal.TabIndex = 1;
            this.lblCodLocal.Text = "Código:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(128, 223);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodLocal
            // 
            this.txtCodLocal.Enabled = false;
            this.txtCodLocal.Location = new System.Drawing.Point(288, 142);
            this.txtCodLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodLocal.MaxLength = 3;
            this.txtCodLocal.Name = "txtCodLocal";
            this.txtCodLocal.Size = new System.Drawing.Size(205, 26);
            this.txtCodLocal.TabIndex = 4;
            this.txtCodLocal.TextChanged += new System.EventHandler(this.txtCodLocal_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(288, 220);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(796, 26);
            this.txtDescricao.TabIndex = 5;
            // 
            // gridCadLocal
            // 
            this.gridCadLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCadLocal.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCadLocal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCadLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCadLocal.Location = new System.Drawing.Point(132, 374);
            this.gridCadLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridCadLocal.Name = "gridCadLocal";
            this.gridCadLocal.RowHeadersWidth = 62;
            this.gridCadLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCadLocal.Size = new System.Drawing.Size(952, 309);
            this.gridCadLocal.TabIndex = 10;
            this.gridCadLocal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCadLocal_MouseDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(679, 288);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(176, 57);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(349, 288);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 57);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 710);
            this.Controls.Add(this.gridCadLocal);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodLocal);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodLocal);
            this.Controls.Add(this.lblCadLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Novo Local";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCadLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadLocal;
        private System.Windows.Forms.Label lblCodLocal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodLocal;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView gridCadLocal;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}

