using Barista.Data;

namespace Barista
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            try
            {
                var Factory = new ContextoFactory();

                using var Contexto = Factory.CreateDbContext(Array.Empty<string>());

                DatabaseInitializer.Inicializar(Contexto);

                Application.Run(new Frm_Principal());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al inicializar la base de datos:\n\n" + ex.Message,
                    "Error al iniciar BaristaApp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
