using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoltaPortugal_Forms.Ciclistas
{
    public class Classificação
    {
        public DataTable GetClassificacao(int idEtapa, string categoria)
        {
            DataTable dt = new DataTable();
            bool catEquipas = (categoria == "Geral Equipas");
            
            // colunas
            dt.Columns.Add("Posição");
            if (!catEquipas) dt.Columns.Add("Ciclista");
            dt.Columns.Add("Equipa");
            dt.Columns.Add("Tempo");

            using (SqlConnection conn = new SqlConnection(Global.ConnectionString))
            {
                conn.Open();
                string sql = "";

                if (idEtapa == -1) // Classificação Geral (Todas as etapas)
                {
                    if (catEquipas)
                    {
                        
                        sql = @"SELECT 
                    RANK() OVER (ORDER BY SUM(DATEDIFF(SECOND, '00:00:00', RE.tempofinal)) ASC) AS Posicao,
                    E.nome AS Equipa,
                    CONVERT(VARCHAR, DATEADD(SECOND, SUM(DATEDIFF(SECOND, '00:00:00', RE.tempofinal)), '00:00:00'), 108) AS TempoTotal
                FROM Volta_Portugal.ResultadoEtapa RE
                JOIN Volta_Portugal.Pessoa P ON RE.UCI_ID_ciclista = P.UCI_ID
                JOIN Volta_Portugal.Pertence Per ON P.UCI_ID = Per.UCI_ID_Ciclista
                JOIN Volta_Portugal.Equipa E ON Per.ID_equipa = E.ID
                JOIN Volta_Portugal.Categoria_Classificacao CC ON RE.ID_classificacao = CC.ID_classificacao
                WHERE CC.categoria = @cat
                GROUP BY E.nome";
                    }
                    else
                    {
                        sql = @"SELECT 
                    RANK() OVER (ORDER BY SUM(DATEDIFF(SECOND, '00:00:00', RE.tempofinal)) ASC) AS Posicao,
                    P.nome AS Ciclista,
                    E.nome AS Equipa,
                    CONVERT(VARCHAR, DATEADD(SECOND, SUM(DATEDIFF(SECOND, '00:00:00', RE.tempofinal)), '00:00:00'), 108) AS TempoTotal
                FROM Volta_Portugal.ResultadoEtapa RE
                JOIN Volta_Portugal.Pessoa P ON RE.UCI_ID_ciclista = P.UCI_ID
                JOIN Volta_Portugal.Pertence Per ON P.UCI_ID = Per.UCI_ID_Ciclista
                JOIN Volta_Portugal.Equipa E ON Per.ID_equipa = E.ID
                JOIN Volta_Portugal.Categoria_Classificacao CC ON RE.ID_classificacao = CC.ID_classificacao
                WHERE CC.categoria = @cat
                GROUP BY P.nome, E.nome";
                    }
                }
                else // Classificação de uma etapa específica
                {
                    if (catEquipas)
                    {
                        sql = @"SELECT 
                    RANK() OVER (ORDER BY SUM(DATEDIFF(SECOND, '00:00:00', RE.tempofinal)) ASC) AS Posicao,
                    E.nome AS Equipa,
                    CONVERT(VARCHAR, DATEADD(SECOND, SUM(DATEDIFF(SECOND, '00:00:00', RE.tempofinal)), '00:00:00'), 108) AS Tempo
                FROM Volta_Portugal.ResultadoEtapa RE
                JOIN Volta_Portugal.Pessoa P ON RE.UCI_ID_ciclista = P.UCI_ID
                JOIN Volta_Portugal.Pertence Per ON P.UCI_ID = Per.UCI_ID_Ciclista
                JOIN Volta_Portugal.Equipa E ON Per.ID_equipa = E.ID
                JOIN Volta_Portugal.Categoria_Classificacao CC ON RE.ID_classificacao = CC.ID_classificacao
                WHERE RE.ID_etapa = @idEtapa AND CC.categoria = @cat
                GROUP BY E.nome";
                    }
                    else
                    {
                        sql = @"SELECT 
                    C.posicao AS Posicao,
                    P.nome AS Ciclista,
                    E.nome AS Equipa,
                    CONVERT(VARCHAR, RE.tempofinal, 108) AS Tempo
                FROM Volta_Portugal.ResultadoEtapa RE
                JOIN Volta_Portugal.Classificacao C ON RE.ID_classificacao = C.ID
                JOIN Volta_Portugal.Categoria_Classificacao CC ON C.ID = CC.ID_classificacao
                JOIN Volta_Portugal.Pessoa P ON RE.UCI_ID_ciclista = P.UCI_ID
                JOIN Volta_Portugal.Pertence Per ON P.UCI_ID = Per.UCI_ID_Ciclista
                JOIN Volta_Portugal.Equipa E ON Per.ID_equipa = E.ID
                WHERE RE.ID_etapa = @idEtapa AND CC.categoria = @cat
                ORDER BY C.posicao ASC";
                    }
                }
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cat", categoria);
                    if (idEtapa != -1)
                    {
                        cmd.Parameters.AddWithValue("@idEtapa", idEtapa);
                    }

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            // linhas
                            DataRow row = dt.NewRow();
                            row["Posição"] = reader["Posicao"];
                            if(!catEquipas) row["Ciclista"] = reader["Ciclista"];
                            row["Equipa"] = reader["Equipa"];

                            if (idEtapa == -1)
                            {
                                row["Tempo"] = reader["TempoTotal"];
                            } else
                            {
                                row["Tempo"] = reader["Tempo"];
                            }
                            dt.Rows.Add(row);
                        }
                    }
                }
            }

            return dt;
        }
    }
}
