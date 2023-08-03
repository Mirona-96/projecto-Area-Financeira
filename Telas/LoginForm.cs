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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                UserPasswordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                UserPasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(myconnstring))
                {

                    string queryString = $"SELECT * FROM Utilizadores WHERE nome=@unome AND palavra_passe=@upass";
                    using (SqlCommand cmd = new SqlCommand(queryString, con))
                    {
                        cmd.Parameters.AddWithValue("@unome", UserNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@upass", UserPasswordTextBox.Text);

                        if (con.State != ConnectionState.Open)
                            con.Open();


                        SqlDataReader drUsers = cmd.ExecuteReader();

                        if (drUsers.HasRows)
                        {
                            drUsers.Read();
                            if (drUsers[3].ToString() == "Admin")
                            {
                                Db_connection.UserType = "A";
                            }
                            else if (drUsers[3].ToString() == "User")
                            {
                                Db_connection.UserType = "U";
                            }

                            DashboardForm df = new DashboardForm();
                            df.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Utilizador ou palavra-passe incorrecta, por favor tente novamente", "Erro ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
