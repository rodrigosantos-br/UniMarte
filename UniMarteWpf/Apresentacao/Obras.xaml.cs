using System.Windows;
using System.Windows.Media.Imaging;
using UniMarteWpf.Estatico;
using UniMarteWpf.Modelo.Controle;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Obras.xaml
    /// </summary>
    public partial class Obras : Window
    {
        private ObrasControle _controle;

        public Obras()
        {
            InitializeComponent();
            _controle = new ObrasControle(AzureBlobStorageConfig.ConnectionString, AzureBlobStorageConfig.ContainerName);
            IniciarCarregamento(); // Chama o método de carregamento
        }

        private async void IniciarCarregamento()
        {
            await _controle.CarregarImagensDoBlob(AzureBlobStorageConfig.ContainerName);
            ExibirImagemAtual();
        }

        private void ExibirImagemAtual()
        {
            string imagemAtual = _controle.ObterImagemAtual();
            if (imagemAtual != null)
            {
                ImagemAtual.Source = new BitmapImage(new Uri(imagemAtual));

                // Exibir imagens anteriores e posteriores
                if (_controle.TemImagemAnterior())
                {
                    ImagemAnterior.Source = new BitmapImage(new Uri(_controle.ObterImagemAnterior()));
                    ImagemAnterior.Visibility = Visibility.Visible;
                }
                else
                {
                    ImagemAnterior.Visibility = Visibility.Collapsed;
                }

                if (_controle.TemImagemPosterior())
                {
                    ImagemPosterior.Source = new BitmapImage(new Uri(_controle.ObterImagemPosterior()));
                    ImagemPosterior.Visibility = Visibility.Visible;
                }
                else
                {
                    ImagemPosterior.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void BotaoAnterior_Click(object sender, RoutedEventArgs e)
        {
            _controle.RetrocederImagem();
            ExibirImagemAtual();
        }

        private void BotaoProximo_Click(object sender, RoutedEventArgs e)
        {
            _controle.AvancarImagem();
            ExibirImagemAtual();
        }

        private void BotaoQuestionario_Click(object sender, RoutedEventArgs e)
        {
            // Abre o UserControl do questionário em uma nova janela
            Satisfacao _satisfacao = new Satisfacao();
            _satisfacao.Show();
            this.Hide(); // Esconde a janela atual
        }
    }
}

