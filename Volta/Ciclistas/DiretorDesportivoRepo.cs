using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Volta.Ciclistas
{
    public class DiretorDesportivoRepo
    {

        public List<DiretorDesportivo> GetDD()
        {
            var list = new List<DiretorDesportivo>();
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionGlobal))
                {
                    connection.Open();
                    string sql = @"
                SELECT 
                    D.UCI_ID,            -- Index 0
                    P.nome,              -- Index 2
                    P.nacionalidade,     -- Index 3
                    P.data_nascimento    -- Index 4
                FROM Volta_Portugal.DiretorDesportivo D
                JOIN Volta_Portugal.Pessoa P ON D.UCI_ID = P.UCI_ID
                "; // completar com view ou join

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DiretorDesportivo dd = new DiretorDesportivo();
                                // verificar Null
                                dd.UciId = reader.GetInt32(0);
                                dd.Nome = reader.GetString(1);
                                dd.Nacionalidade = reader.GetString(2);
                                if (reader.IsDBNull(3))
                                {
                                    dd.DataNascimento = null;
                                }
                                else
                                {
                                    dd.DataNascimento = reader.GetDateTime(3);
                                }


                                list.Add(dd);
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

        public List<DiretorDesportivo> searchDD(String nome)
        {
            var lista = new List<DiretorDesportivo>();
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionGlobal))
                {
                    connection.Open();
                    string sql = @"
                SELECT 
                    D.UCI_ID,            -- Index 0
                    P.nome,              -- Index 2
                    P.nacionalidade,     -- Index 3
                    P.data_nascimento    -- Index 4
                FROM Volta_Portugal.DiretorDesportivo D
                INNER JOIN Volta_Portugal.Pessoa P ON D.UCI_ID = P.UCI_ID
                WHERE P.nome LIKE @nome"; // completar com view ou join
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DiretorDesportivo dd = new DiretorDesportivo();
                                // verificar Null
                                dd.UciId = reader.GetInt32(0);
                                dd.Nome = reader.GetString(1);
                                dd.Nacionalidade = reader.GetString(2);
                                dd.DataNascimento = reader.IsDBNull(3) ? null : reader.GetDateTime(3);

                                lista.Add(dd);
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
    }
}
