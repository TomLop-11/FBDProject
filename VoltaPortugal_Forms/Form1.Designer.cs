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
            this.dataGridViewCiclistas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditCiclistas = new System.Windows.Forms.Button();
            this.btnDeleteCiclistas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCiclista = new System.Windows.Forms.TextBox();
            this.dropdownEdição = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewEquipas = new System.Windows.Forms.DataGridView();
            this.searchEquipas = new System.Windows.Forms.TextBox();
            this.dataGridViewDD = new System.Windows.Forms.DataGridView();
            this.btnEditDD = new System.Windows.Forms.Button();
            this.btnDeleteDD = new System.Windows.Forms.Button();
            this.searchDD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditEquipa = new System.Windows.Forms.Button();
            this.btnAddEquipa = new System.Windows.Forms.Button();
            this.btnDeleteEquipa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCiclistas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDD)).BeginInit();
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
            this.tabPage1.Controls.Add(this.btnDeleteCiclistas);
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
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnDeleteEquipa);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.searchDD);
            this.tabPage3.Controls.Add(this.btnDeleteDD);
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(748, 438);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(748, 438);
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
            // btnDeleteCiclistas
            // 
            this.btnDeleteCiclistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCiclistas.Location = new System.Drawing.Point(90, 406);
            this.btnDeleteCiclistas.Name = "btnDeleteCiclistas";
            this.btnDeleteCiclistas.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteCiclistas.TabIndex = 2;
            this.btnDeleteCiclistas.Text = "Eliminar";
            this.btnDeleteCiclistas.UseVisualStyleBackColor = true;
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
            // dropdownEdição
            // 
            this.dropdownEdição.FormattingEnabled = true;
            this.dropdownEdição.Location = new System.Drawing.Point(20, 168);
            this.dropdownEdição.Name = "dropdownEdição";
            this.dropdownEdição.Size = new System.Drawing.Size(156, 24);
            this.dropdownEdição.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 96);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // btnDeleteDD
            // 
            this.btnDeleteDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDD.Location = new System.Drawing.Point(90, 406);
            this.btnDeleteDD.Name = "btnDeleteDD";
            this.btnDeleteDD.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteDD.TabIndex = 3;
            this.btnDeleteDD.Text = "Eliminar";
            this.btnDeleteDD.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesquisa";
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
            // 
            // btnDeleteEquipa
            // 
            this.btnDeleteEquipa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEquipa.Location = new System.Drawing.Point(174, 406);
            this.btnDeleteEquipa.Name = "btnDeleteEquipa";
            this.btnDeleteEquipa.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteEquipa.TabIndex = 8;
            this.btnDeleteEquipa.Text = "Eliminar";
            this.btnDeleteEquipa.UseVisualStyleBackColor = true;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDD)).EndInit();
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
        private System.Windows.Forms.Button btnDeleteCiclistas;
        private System.Windows.Forms.Button btnEditCiclistas;
        private System.Windows.Forms.ComboBox dropdownEdição;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchEquipas;
        private System.Windows.Forms.DataGridView dataGridViewEquipas;
        private System.Windows.Forms.DataGridView dataGridViewDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchDD;
        private System.Windows.Forms.Button btnDeleteDD;
        private System.Windows.Forms.Button btnEditDD;
        private System.Windows.Forms.Button btnAddEquipa;
        private System.Windows.Forms.Button btnEditEquipa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteEquipa;
    }
}

