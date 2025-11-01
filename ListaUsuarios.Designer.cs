namespace Trabalho1_ProgVis
{
    partial class ListaUsuarios
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
            pnlListaUsuarios = new Panel();
            lblNome = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lstUsuarios = new ListBox();
            chkPerfil = new CheckBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblNomeDefault = new Label();
            lblNomeUsuarioDefault = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblNomeUsuario = new Label();
            pnlListaUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // pnlListaUsuarios
            // 
            pnlListaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlListaUsuarios.Controls.Add(lblNomeUsuario);
            pnlListaUsuarios.Controls.Add(lblNome);
            pnlListaUsuarios.Controls.Add(maskedTextBox1);
            pnlListaUsuarios.Controls.Add(lstUsuarios);
            pnlListaUsuarios.Controls.Add(chkPerfil);
            pnlListaUsuarios.Controls.Add(lblSenha);
            pnlListaUsuarios.Controls.Add(txtEmail);
            pnlListaUsuarios.Controls.Add(txtSenha);
            pnlListaUsuarios.Controls.Add(lblNomeDefault);
            pnlListaUsuarios.Controls.Add(lblNomeUsuarioDefault);
            pnlListaUsuarios.Controls.Add(lblEmail);
            pnlListaUsuarios.Controls.Add(lblTelefone);
            pnlListaUsuarios.Location = new Point(12, 12);
            pnlListaUsuarios.Name = "pnlListaUsuarios";
            pnlListaUsuarios.Size = new Size(606, 341);
            pnlListaUsuarios.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(250, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 24;
            lblNome.Text = "Nome\r\n";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 14F);
            maskedTextBox1.Location = new Point(254, 197);
            maskedTextBox1.Mask = "(00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(335, 32);
            maskedTextBox1.TabIndex = 23;
            // 
            // lstUsuarios
            // 
            lstUsuarios.BackColor = SystemColors.MenuHighlight;
            lstUsuarios.Font = new Font("Segoe UI", 14F);
            lstUsuarios.ForeColor = SystemColors.Window;
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 25;
            lstUsuarios.Location = new Point(3, 3);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(245, 304);
            lstUsuarios.TabIndex = 0;
            lstUsuarios.Tag = "Lista de Usuários";
            // 
            // chkPerfil
            // 
            chkPerfil.AutoSize = true;
            chkPerfil.Location = new Point(254, 296);
            chkPerfil.Name = "chkPerfil";
            chkPerfil.Size = new Size(67, 19);
            chkPerfil.TabIndex = 22;
            chkPerfil.Text = "Gerente";
            chkPerfil.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(254, 239);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 21;
            lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(254, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 33);
            txtEmail.TabIndex = 13;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(254, 257);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(335, 33);
            txtSenha.TabIndex = 20;
            // 
            // lblNomeDefault
            // 
            lblNomeDefault.AutoSize = true;
            lblNomeDefault.Location = new Point(250, 6);
            lblNomeDefault.Name = "lblNomeDefault";
            lblNomeDefault.Size = new Size(40, 15);
            lblNomeDefault.TabIndex = 15;
            lblNomeDefault.Text = "Nome\r\n";
            // 
            // lblNomeUsuarioDefault
            // 
            lblNomeUsuarioDefault.AutoSize = true;
            lblNomeUsuarioDefault.Location = new Point(250, 60);
            lblNomeUsuarioDefault.Name = "lblNomeUsuarioDefault";
            lblNomeUsuarioDefault.Size = new Size(99, 15);
            lblNomeUsuarioDefault.TabIndex = 19;
            lblNomeUsuarioDefault.Text = "Nome de Usuário";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(254, 123);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(254, 179);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 17;
            lblTelefone.Text = "Telefone";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(250, 91);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(99, 15);
            lblNomeUsuario.TabIndex = 25;
            lblNomeUsuario.Text = "Nome de Usuário";
            // 
            // ListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 365);
            Controls.Add(pnlListaUsuarios);
            Name = "ListaUsuarios";
            Text = "ListaUsuarios";
            pnlListaUsuarios.ResumeLayout(false);
            pnlListaUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlListaUsuarios;
        private ListBox lstUsuarios;
        private MaskedTextBox maskedTextBox1;
        private CheckBox chkPerfil;
        private TextBox txtNome;
        private Label lblSenha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblNomeDefault;
        private Label lblNomeUsuarioDefault;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblNome;
        private Label lblNomeUsuario;
    }
}