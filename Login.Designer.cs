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
            btnEntrar = new Button();
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
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblNomeUsuario);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtNomeUsuario);
            panel1.Controls.Add(lblBemVindoDeVolta);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 427);
            panel1.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.MenuHighlight;
            btnEntrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(83, 309);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(224, 50);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(30, 190);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.Location = new Point(30, 85);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(125, 20);
            lblNomeUsuario.TabIndex = 3;
            lblNomeUsuario.Text = "Nome de Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(30, 213);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(330, 43);
            txtSenha.TabIndex = 2;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Location = new Point(30, 108);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(330, 43);
            txtNomeUsuario.TabIndex = 1;
            // 
            // lblBemVindoDeVolta
            // 
            lblBemVindoDeVolta.AutoSize = true;
            lblBemVindoDeVolta.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindoDeVolta.Location = new Point(59, 0);
            lblBemVindoDeVolta.Name = "lblBemVindoDeVolta";
            lblBemVindoDeVolta.Size = new Size(264, 40);
            lblBemVindoDeVolta.TabIndex = 0;
            lblBemVindoDeVolta.Text = "Bem vindo de volta";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 433);
            Controls.Add(panel1);
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
        private Button btnEntrar;
    }
}