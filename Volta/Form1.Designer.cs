namespace Volta
{
    partial class PresentationTable
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentationTable));
            tab = new TabControl();
            tabPage1 = new TabPage();
            deleteCiclista = new Button();
            searchCiclista = new TextBox();
            label3 = new Label();
            editCiclista = new Button();
            dataGridViewCiclistas = new DataGridView();
            tabEquipas = new TabPage();
            deleteEquipa = new Button();
            label2 = new Label();
            searchEquipas = new TextBox();
            buttonEditCiclista = new Button();
            buttonAddCiclista = new Button();
            dataGridViewEquipas = new DataGridView();
            Classificação = new TabPage();
            pesquisaClassi = new Label();
            textBoxClassi = new TextBox();
            cbtipoclassi = new ComboBox();
            dataGridViewClassi = new DataGridView();
            DiretorDesportivo = new TabPage();
            label4 = new Label();
            btnDeleteDD = new Button();
            btnEditDD = new Button();
            searchDD = new TextBox();
            dataGridViewDD = new DataGridView();
            Container = new Panel();
            logoVolta = new PictureBox();
            dropdownEdição = new ComboBox();
            dropdownEtapa = new ComboBox();
            EtapaSelect = new Label();
            label1 = new Label();
            Edição = new Label();
            tab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCiclistas).BeginInit();
            tabEquipas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipas).BeginInit();
            Classificação.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassi).BeginInit();
            DiretorDesportivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDD).BeginInit();
            Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoVolta).BeginInit();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tab.Controls.Add(tabPage1);
            tab.Controls.Add(tabEquipas);
            tab.Controls.Add(Classificação);
            tab.Controls.Add(DiretorDesportivo);
            tab.Location = new Point(195, 12);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(803, 475);
            tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(deleteCiclista);
            tabPage1.Controls.Add(searchCiclista);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(editCiclista);
            tabPage1.Controls.Add(dataGridViewCiclistas);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ciclistas";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // deleteCiclista
            // 
            deleteCiclista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deleteCiclista.Location = new Point(106, 410);
            deleteCiclista.Name = "deleteCiclista";
            deleteCiclista.Size = new Size(94, 29);
            deleteCiclista.TabIndex = 6;
            deleteCiclista.Text = "Eliminar";
            deleteCiclista.UseVisualStyleBackColor = true;
            // 
            // searchCiclista
            // 
            searchCiclista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchCiclista.Location = new Point(492, 14);
            searchCiclista.Name = "searchCiclista";
            searchCiclista.Size = new Size(297, 27);
            searchCiclista.TabIndex = 5;
            searchCiclista.TextChanged += searchCiclista_TextChanged;
            searchCiclista.KeyDown += searchCiclista_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 17);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Pesquisa";
            // 
            // editCiclista
            // 
            editCiclista.Location = new Point(6, 410);
            editCiclista.Name = "editCiclista";
            editCiclista.Size = new Size(94, 29);
            editCiclista.TabIndex = 2;
            editCiclista.Text = "Editar";
            editCiclista.UseVisualStyleBackColor = true;
            editCiclista.Click += editCiclista_Click;
            // 
            // dataGridViewCiclistas
            // 
            dataGridViewCiclistas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCiclistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCiclistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCiclistas.Location = new Point(6, 50);
            dataGridViewCiclistas.Name = "dataGridViewCiclistas";
            dataGridViewCiclistas.RowHeadersWidth = 51;
            dataGridViewCiclistas.Size = new Size(783, 354);
            dataGridViewCiclistas.TabIndex = 0;
            dataGridViewCiclistas.CellContentClick += dataGridViewCiclistas_CellContentClick;
            // 
            // tabEquipas
            // 
            tabEquipas.Controls.Add(deleteEquipa);
            tabEquipas.Controls.Add(label2);
            tabEquipas.Controls.Add(searchEquipas);
            tabEquipas.Controls.Add(buttonEditCiclista);
            tabEquipas.Controls.Add(buttonAddCiclista);
            tabEquipas.Controls.Add(dataGridViewEquipas);
            tabEquipas.Location = new Point(4, 29);
            tabEquipas.Name = "tabEquipas";
            tabEquipas.Padding = new Padding(3);
            tabEquipas.Size = new Size(795, 442);
            tabEquipas.TabIndex = 1;
            tabEquipas.Text = "Equipas";
            tabEquipas.UseVisualStyleBackColor = true;
            // 
            // deleteEquipa
            // 
            deleteEquipa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deleteEquipa.Location = new Point(206, 410);
            deleteEquipa.Name = "deleteEquipa";
            deleteEquipa.Size = new Size(94, 29);
            deleteEquipa.TabIndex = 7;
            deleteEquipa.Text = "Eliminar";
            deleteEquipa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 16);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Pesquisa";
            // 
            // searchEquipas
            // 
            searchEquipas.Location = new Point(492, 13);
            searchEquipas.Name = "searchEquipas";
            searchEquipas.Size = new Size(297, 27);
            searchEquipas.TabIndex = 4;
            searchEquipas.KeyDown += searchEquipas_KeyDown;
            // 
            // buttonEditCiclista
            // 
            buttonEditCiclista.Location = new Point(106, 410);
            buttonEditCiclista.Name = "buttonEditCiclista";
            buttonEditCiclista.Size = new Size(94, 29);
            buttonEditCiclista.TabIndex = 3;
            buttonEditCiclista.Text = "Editar";
            buttonEditCiclista.UseVisualStyleBackColor = true;
            // 
            // buttonAddCiclista
            // 
            buttonAddCiclista.Location = new Point(6, 410);
            buttonAddCiclista.Name = "buttonAddCiclista";
            buttonAddCiclista.Size = new Size(94, 29);
            buttonAddCiclista.TabIndex = 2;
            buttonAddCiclista.Text = "Adicionar";
            buttonAddCiclista.UseVisualStyleBackColor = true;
            buttonAddCiclista.Click += addCiclista_Click;
            // 
            // dataGridViewEquipas
            // 
            dataGridViewEquipas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEquipas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipas.Location = new Point(6, 50);
            dataGridViewEquipas.Name = "dataGridViewEquipas";
            dataGridViewEquipas.RowHeadersWidth = 51;
            dataGridViewEquipas.Size = new Size(783, 354);
            dataGridViewEquipas.TabIndex = 1;
            dataGridViewEquipas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Classificação
            // 
            Classificação.Controls.Add(pesquisaClassi);
            Classificação.Controls.Add(textBoxClassi);
            Classificação.Controls.Add(cbtipoclassi);
            Classificação.Controls.Add(dataGridViewClassi);
            Classificação.Location = new Point(4, 29);
            Classificação.Name = "Classificação";
            Classificação.Padding = new Padding(3);
            Classificação.Size = new Size(795, 442);
            Classificação.TabIndex = 2;
            Classificação.Text = "Classificação";
            Classificação.UseVisualStyleBackColor = true;
            // 
            // pesquisaClassi
            // 
            pesquisaClassi.AutoSize = true;
            pesquisaClassi.Location = new Point(427, 25);
            pesquisaClassi.Name = "pesquisaClassi";
            pesquisaClassi.Size = new Size(65, 20);
            pesquisaClassi.TabIndex = 3;
            pesquisaClassi.Text = "Pesquisa";
            // 
            // textBoxClassi
            // 
            textBoxClassi.Location = new Point(492, 22);
            textBoxClassi.Name = "textBoxClassi";
            textBoxClassi.Size = new Size(297, 27);
            textBoxClassi.TabIndex = 2;
            // 
            // cbtipoclassi
            // 
            cbtipoclassi.FormattingEnabled = true;
            cbtipoclassi.Location = new Point(6, 22);
            cbtipoclassi.Name = "cbtipoclassi";
            cbtipoclassi.Size = new Size(151, 28);
            cbtipoclassi.TabIndex = 1;
            // 
            // dataGridViewClassi
            // 
            dataGridViewClassi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClassi.Location = new Point(6, 74);
            dataGridViewClassi.Name = "dataGridViewClassi";
            dataGridViewClassi.RowHeadersWidth = 51;
            dataGridViewClassi.Size = new Size(783, 362);
            dataGridViewClassi.TabIndex = 0;
            // 
            // DiretorDesportivo
            // 
            DiretorDesportivo.Controls.Add(label4);
            DiretorDesportivo.Controls.Add(btnDeleteDD);
            DiretorDesportivo.Controls.Add(btnEditDD);
            DiretorDesportivo.Controls.Add(searchDD);
            DiretorDesportivo.Controls.Add(dataGridViewDD);
            DiretorDesportivo.Location = new Point(4, 29);
            DiretorDesportivo.Name = "DiretorDesportivo";
            DiretorDesportivo.Padding = new Padding(3);
            DiretorDesportivo.Size = new Size(795, 442);
            DiretorDesportivo.TabIndex = 3;
            DiretorDesportivo.Text = "DiretorDesportivo";
            DiretorDesportivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 19);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Pesquisa";
            // 
            // btnDeleteDD
            // 
            btnDeleteDD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteDD.Location = new Point(106, 407);
            btnDeleteDD.Name = "btnDeleteDD";
            btnDeleteDD.Size = new Size(94, 29);
            btnDeleteDD.TabIndex = 7;
            btnDeleteDD.Text = "Eliminar";
            btnDeleteDD.UseVisualStyleBackColor = true;
            // 
            // btnEditDD
            // 
            btnEditDD.Location = new Point(6, 407);
            btnEditDD.Name = "btnEditDD";
            btnEditDD.Size = new Size(94, 29);
            btnEditDD.TabIndex = 6;
            btnEditDD.Text = "Editar";
            btnEditDD.UseVisualStyleBackColor = true;
            // 
            // searchDD
            // 
            searchDD.Location = new Point(492, 16);
            searchDD.Name = "searchDD";
            searchDD.Size = new Size(297, 27);
            searchDD.TabIndex = 5;
            searchDD.KeyDown += searchDD_KeyDown;
            // 
            // dataGridViewDD
            // 
            dataGridViewDD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDD.Location = new Point(6, 49);
            dataGridViewDD.Name = "dataGridViewDD";
            dataGridViewDD.RowHeadersWidth = 51;
            dataGridViewDD.Size = new Size(783, 354);
            dataGridViewDD.TabIndex = 2;
            // 
            // Container
            // 
            Container.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Container.Controls.Add(logoVolta);
            Container.Controls.Add(dropdownEdição);
            Container.Controls.Add(dropdownEtapa);
            Container.Controls.Add(EtapaSelect);
            Container.Controls.Add(label1);
            Container.Controls.Add(Edição);
            Container.Location = new Point(12, 12);
            Container.Name = "Container";
            Container.Size = new Size(177, 471);
            Container.TabIndex = 1;
            // 
            // logoVolta
            // 
            logoVolta.Image = (Image)resources.GetObject("logoVolta.Image");
            logoVolta.Location = new Point(0, 0);
            logoVolta.Name = "logoVolta";
            logoVolta.Size = new Size(79, 79);
            logoVolta.TabIndex = 7;
            logoVolta.TabStop = false;
            // 
            // dropdownEdição
            // 
            dropdownEdição.FormattingEnabled = true;
            dropdownEdição.Location = new Point(13, 126);
            dropdownEdição.Name = "dropdownEdição";
            dropdownEdição.Size = new Size(151, 28);
            dropdownEdição.TabIndex = 6;
            dropdownEdição.SelectedIndexChanged += dropdownEdição_SelectedIndexChanged;
            // 
            // dropdownEtapa
            // 
            dropdownEtapa.FormattingEnabled = true;
            dropdownEtapa.Location = new Point(13, 347);
            dropdownEtapa.Name = "dropdownEtapa";
            dropdownEtapa.Size = new Size(151, 28);
            dropdownEtapa.TabIndex = 4;
            dropdownEtapa.SelectedIndexChanged += dropdownEtapa_SelectedIndexChanged;
            // 
            // EtapaSelect
            // 
            EtapaSelect.AutoSize = true;
            EtapaSelect.Location = new Point(13, 324);
            EtapaSelect.Name = "EtapaSelect";
            EtapaSelect.Size = new Size(47, 20);
            EtapaSelect.TabIndex = 3;
            EtapaSelect.Text = "Etapa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 185);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // Edição
            // 
            Edição.AutoSize = true;
            Edição.Location = new Point(13, 103);
            Edição.Name = "Edição";
            Edição.Size = new Size(87, 20);
            Edição.TabIndex = 0;
            Edição.Text = "Ano/Edição";
            // 
            // PresentationTable
            // 
            ClientSize = new Size(1010, 499);
            Controls.Add(Container);
            Controls.Add(tab);
            Name = "PresentationTable";
            Load += PresentationTable_Load;
            tab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCiclistas).EndInit();
            tabEquipas.ResumeLayout(false);
            tabEquipas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipas).EndInit();
            Classificação.ResumeLayout(false);
            Classificação.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassi).EndInit();
            DiretorDesportivo.ResumeLayout(false);
            DiretorDesportivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDD).EndInit();
            Container.ResumeLayout(false);
            Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoVolta).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TabControl tab;
        private TabPage tabPage1;
        private DataGridView dataGridViewCiclistas;
        private TabPage tabEquipas;
        private Button editCiclista;
        private Panel Container;
        private Label EtapaSelect;
        private Label label1;
        private Label Edição;
        private ComboBox dropdownEdição;
        private ComboBox dropdownEtapa;
        private PictureBox logoVolta;
        private Button buttonEditCiclista;
        private Button buttonAddCiclista;
        private DataGridView dataGridViewEquipas;
        private TabPage Classificação;
        private Label pesquisaClassi;
        private TextBox textBoxClassi;
        private ComboBox cbtipoclassi;
        private DataGridView dataGridViewClassi;
        private TextBox searchCiclista;
        private Label label3;
        private Label label2;
        private TextBox searchEquipas;
        private TabPage DiretorDesportivo;
        private Button deleteCiclista;
        private Button deleteEquipa;
        private TextBox searchDD;
        private DataGridView dataGridViewDD;
        private Button btnDeleteDD;
        private Button btnEditDD;
        private Label label4;
    }
}
