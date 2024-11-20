using System.Windows;
using UniMarte.Wpf.Controle;
using UniMarte.Wpf.Modelo;
using UniMarte.Wpf.ControleCustomizado;

namespace UniMarte.Wpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Satisfacao.xaml
    /// </summary>
    public partial class Satisfacao : Window
    {
        private PerguntaControle perguntaControle;
        private RelatorioControle relatorioControle = new RelatorioControle();

        public Satisfacao()
        {
            InitializeComponent();
            // Inicializa PerguntaControle com os controles de respostas
            this.perguntaControle = new PerguntaControle(new List<IResposta> {
            new SimNao(), new EscolhaObra(), new Estrelas()
        });
            perguntaControle.ExibirPerguntaAtual(PerguntaTextBlock, RespostaPanel);
        }

        // Evento do botão "Próxima"
        private void ProximaPergunta_Click(object sender, RoutedEventArgs e)
        {
            // Salva a resposta antes de ir para a próxima pergunta
            bool respostaSalva = perguntaControle.SalvarResposta(RespostaPanel);

            // Só avança se a resposta tiver sido salva com sucesso
            if (respostaSalva && perguntaControle.ProximaPergunta(RespostaPanel))
            {
                perguntaControle.ExibirPerguntaAtual(PerguntaTextBlock, RespostaPanel);
            }
            else if (perguntaControle.EhUltimaPergunta())
            {
                btnProximaPergunta.Visibility = Visibility.Collapsed;
                stkRelatorio.Visibility = Visibility.Visible;
                btnFim.Visibility = Visibility.Visible;
            }
        }

        private void BtnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}


