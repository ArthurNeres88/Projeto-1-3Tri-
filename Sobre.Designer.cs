namespace Trabalho1_ProgVis
{
    partial class Sobre
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
            lblIdentificacao = new Label();
            pnlSobre = new Panel();
            lblVersao = new Label();
            lblDesenvolvedores = new Label();
            lblDevs = new Label();
            pnlSobre.SuspendLayout();
            SuspendLayout();
            // 
            // lblIdentificacao
            // 
            lblIdentificacao.AutoSize = true;
            lblIdentificacao.BackColor = SystemColors.MenuHighlight;
            lblIdentificacao.Font = new Font("Segoe UI", 14F);
            lblIdentificacao.Location = new Point(135, 43);
            lblIdentificacao.Name = "lblIdentificacao";
            lblIdentificacao.Size = new Size(379, 25);
            lblIdentificacao.TabIndex = 0;
            lblIdentificacao.Text = "Programa utilizado para gestão de usuários";
            // 
            // pnlSobre
            // 
            pnlSobre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSobre.Controls.Add(lblDevs);
            pnlSobre.Controls.Add(lblDesenvolvedores);
            pnlSobre.Controls.Add(lblVersao);
            pnlSobre.Controls.Add(lblIdentificacao);
            pnlSobre.Location = new Point(12, 12);
            pnlSobre.Name = "pnlSobre";
            pnlSobre.Size = new Size(624, 254);
            pnlSobre.TabIndex = 1;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.BackColor = SystemColors.MenuHighlight;
            lblVersao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersao.Location = new Point(273, 90);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(102, 25);
            lblVersao.TabIndex = 1;
            lblVersao.Text = "Versão: 1.0";
            // 
            // lblDesenvolvedores
            // 
            lblDesenvolvedores.AutoSize = true;
            lblDesenvolvedores.Font = new Font("Segoe UI", 14F);
            lblDesenvolvedores.Location = new Point(155, 163);
            lblDesenvolvedores.Name = "lblDesenvolvedores";
            lblDesenvolvedores.Size = new Size(338, 50);
            lblDesenvolvedores.TabIndex = 2;
            lblDesenvolvedores.Text = "- > Artur Felipe dos Santos Gonçalves  \r\n- > Arthur Neres Barroso de Queiroz";
            // 
            // lblDevs
            // 
            lblDevs.AutoSize = true;
            lblDevs.BackColor = SystemColors.MenuHighlight;
            lblDevs.Font = new Font("Segoe UI", 14F);
            lblDevs.Location = new Point(245, 128);
            lblDevs.Name = "lblDevs";
            lblDevs.Size = new Size(159, 25);
            lblDevs.TabIndex = 3;
            lblDevs.Text = "Desenvolvedores:";
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 278);
            Controls.Add(pnlSobre);
            Name = "Sobre";
            Text = "Sobre";
            pnlSobre.ResumeLayout(false);
            pnlSobre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblIdentificacao;
        private Panel pnlSobre;
        private Label lblDesenvolvedores;
        private Label lblVersao;
        private Label lblDevs;
    }
}