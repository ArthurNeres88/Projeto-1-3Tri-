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


    }
}
