using FInanceiro_3._0;
using Financeiro_V3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro_2.Telas
{
    public partial class ClientRegistrationForm : Form
    {
        public ClientRegistrationForm()
        {
            InitializeComponent();
        }

        CultureInfo culture = CultureInfo.InvariantCulture;

        Cliente cliente = new Cliente();

        public void Clear()
        {
            tbIdCliente.Text = " ";
            tbName.Text = " ";
            tbLastName.Text = " ";
            tbContact.Text = " ";
            tbEmail.Text = " ";
            tbAddress.Text = " ";
            tbIncomeSource.Text = " ";
            tbSalary.Text = " ";
        }

        private void RefreshDataGridView()
        {
            // Obtém os dados atualizados do cliente
            DataTable dt = cliente.Select();

            // Atualiza o DataSource do DataGridView
            dgvDadosCliente.DataSource = dt;

            // Redesenha o DataGridView
            dgvDadosCliente.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblIdCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            new LoanRegistrationForm().Show();
        }

        private void ClientRegistrationForm_Load(object sender, EventArgs e)
        {
            //manda os dados para o Data Grid View usando a query 
            DataTable dt = cliente.Select();
            dgvDadosCliente.DataSource = dt;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //recebe os dados dos textboxes da insercao
            cliente.Nome = tbName.Text;
            cliente.Apelido = tbLastName.Text;
            cliente.ContactoCliente = int.Parse(tbContact.Text);
            cliente.EmailCliente = tbEmail.Text;
            cliente.EnderecoCliente = tbAddress.Text;
            cliente.FonteRendimento = tbIncomeSource.Text;
            cliente.RendaMensal = double.Parse((tbSalary.Text), culture);

            //inserindo dados na BD
            bool sucess = cliente.Insert(cliente);

            if (sucess == true)
            {
                MessageBox.Show("Dados do Cliente inseridos com sucesso na tabela.");
                Clear();
                cliente.Select();
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Falha na inserção. Tente novamente.");

                //manda os dados para o Data Grid View
                DataTable dt = cliente.Select();
                dgvDadosCliente.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //recebe os dados dos textboxes para actualizacao
            // cliente.IdCliente = int.Parse(tbIdCliente.Text);
            try
            {
                int idCliente;
                if (int.TryParse(tbIdCliente.Text, out idCliente))
                {
                    cliente.IdCliente = idCliente;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro na conversão do valor do ID do cliente para inteiro" + ex.Message);
            }


            cliente.Nome = tbName.Text;
            cliente.Apelido = tbLastName.Text;
            //  cliente.ContactoCliente = int.Parse(tbContact.Text);
            try
            {
                int contatoCliente;
                if (int.TryParse(tbContact.Text, out contatoCliente))
                {
                    cliente.ContactoCliente = contatoCliente;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }

            cliente.EmailCliente = tbEmail.Text;
            cliente.EnderecoCliente = tbAddress.Text;
            cliente.FonteRendimento = tbIncomeSource.Text;
            cliente.RendaMensal = double.Parse((tbSalary.Text), culture);



            //actualiza os dados n BD
            bool sucess = cliente.Update(cliente);

            if (sucess == true)
            {
                MessageBox.Show("Actualizacao realizada com sucesso");

                //manda os dados para o Data Grid
                DataTable dt = cliente.Select();
                dgvDadosCliente.DataSource = dt;
                Clear();
                RefreshDataGridView();
            }
            else
            {
                //falha na actualizacao
                MessageBox.Show("Falha na actualização. Tente novamente");
            }

        }

        private void dgvDadosCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //recebe os dados do DAtA Grid e carreaga para os text box
            // cliente.IdCliente = Convert.ToInt32(tbIdCliente.Text);
            cliente.Nome = tbName.Text;
            cliente.Apelido = tbLastName.Text;

            try
            {
                int contatoCliente;
                if (int.TryParse(tbContact.Text, out contatoCliente))
                {
                    cliente.ContactoCliente = contatoCliente;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
            // cliente.ContactoCliente = int.Parse(tbContact.Text);
            cliente.EmailCliente = tbEmail.Text;
            cliente.EnderecoCliente = tbAddress.Text;
            cliente.FonteRendimento = tbIncomeSource.Text;
            //  cliente.RendaMensal = double.Parse((tbSalary.Text), culture);
            // cliente.data_registo = DateTime.Parse(DataRegisto.Value.Text);



            //identifica a linha na qual o mouse fez o click
            int rowIndex = e.RowIndex;
            tbIdCliente.Text = dgvDadosCliente.Rows[rowIndex].Cells[0].Value.ToString();
            tbName.Text = dgvDadosCliente.Rows[rowIndex].Cells[1].Value.ToString();
            tbLastName.Text = dgvDadosCliente.Rows[rowIndex].Cells[2].Value.ToString();
            tbAddress.Text = dgvDadosCliente.Rows[rowIndex].Cells[3].Value.ToString();
            tbContact.Text = dgvDadosCliente.Rows[rowIndex].Cells[4].Value.ToString();
            tbEmail.Text = dgvDadosCliente.Rows[rowIndex].Cells[5].Value.ToString();
            tbIncomeSource.Text = dgvDadosCliente.Rows[rowIndex].Cells[6].Value.ToString();
            tbSalary.Text = dgvDadosCliente.Rows[rowIndex].Cells[7].Value.ToString();


            /*string valorCelula = dgvDadosCliente.Rows[rowIndex].Cells[8].Value.ToString();
             DateTime dataRegisto;

             if (DateTime.TryParse(valorCelula, out dataRegisto))
             {
                 DataRegisto.Value = dataRegisto;
             }
             else
             {
                   // Tratar caso em que a conversão falha
             } */

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cliente.data_registo = DataRegisto.Value;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //recebe os dados dos textboxes
            //            cliente.IdCliente = int.Parse(tbIdCliente.Text);
            int idCliente;
            if (int.TryParse(tbIdCliente.Text, out idCliente))
            {
                cliente.IdCliente = idCliente;
            }
            else
            {
                MessageBox.Show("Erro na conversão do valor do ID do cliente para inteiro");
                return;
            }

            bool success = cliente.Delete(cliente);

            if (success == true)
            {
                MessageBox.Show("Cliente removido com sucesso.");
                RefreshDataGridView();
                Clear();
            }
            else
            {
                MessageBox.Show("Falha na remoção de cliente. Tente novamente.");
            }

        }
    }
}

