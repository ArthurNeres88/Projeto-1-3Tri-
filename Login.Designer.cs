namespace Trabalho1_ProgVis
{
    partial class Login
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
            panel1 = new Panel();
            lblAviso = new Label();
            lblSenha = new Label();
            lblNomeUsuario = new Label();
            txtSenha = new TextBox();
            txtNomeUsuario = new TextBox();
            lblBemVindoDeVolta = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblAviso);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblNomeUsuario);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtNomeUsuario);
            panel1.Controls.Add(lblBemVindoDeVolta);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 316);
            panel1.TabIndex = 0;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.BackColor = Color.Yellow;
            lblAviso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.Red;
            lblAviso.Location = new Point(30, 275);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(189, 25);
            lblAviso.TabIndex = 5;
            lblAviso.Text = "Credenciais Inválidas";
            lblAviso.Visible = false;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(30, 191);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.Location = new Point(30, 101);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(125, 20);
            lblNomeUsuario.TabIndex = 3;
            lblNomeUsuario.Text = "Nome de Usuário";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ScrollBar;
            txtSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(30, 214);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(330, 43);
            txtSenha.TabIndex = 2;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.BackColor = SystemColors.ScrollBar;
            txtNomeUsuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Location = new Point(30, 124);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(330, 43);
            txtNomeUsuario.TabIndex = 1;
            txtNomeUsuario.TextChanged += txtNomeUsuario_TextChanged;
            txtNomeUsuario.KeyUp += txtNomeUsuario_KeyUp;
            // 
            // lblBemVindoDeVolta
            // 
            lblBemVindoDeVolta.AutoSize = true;
            lblBemVindoDeVolta.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindoDeVolta.Location = new Point(50, 7);
            lblBemVindoDeVolta.Name = "lblBemVindoDeVolta";
            lblBemVindoDeVolta.Size = new Size(294, 45);
            lblBemVindoDeVolta.TabIndex = 0;
            lblBemVindoDeVolta.Text = "Bem vindo de volta";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 322);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSenha;
        private TextBox txtNomeUsuario;
        private Label lblBemVindoDeVolta;
        private Label lblSenha;
        private Label lblNomeUsuario;
        private Label lblAviso;
    }
}