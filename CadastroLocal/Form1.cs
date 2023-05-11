using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroLocal
{
    public partial class FormCadLocal : Form
    {
        public FormCadLocal()
        {
            InitializeComponent();
        }

        private void FormCadLocal_Load(object sender, EventArgs e)
        {
            InitializeTable();
            CarregaID();
            btnExcluir.Enabled = false;
        }

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodLocal.Text) || string.IsNullOrWhiteSpace(txtCodLocal.Text))
            {
                MessageBox.Show("Informe o campo do Código do local");
                return;
            }
            else if (string.IsNullOrEmpty(txtDescricao.Text) || string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe o campo da descrição do local");
                return;
            }

            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    LocalDAO dao = new LocalDAO(connection);

                    int count = dao.VerificaRegistros(new LocalModel()
                    {
                        CodLocal = txtCodLocal.Text
                    });

                    if (count > 0)
                    {
                        dao.Editar(new LocalModel()
                        {
                            CodLocal = txtCodLocal.Text,
                            NomeLocal = txtDescricao.Text
                        });
                        MessageBox.Show("Local Atualizado com sucesso!");
                    }
                    else
                    {
                        dao.Salvar(new LocalModel()
                        {
                            CodLocal = txtCodLocal.Text,
                            NomeLocal = txtDescricao.Text
                        });
                        MessageBox.Show("Local salvo com sucesso!");
                    } 
                }
                InitializeTable();
                limparForm();
                CarregaID();
                btnExcluir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar o local!\n{ex.Message}");
            }
        }

        //Botão que realiza o Delete de um registro no banco de dados.
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Escolha o local!");
                return;
            }

            DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir o local?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (conf == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        LocalDAO dao = new LocalDAO(connection);
                        dao.Excluir(new LocalModel()
                        {
                            CodLocal = txtCodLocal.Text
                        });
                    }
                    MessageBox.Show("Local excluído com sucesso!");
                    InitializeTable();
                    limparForm();
                    CarregaID();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir a editora!\n{ex.Message}");
            }
        }

        //Método que limpa o formulário toda vez que é salvo ou deletado um registro.
        public void limparForm()
        {
            txtCodLocal.Text = String.Empty;
            txtDescricao.Text = String.Empty;
        }

        //Carrega todos os registros contidos no banco de dados para a DataGridView.
        private void InitializeTable()
        {
            dtgDadosLocal.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LocalDAO dao = new LocalDAO(connection);
                List<LocalModel> locais = dao.GetLocais();
                foreach (LocalModel local in locais)
                {
                    DataGridViewRow row = dtgDadosLocal.Rows[dtgDadosLocal.Rows.Add()];
                    row.Cells[colCodLocal.Index].Value = local.CodLocal;
                    row.Cells[colNomeLocal.Index].Value = local.NomeLocal;
                }
            }
        }

        //Recupera o próximo id a ser cadastrado e joga ele para o textBox.
        private void CarregaID()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('mvtBibLocal') + 1", connection);
                int nextCod = Convert.ToInt32(command.ExecuteScalar());

                txtCodLocal.Text = nextCod.ToString();
            }
        }

        //Método que realiza o double click em uma linha da grid e joga todos os seus dados para as textBox.
        private void dtgDadosLocal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodLocal.Text = dtgDadosLocal.Rows[e.RowIndex].Cells[colCodLocal.Index].Value + "";
                txtDescricao.Text = dtgDadosLocal.Rows[e.RowIndex].Cells[colNomeLocal.Index].Value + "";

                if (string.IsNullOrEmpty(this.txtDescricao.Text))
                {
                    btnExcluir.Enabled = false;
                    CarregaID();
                }
                else
                {
                    btnExcluir.Enabled = true;
                }
            }
        }
    }
}
