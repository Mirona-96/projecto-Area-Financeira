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
using Financeiro_2.Geral;

namespace Financeiro_2.Telas
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        public int id_utilizador = 0;

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        //Inserir usuario na base de dados
        private void SaveUserButton_Click(object sender, EventArgs e)
        {

            if (isFormValid())
            {
                using (SqlConnection con = new SqlConnection(Db_connection.connectionString))
                {
                    string queryString = string.Empty;

                    if (id_utilizador == 0)
                    {
                        if (AdminRadioButton.Checked)
                        {
                            queryString = $"INSERT INTO Utilizadores (nome, palavra_passe, tipo, data_registo) VALUES ('{UsernameTextBox.Text.Trim()}', '{UserPasswordTextBox.Text}', '{AdminRadioButton.Text}', GETDATE())";
                        }
                        else if (UserRadioButton.Checked)
                        {
                            queryString = $"INSERT INTO Utilizadores (nome, palavra_passe, tipo, data_registo) VALUES ('{UsernameTextBox.Text.Trim()}', '{UserPasswordTextBox.Text}', '{UserRadioButton.Text}', GETDATE())";
                        }

                        using (SqlCommand cmd = new SqlCommand(queryString, con))
                        {
                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Utilizador registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            resetFormControls();
                        }
                    }
                }
            }
        }

        //Limpar todos campos
        private void  resetFormControls()
        {
            UsernameTextBox.Clear();
            UserPasswordTextBox.Clear();
            AdminRadioButton.Checked = false;
            UserRadioButton.Checked = false;
            UsernameTextBox.Focus();
            DeleteUserButton.Enabled = false;
            SaveUserButton.Text = "Gravar";

            LoadDataIntoDataGridView();
        }

        // Verificar se os campos foram preenchidos
        private bool isFormValid()
        {
            if (UsernameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, insira nome do utilizador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameTextBox.Focus();
                return false;
            }

            if (UserPasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, insira a palavra-passe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserPasswordTextBox.Focus();
                return false;
            }

            if (!AdminRadioButton.Checked && !UserRadioButton.Checked)
            {
                MessageBox.Show("Por favor, escolha a permissao do utilizador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Verificar se o ser ja foi registado

            if (this.id_utilizador == 0)
            {
                using (SqlConnection con = new SqlConnection(myconnstring))
                {
                    string queryString = $"SELECT * FROM Utilizadores WHERE nome = '{UsernameTextBox.Text.Trim()}'";

                    using (SqlCommand cmd = new SqlCommand(queryString, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.HasRows)
                        {
                            MessageBox.Show("Este nome já foi usado por outro utilizador, por favor insira um nome diferente", "Utilizadores duplicados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            return true;
        }

        //Carregar todos usuarios inseridos na base de dados
        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection con = new SqlConnection(myconnstring))
            {
                string queryString = "SELECT * FROM Utilizadores ORDER BY nome";

                using (SqlCommand cmd = new SqlCommand(queryString, con))
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        DataTable dtUsers = new DataTable();
                        dtUsers.Load(sdr);
                        UsersDataGridView.DataSource = dtUsers;
                    }
                    else
                    { 
                        UsersDataGridView.DataSource = null;
                    }
                }
            }
        }

        //Exbir tabela todos usuarios inseridos
        private void UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(UsersDataGridView.Rows.Count > 0) 
            { 
                this.id_utilizador = Convert.ToInt32(UsersDataGridView.CurrentRow.Cells[0].Value);
                UsernameTextBox.Text = UsersDataGridView.CurrentRow.Cells[1].Value.ToString();
                UserPasswordTextBox.Text = UsersDataGridView.CurrentRow.Cells[2].Value.ToString();

                DeleteUserButton.Enabled = true;
                SaveUserButton.Text = "Editar";

                //Verificar o tipo de usuario
                string userType = UsersDataGridView.CurrentRow.Cells[3].Value.ToString();

                if (userType == "Admin")
                {
                    AdminRadioButton.Checked = true;
                }
                else if (userType == "User")
                {
                    UserRadioButton.Checked = true;
                }
            }
        }

        //Exibir os usuarios inseridos logo que Form for aberto
        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        //Limpar todos os campos este butao for clicado
        private void CleanFieldButton_Click(object sender, EventArgs e)
        {
            resetFormControls();
        }

        //Exibir a palavra passe
        private void ShowPassowrdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassowrdCheckBox.Checked == true)
            {
                UserPasswordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                UserPasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (this.id_utilizador > 0)
            {
                using (SqlConnection con = new SqlConnection(myconnstring))
                {
                    string queryString = $"DELETE FROM Utilizadores WHERE id_utilizador = '{id_utilizador}'";

                    using (SqlCommand cmd = new SqlCommand(queryString, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Utilizador foi removido com sucesso!", "Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);

                        resetFormControls();
                    }
                }  
            }
        }
    }
}
