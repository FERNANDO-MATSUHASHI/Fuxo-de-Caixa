namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            buttonEntrar = new Button();
            labelUsuarioSenhaError = new Label();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login;
            pictureBox1.Location = new Point(138, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 191);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 239);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(241, 193);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 3;
            textBoxUsuario.Text = "matsu";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(241, 241);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(100, 23);
            textBoxSenha.TabIndex = 4;
            textBoxSenha.Text = "drift1736";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 417);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "Copy Right 2022-2023";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.copyright;
            pictureBox2.Location = new Point(334, 417);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = SystemColors.InactiveCaption;
            buttonEntrar.Cursor = Cursors.Hand;
            buttonEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEntrar.ForeColor = SystemColors.ActiveCaptionText;
            buttonEntrar.Location = new Point(204, 307);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(84, 34);
            buttonEntrar.TabIndex = 7;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // labelUsuarioSenhaError
            // 
            labelUsuarioSenhaError.AutoSize = true;
            labelUsuarioSenhaError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuarioSenhaError.ForeColor = Color.Red;
            labelUsuarioSenhaError.Location = new Point(169, 277);
            labelUsuarioSenhaError.Name = "labelUsuarioSenhaError";
            labelUsuarioSenhaError.Size = new Size(10, 15);
            labelUsuarioSenhaError.TabIndex = 8;
            labelUsuarioSenhaError.Text = " ";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.InactiveCaption;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancelar.Location = new Point(204, 360);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(84, 34);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(493, 441);
            Controls.Add(buttonCancelar);
            Controls.Add(labelUsuarioSenhaError);
            Controls.Add(buttonEntrar);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label label3;
        private PictureBox pictureBox2;
        private Button buttonEntrar;
        private Label labelUsuarioSenhaError;
        private Button buttonCancelar;
    }
}