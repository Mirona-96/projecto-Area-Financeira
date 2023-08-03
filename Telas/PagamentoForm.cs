using Financeiro_V3.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Financeiro_V3
{
    public partial class PagamentoForm : Form
    {

        public PagamentoForm()
        {
            InitializeComponent();

        }

        Pagamento pagamento = new Pagamento();
        Cliente cliente = new Cliente();
        Emprestimo emprestimo = new Emprestimo();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public void Clear()
        {
            ClientesComboBox.Text = " ";
            idEmprestimoComboBox.Text = " ";
            tbxNumPrestacao.Text = " ";
            tbxValorPrestacao.Text = " ";
            tbxValorJuros.Text = " ";
            tbxValorTotal.Text = " ";
        }

        private void RefreshDataGridView()
        {
            // Obtém os dados atualizados do pagamento
            DataTable dt = pagamento.Select();

            // Atualiza o DataSource do DataGridView
            dgvDadosPagamento.DataSource = dt;

            // Redesenha o DataGridView
            dgvDadosPagamento.Refresh();
        }





        private void LoanPagamento_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_CloseUp(object sender, EventArgs e)
        {

        }

        private void lblIdCliente_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PagamentoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoClientesComboBox();
            LoadDataIntoidEmprestimoComboBox();
            DataTable dt = pagamento.Select();
            dgvDadosPagamento.DataSource = dt;
        }

        private void ClientesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadDataIntoClientesComboBox()
        {
            using (SqlConnection conn = new SqlConnection(myconnstring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id_cliente, CONCAT(nome, ' ', apelido) AS nome_completo FROM cliente", conn))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        DataTable dtClientes = new DataTable();
                        dtClientes.Load(sdr);

                        ClientesComboBox.DataSource = dtClientes;
                        ClientesComboBox.DisplayMember = "nome_completo";
                        ClientesComboBox.ValueMember = "id_cliente";
                    }
                }
            }
        }


        public void LoadDataIntoidEmprestimoComboBox()
        {
            using (SqlConnection conn = new SqlConnection(myconnstring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id_emprestimo, CONCAT (id_emprestimo, ' . ', valor_emprestimo) AS dados_emprestimo FROM emprestimos", conn))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        DataTable dtEmprestimos = new DataTable();
                        dtEmprestimos.Load(sdr);

                        idEmprestimoComboBox.DataSource = dtEmprestimos;
                        idEmprestimoComboBox.DisplayMember = "valor_emprestimo";
                        idEmprestimoComboBox.ValueMember = "id_emprestimo";
                    }
                }
            }
        }

        private void idEmprestimoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idEmprestimoComboBox.SelectedItem != null)
            {
                int idEmprestimo = (int)idEmprestimoComboBox.SelectedValue;

                // Recupera os dados do empréstimo selecionado com base no ID
                Emprestimo emprestimo = GetEmprestimoById(idEmprestimo);

                if (emprestimo != null)
                {
                    // Preenche os campos com os dados do empréstimo
                    tbxNumPrestacao.Text = pagamento.numPrestacao.ToString();
                    tbxValorPrestacao.Text = emprestimo.prestacaoMensal.ToString();
                    tbxValorJuros.Text = emprestimo.valorTotalJuros.ToString();
                    tbxValorTotal.Text = emprestimo.valorTotalPagar.ToString();
                }
            }
        }

        private Emprestimo GetEmprestimoById(int idEmprestimo)
        {
            /*Código para buscar os dados do empréstimo com base no ID
            e retornar um objeto Emprestimo preenchido com esses dados.*/
            // Substitua essa parte do código pelo método que você utiliza para obter os dados do empréstimo.

            // Exemplo de código fictício:
            Emprestimo emprestimo = null;

            using (SqlConnection conn = new SqlConnection(myconnstring))
            {
                string query = "SELECT numero_prestacao, valor_prestacao, valor_juros, valor_total FROM Pagamentos WHERE id_emprestimo = @idEmprestimo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idEmprestimo", idEmprestimo);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        pagamento = new Pagamento
                        {
                            numPrestacao = (int)reader["numero_prestacao"]
                        };

                        emprestimo = new Emprestimo
                        {
                            prestacaoMensal = (double)reader["prestacao_mensal"],
                            valorTotalJuros = (double)reader["valor_total_juros"],
                            valorTotalPagar = (double)reader["valor_total_pagar"]
                        };
                    }

                    reader.Close();
                }
            }

            return emprestimo;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnValidarPgto_Click(object sender, EventArgs e)
        {

            try
            {
                double valorPrestacao;
                if (double.TryParse(tbxValorPrestacao.Text, out valorPrestacao))
                {
                    pagamento.valorPrestacao = valorPrestacao;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro na conversão do valor do ID do cliente para inteiro" + ex.Message);
            }

            try
            {
                double valorJuros;
                if (double.TryParse(tbxValorJuros.Text, out valorJuros))
                {
                    pagamento.valorJuros = valorJuros;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro na conversão do valor do ID do cliente para inteiro" + ex.Message);
            }


            try
            {
                double valorTotal;
                if (double.TryParse(tbxValorTotal.Text, out valorTotal))
                {
                    pagamento.valorTotal = valorTotal;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro na conversão do valor do ID do cliente para inteiro" + ex.Message);
            }

            bool success = pagamento.ValidarPagamento(pagamento);

            if (success)
            {
                MessageBox.Show("Pagamento validado com suceeso");
            }
            else
            {
                MessageBox.Show("Pagamento não validado");
            }

            DataTable dt = new DataTable();
            dgvDadosPagamento.DataSource = dt;


        }

        private void dgvDadosPagamento_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}