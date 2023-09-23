using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Gestao_Fornecedor : Form
    {
        public Gestao_Fornecedor()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gestao_Fornecedor_Load(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = Banco.ObterFornecedorIdNomeRazaoCidade();
            dgvFornecedor.Columns[0].Width = 30;
            dgvFornecedor.Columns[1].Width = 150;
            dgvFornecedor.Columns[2].Width = 250;
            dgvFornecedor.Columns[3].Width = 250;


            // Popular ComboBox Cidades

            string vqueryCidades = @"
                    SELECT 
                        id_cidade,
                        cidade_descricao,
                        uf
                    FROM
                        cidade
                    ORDER BY
                        cidade_descricao
            ";
            //cb_Cidade.Items.Clear();
            cb_Cidade.DataSource = Banco.dql(vqueryCidades);
            cb_Cidade.DisplayMember = "cidade_descricao";
            cb_Cidade.ValueMember = "id_cidade";
            cb_Cidade.Text = Globais.cidade;
        }

        private void dgvFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhasFornecedor = dgv.SelectedRows.Count;
            if (contlinhasFornecedor > 0)
            {
                DataTable dt = new DataTable();
                string fId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Banco.ObterDadosFornecedor(fId);
                dt = Banco.ObterDadosFornecedor(fId);
                textBoxID.Text = dt.Rows[0].Field<Int32>("id_fornecedor").ToString();
                textBoxCNPJ.Text = dt.Rows[0].Field<String>("cnpj").ToString();
                textBoxNomeFantasia.Text = dt.Rows[0].Field<String>("nome_fantasia").ToString();
                textBoxRazaoSocial.Text = dt.Rows[0].Field<String>("razao_social").ToString();
                textBoxEMail.Text = dt.Rows[0].Field<String>("email").ToString();
                textBoxCEP.Text = dt.Rows[0].Field<String>("cep").ToString();
                textBoxCel.Text = dt.Rows[0].Field<String>("cel").ToString();
                textBoxEndereco.Text = dt.Rows[0].Field<String>("endereco").ToString();
                textBoxBairro.Text = dt.Rows[0].Field<String>("bairro").ToString();
                cb_Cidade.Text = dt.Rows[0].Field<String>("cidade_descricao").ToString();
                textBoxUF.Text = dt.Rows[0].Field<String>("uf").ToString();
                Globais.cidade = dt.Rows[0].Field<String>("cidade_descricao").ToString();
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Banco.ObterUltimoFornecedor();
            textBoxID.Text = (dt.Rows[0].Field<Int32>("id_fornecedor") + 1).ToString();
            textBoxCNPJ.Text = "";
            textBoxNomeFantasia.Text = "";
            textBoxRazaoSocial.Text = "";
            textBoxEMail.Text = "";
            textBoxCel.Text = "";
            textBoxCEP.Text = "";
            textBoxEndereco.Text = "";
            textBoxBairro.Text = "";
            textBoxCNPJ.Focus();
        }

        private void buttonSlavar_Click(object sender, EventArgs e)
        {
            // Novo Fornecedor
            int linha = dgvFornecedor.SelectedRows[0].Index;

            if (textBoxID.Text != Convert.ToString(linha + 1)) //Convert.ToString(Globais.linhasUsuarios))
            {
                Fornecedor f = new Fornecedor();
                f.id = Convert.ToInt32(textBoxID.Text);
                f.cnpj = textBoxCNPJ.Text;
                f.nome_fantasia = textBoxNomeFantasia.Text;
                f.razao_social = textBoxRazaoSocial.Text;
                f.email = textBoxEMail.Text;
                f.cel = textBoxCel.Text;
                f.cep = textBoxCEP.Text;
                f.endereco = textBoxEndereco.Text;
                f.bairro = textBoxBairro.Text;
                int id_cd = cb_Cidade.SelectedIndex;
                f.cidade = (id_cd + 1);
                Banco.NovoFornecedor(f);
                dgvFornecedor.DataSource = Banco.ObterFornecedorIdNomeRazaoCidade();
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    Fornecedor f = new Fornecedor();
                    f.id = Convert.ToInt32(textBoxID.Text);
                    f.cnpj = textBoxCNPJ.Text;
                    f.nome_fantasia = textBoxNomeFantasia.Text;
                    f.razao_social = textBoxRazaoSocial.Text;
                    f.email = textBoxEMail.Text;
                    f.cel = textBoxCel.Text;
                    f.cep = textBoxCEP.Text;
                    f.endereco = textBoxEndereco.Text;
                    f.bairro = textBoxBairro.Text;
                    int id_cd = cb_Cidade.SelectedIndex;
                    f.cidade = (id_cd + 1);
                    Banco.AtualizarFornecedor(f);
                    dgvFornecedor.DataSource = Banco.ObterUsuariosNomeSobrenomeStatusNivel();
                    dgvFornecedor.CurrentCell = dgvFornecedor[0, linha];

                    //Confirmando exclusão para o Fornecedor
                    MessageBox.Show("Registro alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja deletar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Banco.DeletarFornecedor(textBoxID.Text);
                dgvFornecedor.Rows.Remove(dgvFornecedor.CurrentRow);

                //Confirmando exclusão para o fornecedor
                MessageBox.Show("Registro deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cb_Cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            int id_cd = cb_Cidade.SelectedIndex;
            cb_Cidade.SelectedIndex = id_cd;
            Banco.ObterCidades(Convert.ToString(id_cd));
            dt = Banco.ObterCidades(Convert.ToString(id_cd));

            int var = id_cd + 1;
            var uf = Banco.ObterUF(var).ToString();
            textBoxUF.Text = Globais.uf;
        }
    }
}
