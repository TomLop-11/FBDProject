using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VoltaPortugal_Forms.Ciclistas
{
    public class CompeticaoRepo
    {
        public List<String> GetEdicao()
        {
            List<String> list = new List<String>();
            string connectionGlobal = Global.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionGlobal))
                {
                    connection.Open();
                    // mudar para sp
                    string sql = @"
                        SELECT 
                            CAST(YEAR(data_inicio) AS VARCHAR) + ' - ' + nome AS NomeCompleto
                        FROM Volta_Portugal.Competicao 
                        ORDER BY data_inicio DESC";

                    using(SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(reader["NomeCompleto"].ToString());
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
