using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace VoltaPortugal_Forms.Ciclistas
{
    public class CompeticaoRepo
    {
        public List<Competição> GetEdicao()
        {
            List<Competição> list = new List<Competição>();
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionGlobal))
                {
                    connection.Open();
                    // mudar para sp
                    string sql = @"
                        SELECT ID,
                            CAST(YEAR(data_inicio) AS VARCHAR) + ' - ' + nome AS NomeCompleto
                        FROM Volta_Portugal.Competicao 
                        ORDER BY data_inicio DESC";

                    using(SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Competição comp = new Competição();
                                comp.id = (int)reader["ID"];
                                comp.nome = reader["NomeCompleto"].ToString();
                                list.Add(comp);
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

        public List<Etapa> GetEtapas(int compId)
        {
            List<Etapa> list = new List<Etapa>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Global.ConnectionString))
                {
                    conn.Open();
                    string sql = @"SELECT E.ID, E.num_etapa, E.distancia, E.duracao 
                           FROM Volta_Portugal.Etapa E
                           INNER JOIN Volta_Portugal.Inclui I ON E.ID = I.ID_Etapa
                           WHERE I.ID_competicao = @compId 
                           ORDER BY E.num_etapa ASC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@compId", compId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Etapa etapa = new Etapa();
                                etapa.id = Convert.ToInt32(reader["ID"]);
                                etapa.num_etapa = Convert.ToInt32(reader["num_etapa"]);
                                etapa.distancia = (float)Convert.ToDouble(reader["distancia"]);

                               
                                TimeSpan tempo = (TimeSpan)reader["duracao"];
                                etapa.duração = DateTime.Today.Add(tempo);

                                list.Add(etapa);
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
    }
}
