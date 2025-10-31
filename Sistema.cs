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
    public partial class Sistema : Form
    {

        private static Sistema _instance;

        #region SingleTon
        public static Sistema GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Sistema();
            }

            return _instance;
        }
        #endregion

        private Sistema()
        {
            InitializeComponent();


        }

        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuCadastroUsuario_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = Cadastro.GetInstance();
            cadastro.MdiParent = this;
            cadastro.BringToFront();
            cadastro.WindowState = FormWindowState.Normal;

            cadastro.Show();
        }

        private void mnuAjudaSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = Sobre.GetInstance();
            sobre.MdiParent = this;
            sobre.BringToFront();
            sobre.WindowState = FormWindowState.Normal;

            sobre.Show();
        }

        private void mnuRelatorioUsuarios_Click(object sender, EventArgs e)
        {
            ListaUsuarios listaUsuarios = ListaUsuarios.GetInstance();
            listaUsuarios.MdiParent = this;
            listaUsuarios.BringToFront();
            listaUsuarios.WindowState = FormWindowState.Normal;

            listaUsuarios.Show();
        }
    }
}
