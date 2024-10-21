using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Obras.xaml
    /// </summary>
    public partial class Obras : Window
    {
        private const string connectionString =
            "DefaultEndpointsProtocol=https;" +
            "AccountName=unimarteimages;" +
            "AccountKey=08I9cMkTZvsvwe2pUUhQNTt0+ExS13zBYflqHpEqGQecVRBnyv3CkJCQ4EUauspdIygIBjdcCu0e+AStd7GRVA==;" +
            "EndpointSuffix=core.windows.net";
        private const string containerName = "unimarteimages";
        private BlobServiceClient blobServiceClient;
        private List<string> _imagens;
        private int _indiceAtual;

        public Obras()
        {
            InitializeComponent();
            blobServiceClient = new BlobServiceClient(connectionString);
            CarregarImagensDoBlob();
        }

        // Carrega as imagens do container Blob
        private async void CarregarImagensDoBlob()
        {
            _imagens = new List<string>();
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);

            await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
            {
                // Adiciona a URL completa do blob à lista
                string blobUrl = $"{containerClient.Uri}/{blobItem.Name}";
                _imagens.Add(blobUrl);
            }

            _indiceAtual = 0; // Começar pela primeira imagem
            ExibirImagemAtual();
        }

        // Exibe a imagem atual e controla a visibilidade das imagens anterior e posterior
        private void ExibirImagemAtual()
        {
            if (_imagens.Count > 0)
            {
                ImagemAtual.Source = new BitmapImage(new Uri(_imagens[_indiceAtual]));

                // Verifica se há uma imagem anterior
                if (_indiceAtual > 0)
                {
                    ImagemAnterior.Source = new BitmapImage(new Uri(_imagens[_indiceAtual - 1]));
                    ImagemAnterior.Visibility = Visibility.Visible;
                    IndicativoAnterior.Visibility = Visibility.Collapsed; // Esconde o indicativo
                }
                else
                {
                    ImagemAnterior.Visibility = Visibility.Collapsed; // Esconde a imagem anterior
                    IndicativoAnterior.Visibility = Visibility.Visible; // Mostra o indicativo
                }

                // Verifica se há uma imagem posterior
                if (_indiceAtual < _imagens.Count - 1)
                {
                    ImagemPosterior.Source = new BitmapImage(new Uri(_imagens[_indiceAtual + 1]));
                    ImagemPosterior.Visibility = Visibility.Visible;
                    IndicativoPosterior.Visibility = Visibility.Collapsed; // Esconde o indicativo
                }
                else
                {
                    ImagemPosterior.Visibility = Visibility.Collapsed; // Esconde a imagem posterior
                    IndicativoPosterior.Visibility = Visibility.Visible; // Mostra o indicativo
                }
            }
        }

        // Botão para exibir a imagem anterior
        private void BotaoAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (_indiceAtual > 0)
            {
                _indiceAtual--;
                ExibirImagemAtual();
            }
        }

        // Botão para exibir a imagem próxima
        private void BotaoProximo_Click(object sender, RoutedEventArgs e)
        {
            if (_indiceAtual < _imagens.Count - 1)
            {
                _indiceAtual++;
                ExibirImagemAtual();
            }
        }

        private void IniciarTransicao()
        {
            DoubleAnimation fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));
            ImagemAtual.BeginAnimation(UIElement.OpacityProperty, fadeIn);
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

