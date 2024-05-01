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
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
            carregaGrid();
        }
        private SqlConnection AbrirConexao()
        {
            return new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=Testes;Trusted_Connection=True;");
        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }        

        private void carregaGrid()
        {
            using (var conn = AbrirConexao())
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = "SELECT * FROM Funcionarios";
                    SqlDataReader reader = comm.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);    
                    
                    funcionariosGrid.DataSource = table;
                }
            }
        }

        private void voltarBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Painel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
