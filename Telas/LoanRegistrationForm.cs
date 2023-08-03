using Financeiro_2.Geral;
using Financeiro_V3.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace FInanceiro_3._0
{
    public partial class LoanRegistrationForm : Form
    {
        public LoanRegistrationForm()
        {
            InitializeComponent();
        }

        Emprestimo emprestimo = new Emprestimo();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public int id_emprestimo = 0;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoanRegistrationForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoClienteComboBox();
        }

        public void LoadDataIntoClienteComboBox()
        {
            using (SqlConnection conn = new SqlConnection(myconnstring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id_cliente, CONCAT(nome, ' ', apelido) AS nome_completo  FROM cliente", conn))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        DataTable dtClientes = new DataTable();

                        dtClientes.Load(sdr);

                        ClientesComboBox1.DataSource = dtClientes;
                        ClientesComboBox1.DisplayMember = "nome_completo";
                        ClientesComboBox1.ValueMember = "id_Cliente";
                    }
                }
            }
        }

        public string LoadDataIntoClienteComboBoxById(int id)
        {
            string nome_completo = null;

            using (SqlConnection conn = new SqlConnection(myconnstring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT CONCAT(nome, ' ', apelido) AS nome_completo FROM Cliente WHERE id_cliente = @id_cliente", conn))
                {
                    cmd.Parameters.AddWithValue("@id_cliente", id);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        nome_completo = result.ToString(); ;
                }
            }
            return nome_completo;
        }


        private void RefreshDataGridView()
        {
            // Obtém os dados atualizados do emprestimos
            DataTable dt = emprestimo.Select();

            EmprestimoDataGridView.DataSource = dt;
            EmprestimoDataGridView.Refresh();
        }

        private void Clear()
        {
            ClientesComboBox1.SelectedIndex = -0;
            ValorEmprestimoTextBox.Clear();
            PrazoTextBox.Clear();
            TaxaJuroTextBox.Clear();
            TotalPagarTextBox.Clear();
            TotalJurosTextBox.Clear();
            PrestacaoMensalTextBox.Clear();
            DataAprovacaoDateTimePicker2.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -0;
            DescricaoGarantiaTextBox.Clear();
            ValorGarantiaTextBox.Clear();
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (double.TryParse(ValorEmprestimoTextBox.Text.Trim(), out double valorEmprestimo) && int.TryParse(PrazoTextBox.Text.Trim(), out int prazo) && double.TryParse(ValorGarantiaTextBox.Text.Trim(), out double valorGarantia))
            {
                if (prazo < 2 || prazo > 36)
                {
                    MessageBox.Show("Não é possivel efectuar emprestimos com prazos menores de 3 meses e emprestimos com prazos maiores que 36 meses.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    emprestimo.valorEmprestimo = valorEmprestimo;
                    emprestimo.prazo = prazo;
                    emprestimo.id_cliente = (int)ClientesComboBox1.SelectedValue;
                    emprestimo.dataAprovacao = DataAprovacaoDateTimePicker2.Value.Date;
                    emprestimo.status = cmbStatus.Text;
                    emprestimo.descricaoGarantia = DescricaoGarantiaTextBox.Text;
                    emprestimo.valorGarantia = double.Parse(ValorGarantiaTextBox.Text);

                    emprestimo.SimulacaoEmprestimo(emprestimo);

                    bool success = emprestimo.SaveEmprestimo(emprestimo);

                    if (success == true)
                    {
                        //insercao bem sucedida
                        MessageBox.Show("Registo efectuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGridView();
                        Clear();
                    }
                    else
                    {
                        //falha na insercao de contact
                        MessageBox.Show("Erro ao efectuar ao registo. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Se a convers�o falhar, voc� pode exibir uma mensagem de erro adequada ou executar alguma outra a��o.
                MessageBox.Show("Valores inválidos inseridos. Por favor, verifique os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SimularEmprestimoButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ValorEmprestimoTextBox.Text.Trim(), out double valorEmprestimo) && int.TryParse(PrazoTextBox.Text.Trim(), out int prazo))
            {
                if (prazo < 2 || prazo > 36)
                {
                    MessageBox.Show("Não é possivel efectuar emprestimos com prazos menores de 3 meses e emprestimos com prazos maiores que 36 meses.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    emprestimo.valorEmprestimo = valorEmprestimo;
                    emprestimo.prazo = prazo;

                    emprestimo.SimulacaoEmprestimo(emprestimo);

                    TaxaJuroTextBox.Text = emprestimo.taxaJuro.ToString("F2");
                    TotalPagarTextBox.Text = emprestimo.valorTotalPagar.ToString("F2");
                    PrestacaoMensalTextBox.Text = emprestimo.prestacaoMensal.ToString("F2");
                    TotalJurosTextBox.Text = emprestimo.valorTotalJuros.ToString("F2");
                }
            }
            else
            {
                // Se a convers�o falhar, voc� pode exibir uma mensagem de erro adequada ou executar alguma outra a��o.
                MessageBox.Show("Valores inválidos inseridos. Por favor, verifique os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ValorEmprestimoTextBox.Text.Trim(), out double valorEmprestimo) && int.TryParse(PrazoTextBox.Text.Trim(), out int prazo))
            {
                if (prazo < 2 || prazo > 36)
                {
                    MessageBox.Show("Não é possivel efectuar emprestimos com prazos menores de 3 meses e emprestimos com prazos maiores que 36 meses.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    emprestimo.id_emprestimo = id_emprestimo;
                    emprestimo.valorEmprestimo = valorEmprestimo;
                    emprestimo.prazo = prazo;
                    emprestimo.dataAprovacao = DataAprovacaoDateTimePicker2.Value.Date;
                    emprestimo.status = cmbStatus.Text;
                    emprestimo.descricaoGarantia = DescricaoGarantiaTextBox.Text;
                    emprestimo.valorGarantia = double.Parse(ValorGarantiaTextBox.Text);

                    emprestimo.SimulacaoEmprestimo(emprestimo);

                    bool success = emprestimo.Update(emprestimo);

                    if (success == true)
                    {
                        //insercao bem sucedida
                        MessageBox.Show("Emprestimo actualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();

                        RefreshDataGridView();
                        //Chama o metodo para limpar os campos
                    }
                    else
                    {
                        //falha na insercao de contact
                        MessageBox.Show("Erro ao actualizar o emprestimo. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Se a convers�o falhar, voc� pode exibir uma mensagem de erro adequada ou executar alguma outra a��o.
                MessageBox.Show("Valores inválidos inseridos. Por favor, verifique os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            emprestimo.id_emprestimo = id_emprestimo;

            bool success = emprestimo.Delete(emprestimo);

            if (success == true)
            {
                MessageBox.Show("Emprestimo removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                Clear();
            }
            else
            {
                MessageBox.Show("Erro ao remover o emprestimo. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EmprestimoDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id_emprestimo = Convert.ToInt32(EmprestimoDataGridView.Rows[rowIndex].Cells[0].Value);
            int id_cliente = Convert.ToInt32(EmprestimoDataGridView.Rows[rowIndex].Cells[1].Value);
            ClientesComboBox1.Text = LoadDataIntoClienteComboBoxById(id_cliente);

            ValorEmprestimoTextBox.Text = EmprestimoDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            PrazoTextBox.Text = EmprestimoDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            TaxaJuroTextBox.Text = EmprestimoDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            TotalPagarTextBox.Text = EmprestimoDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            TotalJurosTextBox.Text = EmprestimoDataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            PrestacaoMensalTextBox.Text = EmprestimoDataGridView.Rows[rowIndex].Cells[7].Value.ToString();
            DataAprovacaoDateTimePicker2.Value = DateTime.Parse(EmprestimoDataGridView.Rows[rowIndex].Cells[8].Value.ToString());
            cmbStatus.SelectedItem = EmprestimoDataGridView.Rows[rowIndex].Cells[9].Value.ToString();
            DescricaoGarantiaTextBox.Text = EmprestimoDataGridView.Rows[rowIndex].Cells[10].Value.ToString();
            ValorGarantiaTextBox.Text = EmprestimoDataGridView.Rows[rowIndex].Cells[11].Value.ToString();

        }

        private void LoanRegistrationForm_Load_1(object sender, EventArgs e)
        {
            LoadDataIntoClienteComboBox();
            RefreshDataGridView();
            Clear();

        }

        private void SimularEmprestimoButton_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(ValorEmprestimoTextBox.Text.Trim(), out double valorEmprestimo) && int.TryParse(PrazoTextBox.Text.Trim(), out int prazo))
            {
                if (prazo < 2 || prazo > 36)
                {
                    MessageBox.Show("Não é possivel efectuar emprestimos com prazos menores de 3 meses e emprestimos com prazos maiores que 36 meses.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    emprestimo.valorEmprestimo = valorEmprestimo;
                    emprestimo.prazo = prazo;

                    emprestimo.SimulacaoEmprestimo(emprestimo);

                    TaxaJuroTextBox.Text = emprestimo.taxaJuro.ToString("F2");
                    TotalPagarTextBox.Text = emprestimo.valorTotalPagar.ToString("F2");
                    PrestacaoMensalTextBox.Text = emprestimo.prestacaoMensal.ToString("F2");
                    TotalJurosTextBox.Text = emprestimo.valorTotalJuros.ToString("F2");
                }
            }
            else
            {
                // Se a convers�o falhar, voc� pode exibir uma mensagem de erro adequada ou executar alguma outra a��o.
                MessageBox.Show("Valores inválidos inseridos. Por favor, verifique os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmprestimoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* private void btnSave_Click_1(object sender, EventArgs e)
         {

         }*/
    }
}