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
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string EnderecoCliente { get; set; }
        public int ContactoCliente { get; set; }
        public string EmailCliente { get; set; }

        public string FonteRendimento { get; set; }
        public double RendaMensal { get; set; }
        public DateTime data_registo { get; set; }

        //nome da conexao da BD
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //selecciona dados da BD
        public DataTable Select()
        {
            //passo1: conexao base de Dados
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                //passo 2: escrever a query
                string sql = "SELECT * FROM Cliente";

                //cria comando SQL usando sql (query acima) e conn (conexao a base de dados) 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //criando SQL DATAAdapter usando cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            } catch (Exception ex)
            {

            }
            finally { 
                conn.Close(); 
            }
            return dt;
        }

        public bool Insert (Cliente cliente)
          {
              //Cria um retorno por defeito atribuindo o valor "falso"
              bool isSucess = false;

              //passo 1: conexao a base de dados
              SqlConnection conn = new SqlConnection (myconnstring);

              try
              {
                  //passo 2: cria sql comando para inserir dados  
                  string sql = "INSERT INTO Cliente (nome, apelido, endereco, contacto, email, fonte_rendimento, renda_mensal, data_registo) values (@nome, @apelido, @endereco, @contacto, @email, @fonte_rendimento, @renda_mensal, @data_registo)";

                  //passo 3: cria comando sql com a query acima e conn
                  SqlCommand cmd = new SqlCommand(sql, conn);

                //passo4: cria parametros para adicionar valores
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@apelido", cliente.Apelido);
                cmd.Parameters.AddWithValue("@contacto", cliente.ContactoCliente);
                cmd.Parameters.AddWithValue("@email", cliente.EmailCliente);
                cmd.Parameters.AddWithValue("@endereco", cliente.EnderecoCliente);
                cmd.Parameters.AddWithValue("@fonte_rendimento", cliente.FonteRendimento);
                cmd.Parameters.AddWithValue("@renda_mensal", cliente.RendaMensal);
                cmd.Parameters.AddWithValue("@data_registo", cliente.data_registo);
                
                //abertura da conexao
                conn.Open ();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                } else
                {
                    isSucess = false;
                }

            } catch (SqlException ex)
            
               {
                MessageBox.Show("Erro ao registar cliente. Detalhes do erro: " + ex.Message);

                    
                }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao registar cliente. Detalhes do erro: " + ex.Message);


            }

            finally
                {
                conn.Close();
              }
               return isSucess;
          }

        //metodo para actualizar dados na bd
        public bool Update(Cliente cliente)
        {
            //Cria um retorno por defeito atribuindo o valor "falso"
            bool isSucess = false;

            //passo 1: conexao a base de dados
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //query para actulzair dados
                string SQL = "UPDATE Cliente SET nome = @nome, apelido = @apelido, endereco = @endereco, contacto = @contacto, email = @email, fonte_rendimento = @fonte_rendimento, renda_mensal = @renda_mensal WHERE id_Cliente = @id_Cliente";


                SqlCommand cmd = new SqlCommand (SQL, conn);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@apelido", cliente.Apelido);
                cmd.Parameters.AddWithValue("@contacto", cliente.ContactoCliente);
                cmd.Parameters.AddWithValue("@email", cliente.EmailCliente);
                cmd.Parameters.AddWithValue("@endereco", cliente.EnderecoCliente);
                cmd.Parameters.AddWithValue("@fonte_rendimento", cliente.FonteRendimento);
                cmd.Parameters.AddWithValue("@renda_mensal", cliente.RendaMensal);
                cmd.Parameters.AddWithValue("@data_registo", cliente.data_registo);
                cmd.Parameters.AddWithValue("@id_cliente", cliente.IdCliente);



                //abertura da conexao
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
                MessageBox.Show("Erro ao actualizar cliente. Detalhes do erro: " + ex.Message);


            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao actualizar cliente. Detalhes do erro: " + ex.Message);


            }
            finally 
            { 
                conn.Close(); 
            }


            return isSucess;
        }

        //Metodo para apagar dados da BD
        public bool Delete (Cliente cliente) 
        {
            //Cria um retorno por defeito atribuindo o valor "falso"
            bool isSucess = false;

            //passo 1: conexao a base de dados
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Query para apagar dados da BD
                string SQL = "DELETE FROM Cliente WHERE id_Cliente = @id_Cliente";

                SqlCommand cmd = new SqlCommand (SQL, conn);

                cmd.Parameters.AddWithValue("@id_Cliente", cliente.IdCliente);

                //abertura da conexao
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
                MessageBox.Show("Erro ao apagar cliente. Detalhes do erro: " + ex.Message);


            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao apagar cliente. Detalhes do erro: " + ex.Message);


            }
            finally 
            { 
                conn.Close(); 
            }


            return isSucess;
        }

    }
}
