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
            maskedTextBox1 = new MaskedTextBox();
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
            panel1.Controls.Add(maskedTextBox1);
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
            panel1.Size = new Size(355, 408);
            panel1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 14F);
            maskedTextBox1.Location = new Point(8, 206);
            maskedTextBox1.Mask = "(00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(335, 32);
            maskedTextBox1.TabIndex = 12;
            // 
            // chkPerfil
            // 
            chkPerfil.AutoSize = true;
            chkPerfil.Location = new Point(8, 305);
            chkPerfil.Name = "chkPerfil";
            chkPerfil.Size = new Size(67, 19);
            chkPerfil.TabIndex = 11;
            chkPerfil.Text = "Gerente";
            chkPerfil.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(8, 248);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 10;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(8, 266);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(335, 33);
            txtSenha.TabIndex = 9;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(4, 69);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(99, 15);
            lblNomeUsuario.TabIndex = 8;
            lblNomeUsuario.Text = "Nome de Usuário";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Location = new Point(8, 87);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(335, 33);
            txtNomeUsuario.TabIndex = 7;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(8, 188);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(8, 132);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(4, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome\r\n";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(8, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(335, 33);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(8, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 33);
            txtEmail.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.MenuHighlight;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(174, 354);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(169, 43);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(4, 331);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 13;
            label1.Text = "Os campos estão incompletos";
            label1.Visible = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 412);
            Controls.Add(panel1);
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
        private MaskedTextBox maskedTextBox1;
        private Label label1;
    }
}
