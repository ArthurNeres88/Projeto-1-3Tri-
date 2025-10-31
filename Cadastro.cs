namespace Trabalho1_ProgVis
{
    public partial class Cadastro : Form
    {
        private static Cadastro _instance;

        #region SingleTon
        public static Cadastro GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new Cadastro();
            }

            return _instance;
        }
        #endregion

        private Cadastro()
        {
            InitializeComponent();
        }

       
    }
}
