using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoltaPortugal_Forms.Ciclistas;

namespace VoltaPortugal_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadCiclistas();
            LoadEdition();
            ReadEquipas();
            ReadDD();
        }

        private void ReadCiclistas()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("UCI ID");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Num Dorsal");
            dataTable.Columns.Add("Nacionalidade");
            dataTable.Columns.Add("Data Nascimento");
            dataTable.Columns.Add("Categoria");
            dataTable.Columns.Add("Equipa");
            dataTable.Columns.Add("Camisola");

            var repo = new CiclistaRepo();
            var list = repo.GetCiclistas();

            foreach (var cic in list)
            {
                var row = dataTable.NewRow();
                row["UCI ID"] = cic.UciId;
                row["Nome"] = cic.Nome;
                row["Num Dorsal"] = cic.NumDorsal;
                row["Nacionalidade"] = cic.Nacionalidade;
                row["Data Nascimento"] = cic.DataNascimento;
                row["Categoria"] = cic.Categoria;
                row["Equipa"] = cic.nome_equipa;
                row["Camisola"] = cic.Camisola;


                dataTable.Rows.Add(row);
            }

            dataGridViewCiclistas.DataSource = dataTable;
        }
        private void ReadEquipas()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("País");
            dataTable.Columns.Add("Num Ciclistas");
            dataTable.Columns.Add("Ano Fundação");
            dataTable.Columns.Add("Categoria");


            var repo = new EquipaRepo();
            var list = repo.GetEquipas();

            foreach (var equip in list)
            {
                var row = dataTable.NewRow();
                row["ID"] = equip.Id;
                row["Nome"] = equip.Nome;
                row["País"] = equip.Pais;
                row["Num Ciclistas"] = equip.num_ciclistas;
                row["Ano Fundação"] = equip.ano_fundacao;

                dataTable.Rows.Add(row);
            }

            dataGridViewEquipas.DataSource = dataTable;
        }

        private void ReadDD()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("UCI ID");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Nacionalidade");
            dataTable.Columns.Add("Data Nascimento");

            var repo = new DiretorDesportivoRepo();
            var list = repo.GetDD();

            foreach (var cic in list)
            {
                var row = dataTable.NewRow();
                row["UCI ID"] = cic.UciId;
                row["Nome"] = cic.Nome;
                row["Nacionalidade"] = cic.Nacionalidade;
                row["Data Nascimento"] = cic.DataNascimento;


                dataTable.Rows.Add(row);
            }

            dataGridViewDD.DataSource = dataTable;
        }

        private void LoadEdition()
        {
            CompeticaoRepo cr = new CompeticaoRepo();
            dropdownEdição.DataSource = cr.GetEdicao();
        }

        private void searchCiclista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string termoPesquisa = searchCiclista.Text;


                if (string.IsNullOrWhiteSpace(termoPesquisa))
                {
                    ReadCiclistas();
                    return;
                }

                // Chama o Repositório para pesquisar
                CiclistaRepo repo = new CiclistaRepo();
                List<Ciclista> resultado = repo.SearchCiclista(termoPesquisa);


                if (resultado != null)
                {

                    dataGridViewCiclistas.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("Nenhum ciclista encontrado com esse nome.");

                }
            }
        }

        private void searchEquipas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string termoPesquisa = searchEquipas.Text;


                if (string.IsNullOrWhiteSpace(termoPesquisa))
                {
                    ReadEquipas();
                    return;
                }

                // Chama o Repositório para pesquisar
                EquipaRepo repo = new EquipaRepo();
                List<Equipa> resultado = repo.searchEquipas(termoPesquisa);


                if (resultado != null)
                {

                    dataGridViewEquipas.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("Nenhuma equipa encontrado com esse nome.");

                }
            }
        }

        private void searchDD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string termoPesquisa = searchDD.Text;


                if (string.IsNullOrWhiteSpace(termoPesquisa))
                {
                    ReadDD();
                    return;
                }

                // Chama o Repositório para pesquisar
                DiretorDesportivoRepo repo = new DiretorDesportivoRepo();
                List<DiretorDesportivo> resultado = repo.searchDD(termoPesquisa);


                if (resultado != null)
                {

                    dataGridViewDD.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("Nenhuma equipa encontrado com esse nome.");

                }
            }
        }
    }
}
