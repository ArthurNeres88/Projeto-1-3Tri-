namespace Trabalho1_ProgVis
{
    partial class Cadastro
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
            panel1 = new Panel();
            lblAvisoSucesso = new Label();
            lblAvisoUsuario = new Label();
            lblAvisoVazio = new Label();
            mskTelefone = new MaskedTextBox();
            chkPerfil = new CheckBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblNomeUsuario = new Label();
            txtNomeUsuario = new TextBox();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAvisoSucesso);
            panel1.Controls.Add(lblAvisoUsuario);
            panel1.Controls.Add(lblAvisoVazio);
            panel1.Controls.Add(mskTelefone);
            panel1.Controls.Add(chkPerfil);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(lblNomeUsuario);
            panel1.Controls.Add(txtNomeUsuario);
            panel1.Controls.Add(lblTelefone);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnCadastrar);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 458);
            panel1.TabIndex = 0;
            // 
            // lblAvisoSucesso
            // 
            lblAvisoSucesso.AutoSize = true;
            lblAvisoSucesso.BackColor = Color.Green;
            lblAvisoSucesso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoSucesso.ForeColor = SystemColors.ControlLightLight;
            lblAvisoSucesso.Location = new Point(8, 416);
            lblAvisoSucesso.Name = "lblAvisoSucesso";
            lblAvisoSucesso.Size = new Size(202, 20);
            lblAvisoSucesso.TabIndex = 15;
            lblAvisoSucesso.Text = "Usuário criado com sucesso";
            lblAvisoSucesso.Visible = false;
            // 
            // lblAvisoUsuario
            // 
            lblAvisoUsuario.AutoSize = true;
            lblAvisoUsuario.BackColor = Color.Yellow;
            lblAvisoUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoUsuario.ForeColor = Color.Red;
            lblAvisoUsuario.Location = new Point(8, 393);
            lblAvisoUsuario.Name = "lblAvisoUsuario";
            lblAvisoUsuario.Size = new Size(215, 20);
            lblAvisoUsuario.TabIndex = 14;
            lblAvisoUsuario.Text = "Nome de Usuário já existente";
            lblAvisoUsuario.Visible = false;
            // 
            // lblAvisoVazio
            // 
            lblAvisoVazio.AutoSize = true;
            lblAvisoVazio.BackColor = Color.Yellow;
            lblAvisoVazio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvisoVazio.ForeColor = Color.Red;
            lblAvisoVazio.Location = new Point(8, 370);
            lblAvisoVazio.Name = "lblAvisoVazio";
            lblAvisoVazio.Size = new Size(217, 20);
            lblAvisoVazio.TabIndex = 13;
            lblAvisoVazio.Text = "Os campos estão incompletos";
            lblAvisoVazio.Visible = false;
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Segoe UI", 14F);
            mskTelefone.Location = new Point(8, 245);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(478, 32);
            mskTelefone.TabIndex = 12;
            mskTelefone.TextChanged += mskTelefone_TextChanged;
            mskTelefone.KeyUp += mskTelefone_KeyUp;
            // 
            // chkPerfil
            // 
            chkPerfil.AutoSize = true;
            chkPerfil.Location = new Point(8, 344);
            chkPerfil.Name = "chkPerfil";
            chkPerfil.Size = new Size(67, 19);
            chkPerfil.TabIndex = 11;
            chkPerfil.Text = "Gerente";
            chkPerfil.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(8, 287);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 10;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(8, 305);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(478, 33);
            txtSenha.TabIndex = 9;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(4, 108);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(99, 15);
            lblNomeUsuario.TabIndex = 8;
            lblNomeUsuario.Text = "Nome de Usuário";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Location = new Point(8, 126);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(478, 33);
            txtNomeUsuario.TabIndex = 7;
            txtNomeUsuario.TextChanged += txtNomeUsuario_TextChanged;
            txtNomeUsuario.KeyUp += txtNomeUsuario_KeyUp;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(8, 227);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(8, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(4, 54);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome\r\n";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(8, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(478, 33);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(8, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(478, 33);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.MenuHighlight;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(317, 393);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(169, 43);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(96, 6);
            label1.Name = "label1";
            label1.Size = new Size(305, 49);
            label1.TabIndex = 16;
            label1.Text = "Faça seu cadastro";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 462);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Cadastro";
            Text = "Cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCadastrar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblNome;
        private Label lblNomeUsuario;
        private TextBox txtNomeUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private CheckBox chkPerfil;
        private MaskedTextBox mskTelefone;
        private Label lblAvisoVazio;
        private Label lblAvisoUsuario;
        private Label lblAvisoSucesso;
        private Label label1;
    }
}
