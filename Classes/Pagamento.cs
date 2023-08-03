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
    public class Pagamento
    {
       
        public string idEmprestimo {get;set;}
        public int idPagamento { get; set; }
        public DateTime dataPagamento { get; set; }
        public int numPrestacao { get; set; }
        public double valorPrestacao { get; set; }
        public double valorJuros { get;set; }
        public double valorTotal { get; set; }
        public DateTime dataRegistoPgto { get; set; }

        //nome da conexao da BD
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //        Emprestimo emprestimo = new Emprestimo();


        public DataTable Select()
        {
            //passo1: conexao base de Dados
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                //passo 2: escrever a query
                string sql = "SELECT * FROM ViewEmprestimosPagamentos;";

                //cria comando SQL usando sql (query acima) e conn (conexao a base de dados) 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //criando SQL DATAAdapter usando cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool ValidarPagamento (Pagamento pagamento)
        {
            bool isSucess = false;

            SqlConnection conn = new SqlConnection (myconnstring);

            try
            {
                string sql = "INSERT INTO Pagamentos (id_emprestimo, data_pagamento, numero_prestacao, valor_prestacao, valor_juros, valor_total, data_registo_pgto) VALUES (@id_emprestimo, GETDATE(), @numero_prestacao, @valor_prestacao, @valor_juros, @valor_total, GETDATE())";

                SqlCommand cmd = new SqlCommand (sql, conn);

                cmd.Parameters.AddWithValue("@id_emprestimo", pagamento.idEmprestimo);
                cmd.Parameters.AddWithValue("@data_pagamento", pagamento.dataPagamento);
                cmd.Parameters.AddWithValue("@numero_prestacao", pagamento.dataPagamento);
                cmd.Parameters.AddWithValue("@valor_prestacao", pagamento.valorPrestacao);
                cmd.Parameters.AddWithValue("@valor_juros", pagamento.valorJuros);
                cmd.Parameters.AddWithValue("@valor_total", pagamento.valorTotal);
                cmd.Parameters.AddWithValue("@dataRegistoPgto", pagamento.dataRegistoPgto);

                conn.Open();
                int rows =cmd.ExecuteNonQuery ();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    {
                        isSucess = false;
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao registar o pagamento. Detalhes do erro: " + ex.Message, "Erro de SQL ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

            } 
            finally
            {
                conn.Close();
            }
            return isSucess;
        }
        
        



    }
    

}
