using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using UniMarteWpf.Apresentacao;

namespace UniMarteWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DispatcherTimer inatividadeTimer;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Inicializa o temporizador com 1 minuto de inatividade
            inatividadeTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMinutes(1)
            };
            inatividadeTimer.Tick += InatividadeTimer_Tick;

            // Inicia o temporizador ao iniciar o aplicativo
            inatividadeTimer.Start();

            // Eventos globais para resetar o temporizador em caso de interação do usuário
            EventManager.RegisterClassHandler(typeof(Window), Window.MouseMoveEvent, new MouseEventHandler(ResetarTimerInatividade));
            EventManager.RegisterClassHandler(typeof(Window), Window.KeyDownEvent, new KeyEventHandler(ResetarTimerInatividade));
            // Registrar o evento global para capturar o KeyDown em todas as janelas
            EventManager.RegisterClassHandler(typeof(Window), Window.KeyDownEvent, new KeyEventHandler(GlobalKeyDown));
        }

        // Evento que ocorre após 1 minuto de inatividade
        private void InatividadeTimer_Tick(object sender, EventArgs e)
        {
            RetornarParaPaginaInicial();
        }

        private void ResetarTimerInatividade(object sender, EventArgs e)
        {
            inatividadeTimer.Stop();
            inatividadeTimer.Start();
        }

        private void RetornarParaPaginaInicial()
        {
            inatividadeTimer.Stop();

            // Verifica se a MainWindow já está aberta
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            if (mainWindow == null)
            {
                // Se não estiver aberta, cria uma nova instância
                mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                // Se já estiver aberta, apenas ativa
                mainWindow.Activate();
            }

            // Fecha todas as outras janelas
            var openWindows = Application.Current.Windows.OfType<Window>().ToList();
            foreach (Window window in openWindows)
            {
                if (!(window is MainWindow))
                {
                    window.Close();
                }
            }
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
