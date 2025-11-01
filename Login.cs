using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1_ProgVis
{
    public partial class Login : Form
    {
        private static Login? _instance;

        private Usuario _usuarioInstance;
        public static Login GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Login();
            }

            return _instance;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void txtNomeUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Validar o usuário
                // Lista de credenciais
                List<Credencial> _credenciais = new List<Credencial>();
                _credenciais = CredencialRepository.FindAllWithUsuario();

                // Move o foco para o txtUsuario
                txtNomeUsuario.Focus();
                txtNomeUsuario.SelectAll();

                // Passando um por um na lista de credenciais
                foreach (Credencial u in _credenciais)
                {
                    // Se o txtUsuario.Text for igual ao salvo no banco de dados
                    if (u.NomeUsuario == txtNomeUsuario.Text)
                    {   
                        // Se o txtSenha.Text for igual ao salvo no banco de dados
                        if (u.Senha == Credencial.ComputeSHA256(txtSenha.Text, Credencial.SALT))
                        {
                            _usuarioInstance = u.Usuario;

                            // Limpa o formulário
                            txtNomeUsuario.Clear();
                            txtSenha.Clear();

                            // Esconde a janela
                            Hide();

                            // Abre a janela do sistema
                            Sistema.GetInstance(_usuarioInstance).Show();
                        }
                        else
                        {
                            txtSenha.Clear();
                            lblAviso.Visible = true;
                        }

                        break;
                    }

                }
            }
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
