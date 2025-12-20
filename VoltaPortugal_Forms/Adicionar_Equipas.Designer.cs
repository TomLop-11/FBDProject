namespace VoltaPortugal_Forms
{
    partial class Adicionar_Equipas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNomeEquipa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDD = new System.Windows.Forms.GroupBox();
            this.labelChoosedDD = new System.Windows.Forms.TextBox();
            this.ChoosedDD = new System.Windows.Forms.Label();
            this.btnCreateDD = new System.Windows.Forms.Button();
            this.btnAddDD = new System.Windows.Forms.Button();
            this.ComboBoxChooseDD = new MetroFramework.Controls.MetroComboBox();
            this.groupBoxPlantel = new System.Windows.Forms.GroupBox();
            this.btnCreateCiclista = new System.Windows.Forms.Button();
            this.btnAddCiclista = new System.Windows.Forms.Button();
            this.ComboBoxChooseCiclista = new MetroFramework.Controls.MetroComboBox();
            this.dataGridViewPlantel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCatEquipa = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRedefinir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.textBoxPaís = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxDD.SuspendLayout();
            this.groupBoxPlantel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlantel)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomeEquipa
            // 
            this.textBoxNomeEquipa.Location = new System.Drawing.Point(141, 84);
            this.textBoxNomeEquipa.Name = "textBoxNomeEquipa";
            this.textBoxNomeEquipa.Size = new System.Drawing.Size(171, 22);
            this.textBoxNomeEquipa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Equipa:";
            // 
            // groupBoxDD
            // 
            this.groupBoxDD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDD.Controls.Add(this.labelChoosedDD);
            this.groupBoxDD.Controls.Add(this.ChoosedDD);
            this.groupBoxDD.Controls.Add(this.btnCreateDD);
            this.groupBoxDD.Controls.Add(this.btnAddDD);
            this.groupBoxDD.Controls.Add(this.ComboBoxChooseDD);
            this.groupBoxDD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDD.Location = new System.Drawing.Point(26, 131);
            this.groupBoxDD.Name = "groupBoxDD";
            this.groupBoxDD.Size = new System.Drawing.Size(946, 69);
            this.groupBoxDD.TabIndex = 2;
            this.groupBoxDD.TabStop = false;
            this.groupBoxDD.Text = " Diretor Desportivo ";
            // 
            // labelChoosedDD
            // 
            this.labelChoosedDD.Enabled = false;
            this.labelChoosedDD.Location = new System.Drawing.Point(449, 23);
            this.labelChoosedDD.Name = "labelChoosedDD";
            this.labelChoosedDD.Size = new System.Drawing.Size(199, 28);
            this.labelChoosedDD.TabIndex = 11;
            // 
            // ChoosedDD
            // 
            this.ChoosedDD.AutoSize = true;
            this.ChoosedDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ChoosedDD.Location = new System.Drawing.Point(330, 30);
            this.ChoosedDD.Name = "ChoosedDD";
            this.ChoosedDD.Size = new System.Drawing.Size(113, 16);
            this.ChoosedDD.TabIndex = 7;
            this.ChoosedDD.Text = "Diretor Escolhido:";
            // 
            // btnCreateDD
            // 
            this.btnCreateDD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateDD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDD.Location = new System.Drawing.Point(832, 21);
            this.btnCreateDD.Name = "btnCreateDD";
            this.btnCreateDD.Size = new System.Drawing.Size(92, 30);
            this.btnCreateDD.TabIndex = 6;
            this.btnCreateDD.Text = "Criar";
            this.btnCreateDD.UseVisualStyleBackColor = true;
            this.btnCreateDD.Click += new System.EventHandler(this.btnCreateDD_Click);
            // 
            // btnAddDD
            // 
            this.btnAddDD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddDD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDD.Location = new System.Drawing.Point(265, 21);
            this.btnAddDD.Name = "btnAddDD";
            this.btnAddDD.Size = new System.Drawing.Size(37, 30);
            this.btnAddDD.TabIndex = 1;
            this.btnAddDD.Text = "+";
            this.btnAddDD.UseVisualStyleBackColor = true;
            this.btnAddDD.Click += new System.EventHandler(this.btnAddDD_Click);
            // 
            // ComboBoxChooseDD
            // 
            this.ComboBoxChooseDD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxChooseDD.FormattingEnabled = true;
            this.ComboBoxChooseDD.ItemHeight = 24;
            this.ComboBoxChooseDD.Location = new System.Drawing.Point(18, 21);
            this.ComboBoxChooseDD.Name = "ComboBoxChooseDD";
            this.ComboBoxChooseDD.Size = new System.Drawing.Size(241, 30);
            this.ComboBoxChooseDD.TabIndex = 0;
            this.ComboBoxChooseDD.UseSelectable = true;
            // 
            // groupBoxPlantel
            // 
            this.groupBoxPlantel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlantel.Controls.Add(this.btnCreateCiclista);
            this.groupBoxPlantel.Controls.Add(this.btnAddCiclista);
            this.groupBoxPlantel.Controls.Add(this.ComboBoxChooseCiclista);
            this.groupBoxPlantel.Controls.Add(this.dataGridViewPlantel);
            this.groupBoxPlantel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlantel.Location = new System.Drawing.Point(26, 206);
            this.groupBoxPlantel.Name = "groupBoxPlantel";
            this.groupBoxPlantel.Size = new System.Drawing.Size(946, 248);
            this.groupBoxPlantel.TabIndex = 3;
            this.groupBoxPlantel.TabStop = false;
            this.groupBoxPlantel.Text = " Plantel - Ciclistas ";
            // 
            // btnCreateCiclista
            // 
            this.btnCreateCiclista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateCiclista.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCiclista.Location = new System.Drawing.Point(832, 209);
            this.btnCreateCiclista.Name = "btnCreateCiclista";
            this.btnCreateCiclista.Size = new System.Drawing.Size(92, 30);
            this.btnCreateCiclista.TabIndex = 5;
            this.btnCreateCiclista.Text = "Criar";
            this.btnCreateCiclista.UseVisualStyleBackColor = true;
            this.btnCreateCiclista.Click += new System.EventHandler(this.btnCreateCiclista_Click);
            // 
            // btnAddCiclista
            // 
            this.btnAddCiclista.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCiclista.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCiclista.Location = new System.Drawing.Point(265, 212);
            this.btnAddCiclista.Name = "btnAddCiclista";
            this.btnAddCiclista.Size = new System.Drawing.Size(37, 30);
            this.btnAddCiclista.TabIndex = 4;
            this.btnAddCiclista.Text = "+";
            this.btnAddCiclista.UseVisualStyleBackColor = true;
            this.btnAddCiclista.Click += new System.EventHandler(this.btnAddCiclista_Click);
            // 
            // ComboBoxChooseCiclista
            // 
            this.ComboBoxChooseCiclista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxChooseCiclista.FormattingEnabled = true;
            this.ComboBoxChooseCiclista.ItemHeight = 24;
            this.ComboBoxChooseCiclista.Location = new System.Drawing.Point(18, 212);
            this.ComboBoxChooseCiclista.Name = "ComboBoxChooseCiclista";
            this.ComboBoxChooseCiclista.Size = new System.Drawing.Size(241, 30);
            this.ComboBoxChooseCiclista.TabIndex = 4;
            this.ComboBoxChooseCiclista.UseSelectable = true;
            // 
            // dataGridViewPlantel
            // 
            this.dataGridViewPlantel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlantel.Location = new System.Drawing.Point(18, 27);
            this.dataGridViewPlantel.Name = "dataGridViewPlantel";
            this.dataGridViewPlantel.RowHeadersWidth = 51;
            this.dataGridViewPlantel.RowTemplate.Height = 24;
            this.dataGridViewPlantel.Size = new System.Drawing.Size(906, 176);
            this.dataGridViewPlantel.TabIndex = 0;
            this.dataGridViewPlantel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlantel_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria:";
            // 
            // comboBoxCatEquipa
            // 
            this.comboBoxCatEquipa.FormattingEnabled = true;
            this.comboBoxCatEquipa.Location = new System.Drawing.Point(828, 84);
            this.comboBoxCatEquipa.Name = "comboBoxCatEquipa";
            this.comboBoxCatEquipa.Size = new System.Drawing.Size(144, 24);
            this.comboBoxCatEquipa.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(871, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRedefinir
            // 
            this.btnRedefinir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedefinir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRedefinir.Location = new System.Drawing.Point(764, 460);
            this.btnRedefinir.Name = "btnRedefinir";
            this.btnRedefinir.Size = new System.Drawing.Size(101, 40);
            this.btnRedefinir.TabIndex = 8;
            this.btnRedefinir.Text = "Redefinir";
            this.btnRedefinir.UseVisualStyleBackColor = true;
            this.btnRedefinir.Click += new System.EventHandler(this.btnRedefinir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(657, 460);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 40);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "OK";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(422, 84);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(106, 22);
            this.textBoxAno.TabIndex = 10;
            // 
            // textBoxPaís
            // 
            this.textBoxPaís.Location = new System.Drawing.Point(624, 84);
            this.textBoxPaís.Name = "textBoxPaís";
            this.textBoxPaís.Size = new System.Drawing.Size(123, 22);
            this.textBoxPaís.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ano Fundação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "País Origem:";
            // 
            // Adicionar_Equipas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPaís);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRedefinir);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboBoxCatEquipa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxPlantel);
            this.Controls.Add(this.groupBoxDD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeEquipa);
            this.Name = "Adicionar_Equipas";
            this.Text = "Adicionar_Equipas";
            this.Load += new System.EventHandler(this.Adicionar_Equipas_Load);
            this.groupBoxDD.ResumeLayout(false);
            this.groupBoxDD.PerformLayout();
            this.groupBoxPlantel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlantel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeEquipa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDD;
        private System.Windows.Forms.GroupBox groupBoxPlantel;
        private System.Windows.Forms.Button btnAddDD;
        private MetroFramework.Controls.MetroComboBox ComboBoxChooseDD;
        private System.Windows.Forms.Button btnCreateCiclista;
        private System.Windows.Forms.Button btnAddCiclista;
        private MetroFramework.Controls.MetroComboBox ComboBoxChooseCiclista;
        private System.Windows.Forms.DataGridView dataGridViewPlantel;
        private System.Windows.Forms.Button btnCreateDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCatEquipa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRedefinir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.TextBox textBoxPaís;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ChoosedDD;
        private System.Windows.Forms.TextBox labelChoosedDD;
    }
}