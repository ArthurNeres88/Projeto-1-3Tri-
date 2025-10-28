namespace Trabalho1_ProgVis
{
    partial class Janela1
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
            btnEntrar = new Button();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblTelefone);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnEntrar);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 408);
            panel1.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.MenuHighlight;
            btnEntrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(114, 338);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(122, 43);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(88, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 33);
            txtEmail.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(88, 68);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(198, 33);
            txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(88, 235);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(198, 33);
            txtTelefone.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(88, 50);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome\r\n";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(88, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(88, 217);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // Janela1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 412);
            Controls.Add(panel1);
            Name = "Janela1";
            Text = "Cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEntrar;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblNome;
    }
}
