namespace Login
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem1 = new ToolStripMenuItem();
            logoffToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            cadastarToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            manutençãoToolStripMenuItem1 = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label_Usuario = new Label();
            label_Acesso = new Label();
            label3 = new Label();
            pb_ledLogado = new PictureBox();
            label1 = new Label();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ledLogado).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastarToolStripMenuItem, manutençãoToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem1, logoffToolStripMenuItem, sairToolStripMenuItem1 });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            // 
            // loginToolStripMenuItem1
            // 
            loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            loginToolStripMenuItem1.Size = new Size(109, 22);
            loginToolStripMenuItem1.Text = "Login";
            loginToolStripMenuItem1.Click += loginToolStripMenuItem1_Click;
            // 
            // logoffToolStripMenuItem
            // 
            logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            logoffToolStripMenuItem.Size = new Size(109, 22);
            logoffToolStripMenuItem.Text = "Logoff";
            logoffToolStripMenuItem.Click += logoffToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(109, 22);
            sairToolStripMenuItem1.Text = "Sair";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem1_Click;
            // 
            // cadastarToolStripMenuItem
            // 
            cadastarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem, fornecedorToolStripMenuItem });
            cadastarToolStripMenuItem.Name = "cadastarToolStripMenuItem";
            cadastarToolStripMenuItem.Size = new Size(55, 20);
            cadastarToolStripMenuItem.Text = "Gestão";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(180, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click_1;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(180, 22);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            fornecedorToolStripMenuItem.Click += fornecedorToolStripMenuItem_Click;
            // 
            // manutençãoToolStripMenuItem1
            // 
            manutençãoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { bancoDeDadosToolStripMenuItem });
            manutençãoToolStripMenuItem1.Name = "manutençãoToolStripMenuItem1";
            manutençãoToolStripMenuItem1.Size = new Size(86, 20);
            manutençãoToolStripMenuItem1.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(159, 22);
            bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            bancoDeDadosToolStripMenuItem.Click += bancoDeDadosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_Usuario);
            panel1.Controls.Add(label_Acesso);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pb_ledLogado);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 417);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 33);
            panel1.TabIndex = 5;
            // 
            // label_Usuario
            // 
            label_Usuario.AutoSize = true;
            label_Usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Usuario.Location = new Point(171, 11);
            label_Usuario.Name = "label_Usuario";
            label_Usuario.Size = new Size(17, 15);
            label_Usuario.TabIndex = 10;
            label_Usuario.Text = "--";
            // 
            // label_Acesso
            // 
            label_Acesso.AutoSize = true;
            label_Acesso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Acesso.Location = new Point(83, 11);
            label_Acesso.Name = "label_Acesso";
            label_Acesso.Size = new Size(14, 15);
            label_Acesso.TabIndex = 8;
            label_Acesso.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(113, 11);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Usuário:";
            // 
            // pb_ledLogado
            // 
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            pb_ledLogado.Location = new Point(3, 11);
            pb_ledLogado.Name = "pb_ledLogado";
            pb_ledLogado.Size = new Size(20, 15);
            pb_ledLogado.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_ledLogado.TabIndex = 6;
            pb_ledLogado.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 11);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 7;
            label1.Text = "Acesso:";
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(32, 19);
            manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "Menu";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ledLogado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastarToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem1;
        private ToolStripMenuItem logoffToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        public PictureBox pb_ledLogado;
        public Label label_Usuario;
        public Label label_Acesso;
        private ToolStripMenuItem manutençãoToolStripMenuItem1;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
    }
}