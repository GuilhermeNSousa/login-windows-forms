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

namespace TelaLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private SqlConnection AbrirConexao()
        {
            return new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=Testes;Trusted_Connection=True;");
        }

        private bool validaLogin()
        {
            using (var conn = AbrirConexao())
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    configuraParametros(comm, "@Username", "@Password");
                    comm.CommandText = "SELECT User, Password FROM Users WHERE Username = @Username AND Password = @Password";

                    SqlDataReader reader = comm.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);

                    if(table.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void configuraParametros(IDbCommand comm, string username, string password)
        {
            string user = usernameBox.Text;
            string pwd = passwordBox.Text;

            comm.Parameters.Add(new SqlParameter(username, user));
            comm.Parameters.Add(new SqlParameter(password, pwd));
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            if (validaLogin())
            {
                this.Hide();
                Painel painel = new Painel();
                painel.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha incorretos! Tente Novamente!", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                usernameBox.Text = "";
                passwordBox.Text = "";
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }
    }
}
