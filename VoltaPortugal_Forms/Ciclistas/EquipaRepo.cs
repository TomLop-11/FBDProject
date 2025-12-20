using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

    }
}
