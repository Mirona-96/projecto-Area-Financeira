using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro_V3.Classes
{
    public class Emprestimo
    {
        public int id_cliente { get; set; }
        public int id_emprestimo { get; set; }
        public double valorEmprestimo { get; set; }
        public int prazo { get; set; }
        public double taxaJuro { get; set; }
        public double valorTotalPagar { get; set; }
        public double prestacaoMensal { get; set; }
        public DateTime dataAprovacao { get; set; }
        public string status { get; set; }
        public string descricaoGarantia { get; set; }
        public double valorGarantia { get; set; }
        public double taxaJuroMensal { get; set; }
        public double valorTotalJuros { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public void SimulacaoEmprestimo(Emprestimo emp)
        {
            if ((emp.prazo >= 3) && (emp.prazo <= 12))
            {
                taxaJuro = 30;
                taxaJuroMensal = taxaJuro / 100;
                prestacaoMensal = (valorEmprestimo * taxaJuroMensal * Math.Pow((1 + taxaJuroMensal), emp.prazo)) / (Math.Pow((1 + taxaJuroMensal), emp.prazo) - 1);
                valorTotalPagar = prestacaoMensal * emp.prazo;
                valorTotalJuros = valorTotalPagar - valorEmprestimo;

            }
            else if ((emp.prazo > 12) && (emp.prazo <= 24))
            {
                taxaJuro = 20;
                taxaJuroMensal = (taxaJuro / 100) / emp.prazo;
                prestacaoMensal = (valorEmprestimo * taxaJuroMensal * Math.Pow((1 + taxaJuroMensal), emp.prazo)) / (Math.Pow((1 + taxaJuroMensal), emp.prazo) - 1);
                valorTotalPagar = prestacaoMensal * emp.prazo;
                valorTotalJuros = valorTotalPagar - valorEmprestimo;
            }
            else if ((emp.prazo > 24) && (emp.prazo <= 36))
            {
                taxaJuro = 10;
                taxaJuroMensal = (taxaJuro / 100) / emp.prazo;
                prestacaoMensal = (valorEmprestimo * taxaJuroMensal * Math.Pow((1 + taxaJuroMensal), emp.prazo)) / (Math.Pow((1 + taxaJuroMensal), emp.prazo) - 1);
                valorTotalPagar = prestacaoMensal * emp.prazo;
                valorTotalJuros = valorTotalPagar - valorEmprestimo;
            }
            else
            {
                return;
            }
        }

        public bool SaveEmprestimo(Emprestimo emp)
        {
            bool isSucess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Emprestimos " +
                    "(id_cliente, valor_emprestimo, prazo_meses, taxa_juro, valor_total_pagar, valor_total_juros, prestacao_mensal, data_aprovacao, status, descricao_garantia, valor_garantia, data_registo) VALUES " +
                    "(@id_cliente, @valor_emprestimo, @prazo_meses, @taxa_juro, @valor_total_pagar, @valor_total_juros, @prestacao_mensal, @data_aprovacao, @status, @descricao_garantia, @valor_garantia, GETDATE())";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_cliente", emp.id_cliente);
                cmd.Parameters.AddWithValue("@valor_emprestimo", emp.valorEmprestimo);
                cmd.Parameters.AddWithValue("@prazo_meses", emp.prazo);
                cmd.Parameters.AddWithValue("@taxa_juro", taxaJuro / 100);
                cmd.Parameters.AddWithValue("@valor_total_pagar", valorTotalPagar);
                cmd.Parameters.AddWithValue("@valor_total_juros", valorTotalJuros);
                cmd.Parameters.AddWithValue("@prestacao_mensal", prestacaoMensal);
                cmd.Parameters.AddWithValue("@data_aprovacao", emp.dataAprovacao);
                cmd.Parameters.AddWithValue("@status", emp.status);
                cmd.Parameters.AddWithValue("@descricao_garantia", emp.descricaoGarantia);
                cmd.Parameters.AddWithValue("@valor_garantia", emp.valorGarantia);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //se a query funcionar, o valor das linhas será maior que zero (0) senão será zero 0
                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao registar o empréstimo. Detalhes do erro: " + ex.Message, "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao registar o empréstimo. Detalhes do erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;
        }

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Emprestimos";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro. Detalhes do erro: " + ex.Message, "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Detalhes do erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Update(Emprestimo emp)
        {
            bool isSucess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE Emprestimos SET valor_emprestimo = @valor_emprestimo, prazo_meses = @prazo_meses, taxa_juro = @taxa_juro, valor_total_pagar = @valor_total_pagar, valor_total_juros = @valor_total_juros, prestacao_mensal = @prestacao_mensal, data_aprovacao = @data_aprovacao, status = @status, descricao_garantia = @descricao_garantia, valor_garantia = @valor_garantia WHERE id_emprestimo = @id_emprestimo";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@valor_emprestimo", emp.valorEmprestimo);
                cmd.Parameters.AddWithValue("@prazo_meses", emp.prazo);
                cmd.Parameters.AddWithValue("@taxa_juro", taxaJuro / 100);
                cmd.Parameters.AddWithValue("@valor_total_pagar", valorTotalPagar);
                cmd.Parameters.AddWithValue("@valor_total_juros", valorTotalJuros);
                cmd.Parameters.AddWithValue("@prestacao_mensal", prestacaoMensal);
                cmd.Parameters.AddWithValue("@data_aprovacao", emp.dataAprovacao);
                cmd.Parameters.AddWithValue("@status", emp.status);
                cmd.Parameters.AddWithValue("@descricao_garantia", emp.descricaoGarantia);
                cmd.Parameters.AddWithValue("@valor_garantia", emp.valorGarantia);
                cmd.Parameters.AddWithValue("@id_emprestimo", emp.id_emprestimo);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro. Detalhes do erro: " + ex.Message, "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Detalhes do erro: " + ex.Message, "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSucess;
        }

        public bool Delete(Emprestimo emprestimo)
        {
            bool isSucess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM Emprestimos WHERE id_emprestimo = @id_emprestimo";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_emprestimo", emprestimo.id_emprestimo);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao remover emprestimo. Detalhes do erro: " + ex.Message, "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao remover emprestimo. Detalhes do erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSucess;
        }
    }
}

