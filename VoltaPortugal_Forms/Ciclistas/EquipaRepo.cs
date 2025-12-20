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
    public class EquipaRepo
    {
        public List<Equipa> GetEquipas()
        {
            var list = new List<Equipa>();
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionGlobal))
                {
                    connection.Open();
                    string sql = @"
                SELECT * 
                FROM Volta_Portugal.Equipa"; // completar com view ou join

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Equipa equipa = new Equipa();
                                // verificar Null
                                equipa.Id = reader.GetInt32(0);
                                equipa.Nome = reader.GetString(3);
                                equipa.Pais = reader.GetString(1);
                                equipa.ano_fundacao = reader.GetInt32(4);
                                equipa.num_ciclistas = reader.GetInt32(2);

                                list.Add(equipa);
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

        public List<Equipa> searchEquipas(String nome)
        {
            var lista = new List<Equipa>();
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionGlobal))
                {
                    connection.Open();
                    string sql = @"
                SELECT ID, pais_origem, num_ciclistas, nome, ano_fundacao
                FROM Volta_Portugal.Equipa
                WHERE nome LIKE @nome"; // completar com view ou join
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Equipa equipa = new Equipa();
                                // verificar Null
                                equipa.Id = reader.GetInt32(0);
                                equipa.Nome = reader.GetString(3);
                                equipa.num_ciclistas = reader.GetInt32(2);
                                equipa.Pais = reader.IsDBNull(1) ? "N/A" : reader.GetString(1);
                                equipa.ano_fundacao = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);

                                lista.Add(equipa);
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

        public bool CreateEquipa(Equipa nova, List<int> plantel, int uciidDD)
        {
            using(SqlConnection conn = new SqlConnection(Global.ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // criar equipa
                    string insertsql = "INSERT INTO Volta_Portugal.Equipa (nome, pais_origem, ano_fundacao, num_ciclistas) VALUES (@nome, @pais, @ano, @num); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdEquipa = new SqlCommand(insertsql, conn, transaction);
                    cmdEquipa.Parameters.Add("@nome", nova.Nome);
                    cmdEquipa.Parameters.Add("@pais", nova.Pais);
                    cmdEquipa.Parameters.Add("@ano", nova.ano_fundacao);
                    cmdEquipa.Parameters.Add("@num", plantel.Count);

                    int idEquipa = Convert.ToInt32(cmdEquipa.ExecuteScalar());

                    // inserir categoria
                    string sqlCat = "INSERT INTO Volta_Portugal.Categoria_Equipa (categoria, ID_equipa) VALUES (@cat, @idE)";
                    SqlCommand cmdCat = new SqlCommand(sqlCat, conn, transaction);
                    cmdCat.Parameters.AddWithValue("@cat", nova.Categoria);
                    cmdCat.Parameters.AddWithValue("@idE", idEquipa);
                    cmdCat.ExecuteNonQuery();

                    // associar Diretor desportivo
                    SqlCommand cmdDD = new SqlCommand("Volta_Portugal.sp_TransferirDiretor", conn, transaction);
                    cmdDD.CommandType = CommandType.StoredProcedure;
                    cmdDD.Parameters.AddWithValue("@UCI_ID_diretor", uciidDD);
                    cmdDD.Parameters.AddWithValue("@ID_equipa_nova", idEquipa);
                    cmdDD.Parameters.AddWithValue("@data_transferencia", DateTime.Now);
                    cmdDD.ExecuteNonQuery();

                    // associar ciclista
                    foreach (int idCiclista in plantel)
                    {
                        SqlCommand cmdC = new SqlCommand("Volta_Portugal.sp_TransferirCiclista", conn, transaction);
                        cmdC.CommandType = CommandType.StoredProcedure;

                        cmdC.Parameters.AddWithValue("@UCI_ID_ciclista", idCiclista);
                        cmdC.Parameters.AddWithValue("@ID_equipa_nova", idEquipa);
                        cmdC.Parameters.AddWithValue("@data_transferencia", DateTime.Now);

                        cmdC.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }
            }
        }
        public bool DeleteEquipa(int id)
        {
            using (SqlConnection conn = new SqlConnection(Global.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Volta_Portugal.sp_ApagarEquipa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UCI_ID_Diretor", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

    }
}
