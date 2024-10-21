using System.Windows;
using System.Windows.Input;

namespace UniMarteWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Registrar o evento global para capturar o KeyDown em todas as janelas
            EventManager.RegisterClassHandler(typeof(Window), Window.KeyDownEvent, new KeyEventHandler(GlobalKeyDown));
        }

        // Método que será chamado quando qualquer tecla for pressionada em qualquer janela
        private void GlobalKeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Esc
            if (e.Key == Key.Escape)
            {
                Current.Shutdown(); // Fecha a aplicação
            }
        }
    }

}
