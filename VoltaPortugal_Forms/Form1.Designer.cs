namespace VoltaPortugal_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchCiclista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditCiclistas = new System.Windows.Forms.Button();
            this.dataGridViewCiclistas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddEquipa = new System.Windows.Forms.Button();
            this.btnEditEquipa = new System.Windows.Forms.Button();
            this.searchEquipas = new System.Windows.Forms.TextBox();
            this.dataGridViewEquipas = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.searchDD = new System.Windows.Forms.TextBox();
            this.btnEditDD = new System.Windows.Forms.Button();
            this.dataGridViewDD = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropdownEdição = new System.Windows.Forms.ComboBox();
            this.dataGridViewClassi = new System.Windows.Forms.DataGridView();
            this.comboBoxEtapas = new MetroFramework.Controls.MetroComboBox();
            this.textBoxsearchClassi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCatClassi = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiclistas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDD)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(218, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchCiclista);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnEditCiclistas);
            this.tabPage1.Controls.Add(this.dataGridViewCiclistas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ciclistas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchCiclista
            // 
            this.searchCiclista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCiclista.Location = new System.Drawing.Point(447, 24);
            this.searchCiclista.Name = "searchCiclista";
            this.searchCiclista.Size = new System.Drawing.Size(313, 22);
            this.searchCiclista.TabIndex = 4;
            this.searchCiclista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchCiclista_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisa";
            // 
            // btnEditCiclistas
            // 
            this.btnEditCiclistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCiclistas.Location = new System.Drawing.Point(6, 406);
            this.btnEditCiclistas.Name = "btnEditCiclistas";
            this.btnEditCiclistas.Size = new System.Drawing.Size(78, 29);
            this.btnEditCiclistas.TabIndex = 1;
            this.btnEditCiclistas.Text = "Editar";
            this.btnEditCiclistas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCiclistas
            // 
            this.dataGridViewCiclistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCiclistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCiclistas.Location = new System.Drawing.Point(6, 62);
            this.dataGridViewCiclistas.Name = "dataGridViewCiclistas";
            this.dataGridViewCiclistas.RowHeadersWidth = 51;
            this.dataGridViewCiclistas.RowTemplate.Height = 24;
            this.dataGridViewCiclistas.Size = new System.Drawing.Size(754, 341);
            this.dataGridViewCiclistas.TabIndex = 0;
            this.dataGridViewCiclistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCiclistas_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnAddEquipa);
            this.tabPage2.Controls.Add(this.btnEditEquipa);
            this.tabPage2.Controls.Add(this.searchEquipas);
            this.tabPage2.Controls.Add(this.dataGridViewEquipas);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equipas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pesquisa";
            // 
            // btnAddEquipa
            // 
            this.btnAddEquipa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEquipa.Location = new System.Drawing.Point(6, 406);
            this.btnAddEquipa.Name = "btnAddEquipa";
            this.btnAddEquipa.Size = new System.Drawing.Size(78, 29);
            this.btnAddEquipa.TabIndex = 7;
            this.btnAddEquipa.Text = "Adicionar";
            this.btnAddEquipa.UseVisualStyleBackColor = true;
            this.btnAddEquipa.Click += new System.EventHandler(this.btnAddEquipa_Click);
            // 
            // btnEditEquipa
            // 
            this.btnEditEquipa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEquipa.Location = new System.Drawing.Point(90, 406);
            this.btnEditEquipa.Name = "btnEditEquipa";
            this.btnEditEquipa.Size = new System.Drawing.Size(78, 29);
            this.btnEditEquipa.TabIndex = 6;
            this.btnEditEquipa.Text = "Editar";
            this.btnEditEquipa.UseVisualStyleBackColor = true;
            // 
            // searchEquipas
            // 
            this.searchEquipas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchEquipas.Location = new System.Drawing.Point(447, 19);
            this.searchEquipas.Name = "searchEquipas";
            this.searchEquipas.Size = new System.Drawing.Size(313, 22);
            this.searchEquipas.TabIndex = 5;
            this.searchEquipas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchEquipas_KeyDown);
            // 
            // dataGridViewEquipas
            // 
            this.dataGridViewEquipas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEquipas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipas.Location = new System.Drawing.Point(6, 62);
            this.dataGridViewEquipas.Name = "dataGridViewEquipas";
            this.dataGridViewEquipas.RowHeadersWidth = 51;
            this.dataGridViewEquipas.RowTemplate.Height = 24;
            this.dataGridViewEquipas.Size = new System.Drawing.Size(754, 341);
            this.dataGridViewEquipas.TabIndex = 1;
            this.dataGridViewEquipas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipas_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.searchDD);
            this.tabPage3.Controls.Add(this.btnEditDD);
            this.tabPage3.Controls.Add(this.dataGridViewDD);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(766, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DiretorDesportivo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesquisa";
            // 
            // searchDD
            // 
            this.searchDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDD.Location = new System.Drawing.Point(447, 25);
            this.searchDD.Name = "searchDD";
            this.searchDD.Size = new System.Drawing.Size(313, 22);
            this.searchDD.TabIndex = 5;
            this.searchDD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchDD_KeyDown);
            // 
            // btnEditDD
            // 
            this.btnEditDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDD.Location = new System.Drawing.Point(6, 406);
            this.btnEditDD.Name = "btnEditDD";
            this.btnEditDD.Size = new System.Drawing.Size(78, 29);
            this.btnEditDD.TabIndex = 2;
            this.btnEditDD.Text = "Editar";
            this.btnEditDD.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDD
            // 
            this.dataGridViewDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDD.Location = new System.Drawing.Point(6, 62);
            this.dataGridViewDD.Name = "dataGridViewDD";
            this.dataGridViewDD.RowHeadersWidth = 51;
            this.dataGridViewDD.RowTemplate.Height = 24;
            this.dataGridViewDD.Size = new System.Drawing.Size(754, 341);
            this.dataGridViewDD.TabIndex = 1;
            this.dataGridViewDD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDD_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.comboBoxCatClassi);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.textBoxsearchClassi);
            this.tabPage4.Controls.Add(this.comboBoxEtapas);
            this.tabPage4.Controls.Add(this.dataGridViewClassi);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(766, 438);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Classificação";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(766, 438);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dropdownEdição);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 463);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 96);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano/Edição";
            // 
            // dropdownEdição
            // 
            this.dropdownEdição.FormattingEnabled = true;
            this.dropdownEdição.Location = new System.Drawing.Point(20, 168);
            this.dropdownEdição.Name = "dropdownEdição";
            this.dropdownEdição.Size = new System.Drawing.Size(156, 24);
            this.dropdownEdição.TabIndex = 0;
            // 
            // dataGridViewClassi
            // 
            this.dataGridViewClassi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClassi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassi.Location = new System.Drawing.Point(6, 84);
            this.dataGridViewClassi.Name = "dataGridViewClassi";
            this.dataGridViewClassi.RowHeadersWidth = 51;
            this.dataGridViewClassi.RowTemplate.Height = 24;
            this.dataGridViewClassi.Size = new System.Drawing.Size(754, 348);
            this.dataGridViewClassi.TabIndex = 2;
            // 
            // comboBoxEtapas
            // 
            this.comboBoxEtapas.FormattingEnabled = true;
            this.comboBoxEtapas.ItemHeight = 24;
            this.comboBoxEtapas.Location = new System.Drawing.Point(214, 33);
            this.comboBoxEtapas.Name = "comboBoxEtapas";
            this.comboBoxEtapas.Size = new System.Drawing.Size(181, 30);
            this.comboBoxEtapas.TabIndex = 4;
            this.comboBoxEtapas.UseSelectable = true;
            // 
            // textBoxsearchClassi
            // 
            this.textBoxsearchClassi.Location = new System.Drawing.Point(526, 33);
            this.textBoxsearchClassi.Name = "textBoxsearchClassi";
            this.textBoxsearchClassi.Size = new System.Drawing.Size(234, 22);
            this.textBoxsearchClassi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Etapas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pesquisa:";
            // 
            // comboBoxCatClassi
            // 
            this.comboBoxCatClassi.FormattingEnabled = true;
            this.comboBoxCatClassi.ItemHeight = 24;
            this.comboBoxCatClassi.Location = new System.Drawing.Point(8, 33);
            this.comboBoxCatClassi.Name = "comboBoxCatClassi";
            this.comboBoxCatClassi.Size = new System.Drawing.Size(147, 30);
            this.comboBoxCatClassi.TabIndex = 8;
            this.comboBoxCatClassi.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Categoria:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiclistas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDD)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCiclistas;
        private System.Windows.Forms.TextBox searchCiclista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditCiclistas;
        private System.Windows.Forms.ComboBox dropdownEdição;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchEquipas;
        private System.Windows.Forms.DataGridView dataGridViewEquipas;
        private System.Windows.Forms.DataGridView dataGridViewDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchDD;
        private System.Windows.Forms.Button btnEditDD;
        private System.Windows.Forms.Button btnAddEquipa;
        private System.Windows.Forms.Button btnEditEquipa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewClassi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxsearchClassi;
        private MetroFramework.Controls.MetroComboBox comboBoxEtapas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox comboBoxCatClassi;
    }
}

