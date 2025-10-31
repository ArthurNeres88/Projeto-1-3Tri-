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
    public partial class ListaUsuarios : Form
    {
        private static ListaUsuarios _instance;

        #region SingleTon
        public static ListaUsuarios GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ListaUsuarios();
            }

            return _instance;
        }
        #endregion


        public ListaUsuarios()
        {
            InitializeComponent();
        }
    }
}
