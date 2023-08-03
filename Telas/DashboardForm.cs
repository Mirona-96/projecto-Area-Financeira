using Financeiro_2.Geral;
using FInanceiro_3._0;
using Financeiro_V3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Financeiro_2.Telas
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Exibir o numero de total de utilizadores que acedem ao sistema
        private void TotalUsers()
        {
            using (SqlConnection con = new SqlConnection(myconnstring))
            {
                string queryString = $"SELECT COUNT(id_utilizador) FROM Utilizadores";

                using (SqlCommand cmd = new SqlCommand(queryString, con))
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    TotalUsersCountLabel.Text = cmd.ExecuteScalar().ToString();
                }
            }
        }

        private void TotalClientes()
        {
            using (SqlConnection con = new SqlConnection(myconnstring))
            {
                string queryString = $"SELECT COUNT(id_cliente) FROM Cliente";

                using (SqlCommand cmd = new SqlCommand(queryString, con))
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    TotalCustomersLabel.Text = cmd.ExecuteScalar().ToString();
                }
            }
        }

        private void TotalEmprestimos()
        {
            using (SqlConnection con = new SqlConnection(myconnstring))
            {
                string queryString = $"SELECT COUNT(id_emprestimo) FROM Emprestimos";

                using (SqlCommand cmd = new SqlCommand(queryString, con))
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    SumEmprestimosLabel.Text = cmd.ExecuteScalar().ToString();
                }
            }
        }

        //Verificar no nivel do utilizador, caso for User ira desabilitar a interface da Gestao de Utilizador
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (Db_connection.UserType == "A")
            {
                UserTypeLabel.Text = "Admin";
            }
            else if (Db_connection.UserType == "U")
            {
                utlizadoresToolStripMenuItem.Enabled = false;
                UsersButton.Enabled = false;
                UserTypeLabel.Text = "User";
            }
            TotalUsers();

            TotalClientes();

            TotalEmprestimos();
        }

        //Logout
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void utlizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  new About().ShowDialog();*/
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClientRegistrationForm().Show();
        }

        private void emprestimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoanRegistrationForm().Show();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PagamentoForm().Show();
        }
    }
}
