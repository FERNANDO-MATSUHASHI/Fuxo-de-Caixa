using MySql.Data.MySqlClient;
using System.Data;

namespace Login
{
    public partial class Login : Form
    {
        Menu menu;
        DataTable dt = new DataTable();
        public Login(Menu m)
        {
            InitializeComponent();
            menu = m;

            //try
            //{
            //    var strConexao = "server=localhost;uid=root;database=banco_dados";
            //    var conexao = new MySqlConnection(strConexao);
            //    conexao.Open();

            //    var comando = new MySqlCommand("SELECT * FROM usuario", conexao);
            //    var reader = comando.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        MessageBox.Show($"{reader["nome"]} => {reader["status"]}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocorreu um erro: " + ex.Message);
            //}

            //this.menu = menu;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            //var Usuario = textBoxUsuario.Text;
            //var Senha = textBoxSenha.Text;
            //if (Usuario == "admin" && Senha == "admin")
            //{
            //    Menu menuform = new();
            //    menuform.Show();
            //    this.Hide();
            //}
            //else
            //{

            //    labelUsuarioSenhaError.Text = "Usuário e/ou Senha incorretos!!";
            //}
            string username = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário e/ou Senha inválidos!");
                textBoxUsuario.Focus();
                return;
            }

            string sql = "SELECT * FROM usuario WHERE username='" + username + "'AND senha='" + senha + "'";
            dt = Banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                if (Convert.ToString(dt.Rows[0].ItemArray[9]) == "D")
                {
                    MessageBox.Show("Usuário Desligado!");
                    textBoxUsuario.Focus();
                }
                else if (Convert.ToString(dt.Rows[0].ItemArray[9]) == "B")
                {
                    MessageBox.Show("Usuário Bloqueado!");
                    menu.label_Acesso.Text = dt.Rows[0].ItemArray[10].ToString();
                    menu.label_Usuario.Text = dt.Rows[0].Field<string>("nome");
                    menu.pb_ledLogado.Image = Properties.Resources.led_vermelho;
                    Globais.nivel = 0;
                    //Globais.logado = true;
                    this.Close();
                }
                else
                {
                    menu.label_Acesso.Text = dt.Rows[0].ItemArray[10].ToString();
                    menu.label_Usuario.Text = dt.Rows[0].Field<string>("nome");
                    menu.pb_ledLogado.Image = Properties.Resources.led_verde;
                    Globais.nivel = int.Parse(dt.Rows[0].ItemArray[10].ToString());
                    Globais.logado = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
                textBoxUsuario.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}