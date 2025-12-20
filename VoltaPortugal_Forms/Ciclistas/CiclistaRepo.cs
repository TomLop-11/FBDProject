using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace VoltaPortugal_Forms.Ciclistas
{
    public class CiclistaRepo
    {
        public List<Ciclista> GetCiclistas()
        {
            var list = new List<Ciclista>();
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionGlobal))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Volta_Portugal.vw_ListaTodosCiclistas ORDER BY UCI_ID ASC"; // completar com view ou join

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Ciclista ciclista = new Ciclista();
                                // verificar Null
                                ciclista.UciId = reader.GetInt32(0);
                                ciclista.NumDorsal = reader.GetInt32(1);
                                ciclista.Nome = reader.GetString(2);
                                ciclista.Nacionalidade = reader.GetString(3);

                                if (reader.IsDBNull(4))
                                {
                                    ciclista.DataNascimento = null;
                                } else
                                {
                                    ciclista.DataNascimento = reader.GetDateTime(4);
                                }
                                ciclista.Categoria = reader.IsDBNull(5) ? "N/A" : reader.GetString(5);
                                ciclista.Camisola = reader.IsDBNull(7) ? "N/A" : reader.GetString(7);
                                ciclista.nome_equipa = reader.GetString(6);
                                
                                
                                

                                list.Add(ciclista);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }

        public List<Ciclista> SearchCiclista(string nome)
        {
            var lista = new List<Ciclista>();
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionGlobal))
                {
                    connection.Open();
                    string sql = @"
                SELECT 
                    C.UCI_ID,            -- Index 0
                    C.num_dorsal,        -- Index 1
                    P.nome,              -- Index 2
                    P.nacionalidade,     -- Index 3
                    P.data_nascimento    -- Index 4
                FROM Volta_Portugal.Ciclista C
                INNER JOIN Volta_Portugal.Pessoa P ON C.UCI_ID = P.UCI_ID
                WHERE P.nome LIKE @nome"; // completar com view ou join
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome","%" + nome + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Ciclista ciclista = new Ciclista();
                                // verificar Null
                                ciclista.UciId = reader.GetInt32(0);
                                ciclista.NumDorsal = reader.GetInt32(1);
                                ciclista.Nome = reader.GetString(2);
                                ciclista.Nacionalidade = reader.GetString(3);

                                if (reader.IsDBNull(4))
                                {
                                    ciclista.DataNascimento = null;
                                }
                                else
                                {
                                    ciclista.DataNascimento = reader.GetDateTime(4);
                                }

                                lista.Add(ciclista);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lista;
        }

        public void CreateCiclista(Ciclista ciclista)
        {
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionGlobal))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string sqlPessoa = ""; // usar SCOPE_IDENTITY()
                        int newUciId;
                        using (SqlCommand cmdPessoa = new SqlCommand(sqlPessoa, conn, transaction))
                        {
                            cmdPessoa.Parameters.AddWithValue("@nome", ciclista.Nome);
                            cmdPessoa.Parameters.AddWithValue("@nacionalidade", ciclista.Nacionalidade);

                            if (ciclista.DataNascimento == null) cmdPessoa.Parameters.AddWithValue("@data", DBNull.Value);
                            else cmdPessoa.Parameters.AddWithValue("@data", ciclista.DataNascimento);

                            newUciId = Convert.ToInt32(cmdPessoa.ExecuteScalar());
                        }

                        string sqlCiclista = "";

                        using (SqlCommand cmdCiclista = new SqlCommand(sqlCiclista, conn, transaction))
                        {
                            cmdCiclista.Parameters.AddWithValue("@uci_id", newUciId);
                            cmdCiclista.Parameters.AddWithValue("@dorsal", ciclista.NumDorsal);

                            cmdCiclista.ExecuteNonQuery();
                        }

                        transaction.Commit();


                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditCiclista(Ciclista ciclista)
        {

        }

        public bool DeleteCiclista(int UciId)
        {
            using(SqlConnection conn = new SqlConnection(Global.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Volta_Portugal.sp_ApagarCiclista", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UCI_ID_Ciclista", UciId);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
