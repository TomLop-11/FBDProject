using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using VoltaPortugal_Forms.Ciclistas;
namespace VoltaPortugal_Forms
{
    public partial class Adicionar_Equipas : MetroForm
    {
        private BindingList<Ciclista> plantel = new BindingList<Ciclista>(); // LISTA DE CICLISTAS SELECIONADOS
        public Adicionar_Equipas()
        {
            InitializeComponent();
            dataGridViewPlantel.DataSource = plantel;
            if (dataGridViewPlantel.Columns["Camisola"] != null) dataGridViewPlantel.Columns["Camisola"].Visible = false;

            if (dataGridViewPlantel.Columns["nome_equipa"] != null) dataGridViewPlantel.Columns["nome_equipa"].Visible = false;

            DataGridViewButtonColumn btnRemover = new DataGridViewButtonColumn();
            btnRemover.Name = "Remover";
            btnRemover.Text = "X";
            btnRemover.HeaderText = "";
            btnRemover.UseColumnTextForButtonValue = true; // Faz com que o "X" apareça em todos os botões
            btnRemover.Width = 30;
            dataGridViewPlantel.Columns.Add(btnRemover);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nomeEquipa = textBoxNomeEquipa.Text;
            string anoFund = textBoxAno.Text;
            string paisOri = textBoxPaís.Text;
            string categoria = comboBoxCatEquipa.SelectedItem?.ToString();

            int idDD = (ComboBoxChooseDD.SelectedValue != null) ? (int)ComboBoxChooseDD.SelectedValue : 0;

            if (string.IsNullOrEmpty(nomeEquipa) ||  string.IsNullOrEmpty(anoFund) || string.IsNullOrEmpty(paisOri) || string.IsNullOrEmpty(categoria) || idDD == 0)
            {
                MessageBox.Show("Preencha os campos de texto e selecione um Diretor");
                return;
            }

            Equipa nova = new Equipa();
            nova.Nome = nomeEquipa;
            nova.ano_fundacao = int.Parse(anoFund);
            nova.Pais = paisOri;
            nova.Categoria = categoria;
            nova.num_ciclistas = plantel.Count;

            List<int> idPlantel = plantel.Select(c => c.UciId).ToList(); // lista dos Ids dos ciclistas

            EquipaRepo repo = new EquipaRepo();
            
            if(repo.CreateEquipa(nova, idPlantel, idDD))
            {
                MessageBox.Show("Equipa guardada e adicionada!");
                this.Hide();
                Form1 menu = new Form1();
                menu.FormClosed += (s, args) => this.Close();
                menu.Show();
            }
            
            //this.Close();



        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            textBoxNomeEquipa.Text = string.Empty;
            textBoxAno.Text = string.Empty;
            textBoxPaís.Text = string.Empty;
            labelChoosedDD.Text = string.Empty;

            comboBoxCatEquipa.SelectedIndex = -1;
            ComboBoxChooseCiclista.SelectedIndex = -1;
            ComboBoxChooseDD.SelectedIndex = -1;

            plantel.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 menu = new Form1();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
        }

        private void btnAddCiclista_Click(object sender, EventArgs e)
        {
            if(ComboBoxChooseCiclista.SelectedItem is Ciclista ciclistaSelecionado)
            {
                bool existe = plantel.Any(c => c.UciId == ciclistaSelecionado.UciId);
                if(!existe)
                {
                    plantel.Add(ciclistaSelecionado);
                }
                else
                {
                    MessageBox.Show("Ciclista já selecionado! Adicione outro...");
                }
            }
            else
            {
                MessageBox.Show("Selecione um ciclista primeiro");
            }
        }

        private void btnAddDD_Click(object sender, EventArgs e)
        {
            if (ComboBoxChooseDD.SelectedItem is DiretorDesportivo dd)
            {
                
                labelChoosedDD.Text = $"{dd.Nome}";
                labelChoosedDD.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Selecione um Diretor Desportivo válido.");
            }
        }

        private void dataGridViewPlantel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPlantel.Columns[e.ColumnIndex].Name == "Remover" && e.RowIndex >= 0)
            {
                var remCiclista = (Ciclista)dataGridViewPlantel.Rows[e.RowIndex].DataBoundItem;
                plantel.Remove(remCiclista);
            }
        }

        private void btnCreateDD_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCiclista_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_Equipas_Load(object sender, EventArgs e)
        {
            try
            {
                CiclistaRepo cicRepo = new CiclistaRepo();
                List<Ciclista> ciclistas = cicRepo.GetCiclistas();

                DiretorDesportivoRepo ddRepo = new DiretorDesportivoRepo();
                List<DiretorDesportivo> ddlistas = ddRepo.GetDD();

                ComboBoxChooseCiclista.DataSource = ciclistas;
                ComboBoxChooseCiclista.DisplayMember = "Nome";
                ComboBoxChooseCiclista.ValueMember = "UciId";
                ComboBoxChooseCiclista.SelectedIndex = -1;

                ComboBoxChooseDD.DataSource = ddlistas;
                ComboBoxChooseDD.DisplayMember = "Nome";
                ComboBoxChooseDD.ValueMember = "UciId";
                ComboBoxChooseDD.SelectedIndex = -1;

                comboBoxCatEquipa.Items.Add("Seleção Nacional");
                comboBoxCatEquipa.Items.Add("UCI WorldTeam");
                comboBoxCatEquipa.Items.Add("UCI ProTeam");
                comboBoxCatEquipa.Items.Add("UCI Continental Team");
                comboBoxCatEquipa.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Carregamento inválido");
            }
            {

            }
        }
    }
}
