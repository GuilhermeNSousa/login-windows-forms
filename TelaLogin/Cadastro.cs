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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private SqlConnection AbrirConexao()
        {
            return new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=Testes;Trusted_Connection=True;");
        }

        private void voltarBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void cadastrarBut_Click(object sender, EventArgs e)
        {
            using (var conn = AbrirConexao())
            {
                conn.Open();
                using(var comm = conn.CreateCommand())
                {
                    configuraParametros(comm, "@Username", "@Password");
                    comm.CommandText = "INSERT INTO Users VALUES (@Username, @Password)";
                    SqlDataReader reader = comm.ExecuteReader();

                    this.Hide();
                    Login login = new Login();
                    login.Show();
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

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
