using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Login
{
    public partial class Gestao_Usuario : Form
    {
        public Gestao_Usuario()
        {
            InitializeComponent();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSlavar_Click_1(object sender, EventArgs e)
        {
            // Novo Usuário
            int linha = dgvUsuarios.SelectedRows[0].Index;

            if (textBoxID.Text != Convert.ToString(linha + 1))//Convert.ToString(Globais.linhasUsuarios))
            {
                Usuario u = new Usuario();
                u.id = Convert.ToInt32(textBoxID.Text);
                u.nome = textBoxNome.Text;
                u.sobrenome = textBoxSobrenome.Text;
                u.cpf = textBoxCPF.Text;
                u.email = textBoxEMail.Text;
                u.cep = textBoxCEP.Text;
                u.cel = textBoxCel.Text;
                u.endereco = textBoxEndereco.Text;
                u.bairro = textBoxBairro.Text;
                u.status = cb_Status.Text;
                u.nivel = Convert.ToInt32(Math.Round(numericUpDownNivel.Value, 0));
                u.username = textBoxUsuario.Text;
                u.senha = textBoxSenha.Text;
                int id_cd = cb_Cidade.SelectedIndex;
                u.cidade = (id_cd + 1);
                Banco.NovoUsuario(u);
                dgvUsuarios.DataSource = Banco.ObterUsuariosNomeSobrenomeStatusNivel();
                //dgvUsuarios.CurrentCell = dgvUsuarios[0, linha];
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    Usuario u = new Usuario();
                    u.id = Convert.ToInt32(textBoxID.Text);
                    u.nome = textBoxNome.Text;
                    u.sobrenome = textBoxSobrenome.Text;
                    u.cpf = textBoxCPF.Text;
                    u.email = textBoxEMail.Text;
                    u.cep = textBoxCEP.Text;
                    u.cel = textBoxCel.Text;
                    u.endereco = textBoxEndereco.Text;
                    u.bairro = textBoxBairro.Text;
                    u.status = cb_Status.Text;
                    u.nivel = Convert.ToInt32(Math.Round(numericUpDownNivel.Value, 0));
                    u.username = textBoxUsuario.Text;
                    u.senha = textBoxSenha.Text;
                    int id_cd = cb_Cidade.SelectedIndex;
                    u.cidade = (id_cd + 1);
                    Banco.AtualizarUsuario(u);
                    dgvUsuarios.DataSource = Banco.ObterUsuariosNomeSobrenomeStatusNivel();
                    dgvUsuarios.CurrentCell = dgvUsuarios[0, linha];
                    //Confirmando exclusão para o usuário
                    MessageBox.Show("Registro alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void Gestao_Usuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Banco.ObterUsuariosNomeSobrenomeStatusNivel();
            dgvUsuarios.Columns[0].Width = 30;
            dgvUsuarios.Columns[1].Width = 200;
            dgvUsuarios.Columns[2].Width = 200;
            dgvUsuarios.Columns[3].Width = 50;
            dgvUsuarios.Columns[4].Width = 50;

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
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Banco.ObterDadosUsuario(vid);
                dt = Banco.ObterDadosUsuario(vid);
                textBoxID.Text = dt.Rows[0].Field<Int32>("id_usuario").ToString();
                textBoxNome.Text = dt.Rows[0].Field<String>("nome").ToString();
                textBoxSobrenome.Text = dt.Rows[0].Field<String>("sobrenome").ToString();
                textBoxCPF.Text = dt.Rows[0].Field<String>("cpf").ToString();
                textBoxEMail.Text = dt.Rows[0].Field<String>("email").ToString();
                textBoxCEP.Text = dt.Rows[0].Field<String>("cep").ToString();
                textBoxCel.Text = dt.Rows[0].Field<String>("cel").ToString();
                textBoxEndereco.Text = dt.Rows[0].Field<String>("endereco").ToString();
                textBoxBairro.Text = dt.Rows[0].Field<String>("bairro").ToString();
                cb_Cidade.Text = dt.Rows[0].Field<String>("cidade_descricao").ToString();
                textBoxUF.Text = dt.Rows[0].Field<String>("uf").ToString();
                cb_Status.Text = dt.Rows[0].Field<String>("status").ToString();
                numericUpDownNivel.Value = dt.Rows[0].Field<Int32>("nivel");
                textBoxUsuario.Text = dt.Rows[0].Field<String>("username").ToString();
                textBoxSenha.Text = dt.Rows[0].Field<String>("senha").ToString();
                Globais.cidade = dt.Rows[0].Field<String>("cidade_descricao").ToString();
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

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Banco.ObterUltimoUsuario();
            textBoxID.Text = (dt.Rows[0].Field<Int32>("id_usuario") + 1).ToString();
            textBoxNome.Text = "";
            textBoxSobrenome.Text = "";
            textBoxCPF.Text = "";
            textBoxEMail.Text = "";
            textBoxCEP.Text = "";
            textBoxCel.Text = "";
            textBoxEndereco.Text = "";
            textBoxBairro.Text = "";
            cb_Status.Text = "";
            numericUpDownNivel.Value = 0;
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxNome.Focus();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja deletar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Banco.DeletarUsuario(textBoxID.Text);
                dgvUsuarios.Rows.Remove(dgvUsuarios.CurrentRow);

                //Confirmando exclusão para o usuário
                MessageBox.Show("Registro deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
