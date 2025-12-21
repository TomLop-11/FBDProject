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

            DataGridViewButtonColumn btnRemover = new DataGridViewButtonColumn();
            btnRemover.Name = "Remover";
            btnRemover.Text = "X";
            btnRemover.HeaderText = "";
            btnRemover.UseColumnTextForButtonValue = true; // Faz com que o "X" apareça em todos os botões
            btnRemover.Width = 30;
            dataGridViewCiclistas.Columns.Add(btnRemover);

            DataGridViewButtonColumn btnRemoverDD = new DataGridViewButtonColumn();
            btnRemoverDD.Name = "Remover";
            btnRemoverDD.Text = "X";
            btnRemoverDD.HeaderText = "";
            btnRemoverDD.UseColumnTextForButtonValue = true; // Faz com que o "X" apareça em todos os botões
            btnRemoverDD.Width = 30;
            dataGridViewDD.Columns.Add(btnRemoverDD);

            DataGridViewButtonColumn btnRemoverE = new DataGridViewButtonColumn();
            btnRemoverE.Name = "Remover";
            btnRemoverE.Text = "X";
            btnRemoverE.HeaderText = "";
            btnRemoverE.UseColumnTextForButtonValue = true; // Faz com que o "X" apareça em todos os botões
            btnRemoverE.Width = 30;
            dataGridViewEquipas.Columns.Add(btnRemoverE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadCiclistas();
            LoadEdition();
            ReadEquipas();
            ReadDD();
            LoadCategorias();
            LoadClassificacao();
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
                row["Categoria"] = equip.Categoria;

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
            dropdownEdição.DisplayMember = "nome"; 
            dropdownEdição.ValueMember = "id"; 

            

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

        private void btnAddEquipa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionar_Equipas menu = new Adicionar_Equipas();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
        }

        private void dataGridViewCiclistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewCiclistas.Columns[e.ColumnIndex].Name == "Remover" && e.RowIndex >= 0)
            {
                int uciId = Convert.ToInt32(dataGridViewCiclistas.Rows[e.RowIndex].Cells["UCI ID"].Value);
                string nome = dataGridViewCiclistas.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                try
                {
                    
                    CiclistaRepo repo = new CiclistaRepo();
                    if (repo.DeleteCiclista(uciId))
                    {
                        MessageBox.Show("Ciclista removido com sucesso!");
                        ReadCiclistas(); // Atualiza a lista
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Erro ao apagar");
                }
            }
        }

        private void dataGridViewDD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDD.Columns[e.ColumnIndex].Name == "Remover" && e.RowIndex >= 0)
            {
                int uciId = Convert.ToInt32(dataGridViewDD.Rows[e.RowIndex].Cells["UCI ID"].Value);
                string nome = dataGridViewDD.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                try
                {

                    DiretorDesportivoRepo repo = new DiretorDesportivoRepo();
                    if (repo.DeleteDD(uciId))
                    {
                        MessageBox.Show("Diretor removido com sucesso!");
                        ReadDD(); // Atualiza a lista
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Erro ao apagar");
                }
            }
        }

        private void dataGridViewEquipas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDD.Columns[e.ColumnIndex].Name == "Remover" && e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(dataGridViewEquipas.Rows[e.RowIndex].Cells["ID"].Value);
                string nome = dataGridViewEquipas.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                try
                {

                    EquipaRepo repo = new EquipaRepo();
                    if (repo.DeleteEquipa(Id))
                    {
                        MessageBox.Show("Equipa removido com sucesso!");
                        ReadEquipas(); // Atualiza a lista
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Erro ao apagar");
                }
            }
        }

        private void LoadCategorias()
        {
            comboBoxCatClassi.Items.Add("Geral Individual");
            comboBoxCatClassi.Items.Add("Geral Equipas");
            comboBoxCatClassi.Items.Add("Juventude");
            comboBoxCatClassi.SelectedIndex = 0; // por default, Geral Individual

        }

        private void LoadClassificacao()
        {
            if(comboBoxEtapas.SelectedValue is int idEtapa && comboBoxCatClassi.SelectedItem != null)
            {
                Classificação classi = new Classificação();

                string categoria = comboBoxCatClassi.SelectedItem.ToString();

                dataGridViewClassi.DataSource = classi.GetClassificacao(idEtapa, categoria);
            }
        }

        private void dropdownEdição_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownEdição.SelectedValue is int compId)
            {
                CompeticaoRepo repo = new CompeticaoRepo();
                var etapas = repo.GetEtapas(compId);

                var lista = new List<Object>();
                string label = "";

                lista.Add(new { ID = -1, Texto = "Total - Todas as Etapas" });
                foreach (var item in etapas)
                {
                    if (item.num_etapa == 0 )
                    {
                        label = "Prólogo";
                       

                    }
                    else
                    {
                        label = "Etapa " + item.num_etapa;
                        
                    }
                    lista.Add(new { ID = item.id, Texto = label });
                }

                

                comboBoxEtapas.DisplayMember = "Texto";
                comboBoxEtapas.ValueMember = "ID";
                comboBoxEtapas.DataSource = lista;
            }
        }

        private void comboBoxCatClassi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassificacao();
        }

        private void comboBoxEtapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassificacao();
        }
    }
}
