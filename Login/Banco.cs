using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Login
{
    internal class Banco
    {
        private static MySqlConnection conexao;

        // Funções Genéricas
        private static MySqlConnection ConexaoBanco()
        {
            conexao = new MySqlConnection("server=localhost;uid=root;database=banco_dados");
            conexao.Open();
            return conexao;
        }

        public static DataTable dql(string sql) // Data Query Language (Select)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // ******************************************* Obter Cidades e UF **************************************************
        public static DataTable ObterCidades(string id_cd)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT id_cidade, cidade_descricao, uf FROM cidade WHERE id_cidade=" + id_cd;

                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterUF(int uf)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT uf FROM cidade WHERE id_cidade=" + uf;

                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                Globais.uf = dt.Rows[0].Field<String>("uf").ToString();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // ******************************************* Form Usuarios **************************************************
        public static DataTable ObterTodosUsuarios()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                
                cmd.CommandText = "SELECT * FROM usuario";
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterUsuariosNomeSobrenomeStatusNivel()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT id_usuario as 'ID', nome as 'Nome', sobrenome as 'Sobrenome', status as 'Status', nivel as 'Nível' FROM usuario";
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                Globais.linhasUsuarios = dt.Rows.Count;
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterUltimoUsuario()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "select id_usuario from usuario where id_usuario = (select max(id_usuario) from usuario);";
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                //MessageBox.Show(Convert.ToString(da));
                //Globais.ultimoUsuario = dt.Rows;
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosUsuario(string id)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = @"SELECT usuario.id_usuario, 
                                           usuario.nome, usuario.sobrenome, 
                                           usuario.cpf, usuario.email, 
                                           usuario.cep, usuario.cel, 
                                           usuario.endereco, usuario.bairro, 
                                           cidade.cidade_descricao, cidade.uf,
                                           usuario.status, usuario.nivel, 
                                           usuario.username, usuario.senha 
                                    FROM usuario 
                                    INNER JOIN cidade ON cidade.id_cidade = usuario.cidade_id_cidade WHERE id_usuario="+id;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Funções do FORM Update Usuário
        public static void AtualizarUsuario(Usuario u)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"UPDATE usuario 
                                    SET nome='"+u.nome+"'" +
                                    ", sobrenome='"+u.sobrenome+"'" +
                                    ", cpf='"+u.cpf+"'" +
                                    ", email='"+u.email+"'" +
                                    ", cel='" + u.cel + "'" +
                                    ", cep='" +u.cep+"'" +
                                    ", endereco='"+u.endereco+"'" +
                                    ", bairro='"+u.bairro+"'" +
                                    ", status='"+u.status+"'" +
                                    ", nivel='"+u.nivel+"'" +
                                    ", username='"+u.username+"'" +
                                    ", senha='"+u.senha+"'" +
                                    ", cidade_id_cidade='"+u.cidade+"' WHERE id_usuario="+u.id;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Clone();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // FIM Funções do FORM Update Usuário

        // Funções do FORM Delete Usuário
        public static void DeletarUsuario(String id)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM usuario WHERE id_usuario=" + id;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Clone();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // FIM Funções do FORM Delete Usuário

        // Funções do FORM Cadastro_Usuario
        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO usuario (nome, sobrenome, cpf, email, cep, cel, endereco, bairro, status, nivel, username, senha, cidade_id_cidade) VALUES (@nome, @sobrenome, @cpf, @email, @cep, @cel, @endereco, @bairro, @status, @nivel, @username, @senha, @cidade)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@sobrenome", u.sobrenome);
                cmd.Parameters.AddWithValue("@cpf", u.cpf);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@cep", u.cep);
                cmd.Parameters.AddWithValue("@cel", u.cel);
                cmd.Parameters.AddWithValue("@endereco", u.endereco);
                cmd.Parameters.AddWithValue("@bairro", u.bairro);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@cidade", u.cidade);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuário Inserido");
                vcon.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário");
            }

        }

        // FIM - Funções do FORM Cadastro_Usuario

        // Rotinas Gerais

        public static bool existeUsername(Usuario u)
        {
            bool res;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username FROM usuario WHERE username = '"+u.username+"'";
            da = new MySqlDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0) 
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }

        // ******************************************* Form Fornecedor **************************************************

        public static DataTable ObterFornecedorIdNomeRazaoCidade()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = @"SELECT fornecedor.id_fornecedor as 'ID',
                                           fornecedor.nome_fantasia as 'Nome Fantasia',
                                           fornecedor.razao_social as 'Raão Social',
                                           cidade.cidade_descricao as 'Cidade'
                                    FROM fornecedor
                                    INNER JOIN cidade ON cidade.id_cidade = fornecedor.cidade_id_cidade";
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                Globais.linhasUsuarios = dt.Rows.Count;
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosFornecedor(string id)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                 var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = @"SELECT fornecedor.id_fornecedor, 
                                           fornecedor.cnpj,
                                           fornecedor.nome_fantasia, 
                                           fornecedor.razao_social,
                                           fornecedor.email, 
                                           fornecedor.cel,
                                           fornecedor.cep, 
                                           fornecedor.endereco,
                                           fornecedor.bairro, 
                                           cidade.cidade_descricao,
                                           cidade.uf
                                    FROM fornecedor 
                                    JOIN cidade ON cidade.id_cidade = fornecedor.cidade_id_cidade WHERE id_fornecedor=" + id;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterUltimoFornecedor()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT id_fornecedor from fornecedor where id_fornecedor = (select max(id_fornecedor) from fornecedor);";
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool existeFornecedor(Fornecedor f)
        {
            bool res;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT cnpj FROM fornecedor WHERE cnpj = '" + f.cnpj + "'";
            da = new MySqlDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }

        // Funções do FORM Cadastro_Fornecedor
        public static void NovoFornecedor(Fornecedor f)
        {
            if (existeFornecedor(f))
            {
                MessageBox.Show("Fornecedor já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"INSERT INTO fornecedor 
                                                (cnpj, nome_fantasia, razao_social, email, cel, cep, endereco, bairro, cidade_id_cidade)
                                    VALUES (@cnpj, @nome_fantasia, @razao_social, @email, @cel, @cep, @endereco, @bairro, @cidade)";
                cmd.Parameters.AddWithValue("@cnpj", f.cnpj);
                cmd.Parameters.AddWithValue("@nome_fantasia", f.nome_fantasia);
                cmd.Parameters.AddWithValue("@razao_social", f.razao_social);
                cmd.Parameters.AddWithValue("@email", f.email);
                cmd.Parameters.AddWithValue("@cel", f.cel);
                cmd.Parameters.AddWithValue("@cep", f.cep);
                cmd.Parameters.AddWithValue("@endereco", f.endereco);
                cmd.Parameters.AddWithValue("@bairro", f.bairro);
                cmd.Parameters.AddWithValue("@cidade", f.cidade);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Fornecedor Inserido");
                vcon.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo fornecedor");
            }

        }

        // FIM - Funções do FORM Cadastro_Fornecedor

        // Funções do FORM Update Fornecedor
        public static void AtualizarFornecedor(Fornecedor f)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"UPDATE fornecedor 
                                    SET cnpj='" + f.cnpj + "'" +
                                    ", nome_fantasia='" + f.nome_fantasia + "'" +
                                    ", razao_social='" + f.razao_social + "'" +
                                    ", email='" + f.email + "'" +
                                    ", cel='" + f.cel + "'" +
                                    ", cep='" + f.cep + "'" +
                                    ", endereco='" + f.endereco + "'" +
                                    ", bairro='" + f.bairro + "'" +
                                    ", cidade_id_cidade='" + f.cidade + "' WHERE id_fornecedor=" + f.id;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Clone();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // FIM Funções do FORM Update Fornecedor

        // Funções do FORM Delete Fornecedor
        public static void DeletarFornecedor(String id)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM fornecedor WHERE id_fornecedor=" + id;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Clone();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // FIM Funções do FORM Delete Fornecedor

    }
}
