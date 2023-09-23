namespace Login
{
    partial class Gestao_Fornecedor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestao_Fornecedor));
            textBoxUF = new TextBox();
            textBoxID = new TextBox();
            label19 = new Label();
            cb_Cidade = new ComboBox();
            label15 = new Label();
            label10 = new Label();
            textBoxBairro = new TextBox();
            textBoxEndereco = new TextBox();
            textBoxCel = new TextBox();
            textBoxCEP = new TextBox();
            textBoxEMail = new TextBox();
            textBoxRazaoSocial = new TextBox();
            textBoxNomeFantasia = new TextBox();
            textBoxCNPJ = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            buttonExcluir = new Button();
            buttonNovo = new Button();
            buttonSlavar = new Button();
            buttonCancelar = new Button();
            dgvFornecedor = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // textBoxUF
            // 
            textBoxUF.Location = new Point(403, 371);
            textBoxUF.Name = "textBoxUF";
            textBoxUF.ReadOnly = true;
            textBoxUF.Size = new Size(121, 23);
            textBoxUF.TabIndex = 60;
            textBoxUF.TabStop = false;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(20, 87);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 59;
            textBoxID.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(20, 68);
            label19.Name = "label19";
            label19.Size = new Size(18, 15);
            label19.TabIndex = 58;
            label19.Text = "ID";
            // 
            // cb_Cidade
            // 
            cb_Cidade.FormattingEnabled = true;
            cb_Cidade.Location = new Point(20, 371);
            cb_Cidade.Name = "cb_Cidade";
            cb_Cidade.Size = new Size(241, 23);
            cb_Cidade.TabIndex = 55;
            cb_Cidade.SelectedIndexChanged += cb_Cidade_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 353);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 57;
            label15.Text = "Cidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(447, 54);
            label10.Name = "label10";
            label10.Size = new Size(304, 29);
            label10.TabIndex = 56;
            label10.Text = "Gestão de Fornecedores";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(403, 305);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(121, 23);
            textBoxBairro.TabIndex = 54;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(20, 305);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(357, 23);
            textBoxEndereco.TabIndex = 53;
            // 
            // textBoxCel
            // 
            textBoxCel.Location = new Point(283, 248);
            textBoxCel.Name = "textBoxCel";
            textBoxCel.Size = new Size(241, 23);
            textBoxCel.TabIndex = 52;
            // 
            // textBoxCEP
            // 
            textBoxCEP.Location = new Point(20, 248);
            textBoxCEP.Name = "textBoxCEP";
            textBoxCEP.Size = new Size(241, 23);
            textBoxCEP.TabIndex = 51;
            // 
            // textBoxEMail
            // 
            textBoxEMail.Location = new Point(283, 191);
            textBoxEMail.Name = "textBoxEMail";
            textBoxEMail.Size = new Size(241, 23);
            textBoxEMail.TabIndex = 50;
            // 
            // textBoxRazaoSocial
            // 
            textBoxRazaoSocial.Location = new Point(20, 191);
            textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            textBoxRazaoSocial.Size = new Size(241, 23);
            textBoxRazaoSocial.TabIndex = 49;
            // 
            // textBoxNomeFantasia
            // 
            textBoxNomeFantasia.Location = new Point(283, 139);
            textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            textBoxNomeFantasia.Size = new Size(241, 23);
            textBoxNomeFantasia.TabIndex = 48;
            // 
            // textBoxCNPJ
            // 
            textBoxCNPJ.Location = new Point(20, 139);
            textBoxCNPJ.Name = "textBoxCNPJ";
            textBoxCNPJ.Size = new Size(241, 23);
            textBoxCNPJ.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(402, 353);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 46;
            label9.Text = "UF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 287);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 45;
            label8.Text = "Bairro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(283, 173);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 44;
            label7.Text = "e-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 229);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 43;
            label6.Text = "Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 287);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 42;
            label5.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 230);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 41;
            label4.Text = "CEP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 173);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 40;
            label3.Text = "Razão Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 121);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 39;
            label2.Text = "Nome Fantasia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 121);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 38;
            label1.Text = "CNPJ";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonExcluir);
            panel1.Controls.Add(buttonNovo);
            panel1.Controls.Add(buttonSlavar);
            panel1.Controls.Add(buttonCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(1255, 32);
            panel1.TabIndex = 61;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.FromArgb(255, 192, 192);
            buttonExcluir.Cursor = Cursors.Hand;
            buttonExcluir.Location = new Point(165, 3);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 35;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Cursor = Cursors.Hand;
            buttonNovo.Location = new Point(3, 3);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 23);
            buttonNovo.TabIndex = 25;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // buttonSlavar
            // 
            buttonSlavar.BackColor = Color.FromArgb(192, 255, 192);
            buttonSlavar.Cursor = Cursors.Hand;
            buttonSlavar.Location = new Point(84, 3);
            buttonSlavar.Name = "buttonSlavar";
            buttonSlavar.Size = new Size(75, 23);
            buttonSlavar.TabIndex = 23;
            buttonSlavar.Text = "Salvar";
            buttonSlavar.UseVisualStyleBackColor = false;
            buttonSlavar.Click += buttonSlavar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.Control;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Location = new Point(1177, 3);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 24;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AllowUserToAddRows = false;
            dgvFornecedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.EnableHeadersVisualStyles = false;
            dgvFornecedor.Location = new Point(550, 121);
            dgvFornecedor.MultiSelect = false;
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.RowHeadersVisible = false;
            dgvFornecedor.RowTemplate.Height = 25;
            dgvFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedor.Size = new Size(684, 273);
            dgvFornecedor.TabIndex = 62;
            dgvFornecedor.SelectionChanged += dgvFornecedor_SelectionChanged;
            // 
            // Gestao_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 450);
            Controls.Add(dgvFornecedor);
            Controls.Add(panel1);
            Controls.Add(textBoxUF);
            Controls.Add(textBoxID);
            Controls.Add(label19);
            Controls.Add(cb_Cidade);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxEndereco);
            Controls.Add(textBoxCel);
            Controls.Add(textBoxCEP);
            Controls.Add(textBoxEMail);
            Controls.Add(textBoxRazaoSocial);
            Controls.Add(textBoxNomeFantasia);
            Controls.Add(textBoxCNPJ);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gestao_Fornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestao de Fornecedor";
            Load += Gestao_Fornecedor_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUF;
        private TextBox textBoxID;
        private Label label19;
        private ComboBox cb_Cidade;
        private Label label15;
        private Label label10;
        private TextBox textBoxBairro;
        private TextBox textBoxEndereco;
        private TextBox textBoxCel;
        private TextBox textBoxCEP;
        private TextBox textBoxEMail;
        private TextBox textBoxRazaoSocial;
        private TextBox textBoxNomeFantasia;
        private TextBox textBoxCNPJ;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button buttonExcluir;
        private Button buttonNovo;
        private Button buttonSlavar;
        private Button buttonCancelar;
        private DataGridView dgvFornecedor;
    }
}