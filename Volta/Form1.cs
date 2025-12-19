using System.Data;
using Volta.Ciclistas;

namespace Volta
{
    public partial class PresentationTable : Form
    {
        public PresentationTable()
        {
            InitializeComponent();

        }
        private void PresentationTable_Load(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dropdownEdição_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dropdownEquipa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dropdownEtapa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addCiclista_Click(object sender, EventArgs e)
        {

        }

        private void editCiclista_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCiclistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void searchCiclista_TextChanged(object sender, EventArgs e)
        {

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
