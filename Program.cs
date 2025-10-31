namespace Trabalho1_ProgVis
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            if (UsuarioRepository.FindById(1) == null)
            {

            
            Credencial adminCredencial = new Credencial()
            {
                NomeUsuario = "Admin",
                Senha = "Senha",
                Administrador = true
            };
            Usuario adminUsuario = new Usuario()
            {
                Nome = "Admin",
                Telefone = "12345678911",
                Email = "admin@gmail.com",
                Credencial = adminCredencial
            };

            UsuarioRepository.SaveOrUpdate(adminUsuario);

            }


            ApplicationConfiguration.Initialize();
            Application.Run(new Cadastro());

        }
    }
}