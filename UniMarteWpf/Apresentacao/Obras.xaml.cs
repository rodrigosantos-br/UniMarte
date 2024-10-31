using System.Windows;
using System.Windows.Media.Imaging;
using UniMarteWpf.Controle;
using UniMarteWpf.Estatico;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Obras.xaml
    /// </summary>
    public partial class Obras : Window
    {
        private ObrasControle _obrasControle;

        public Obras()
        {
            InitializeComponent();
            _obrasControle = new ObrasControle();
            AtualizarImagens();
        }

        private void AtualizarImagens()
        {
            string imagemAtual = _obrasControle.ObterImagemAtual();
            string imagemAnterior = _obrasControle.ObterImagemAnterior();
            string imagemPosterior = _obrasControle.ObterImagemPosterior();

            // Verifica se as imagens não são nulas antes de criar a Uri
            if (imagemAtual == null)
            {
                throw new InvalidOperationException("Imagem atual não pode ser nula.");
            }

            ImagemAtual.Source = new BitmapImage(new Uri(imagemAtual));

            if (imagemAnterior != null)
            {
                ImagemAnterior.Source = new BitmapImage(new Uri(imagemAnterior));
            }

            if (imagemPosterior != null)
            {
                ImagemPosterior.Source = new BitmapImage(new Uri(imagemPosterior));
            }
        }


        private void BotaoProximo_Click(object sender, RoutedEventArgs e)
        {
            _obrasControle.Proximo();
            AtualizarImagens();
        }

        private void BotaoAnterior_Click(object sender, RoutedEventArgs e)
        {
            _obrasControle.Anterior();
            AtualizarImagens();
        }

        private void PaginaInicial_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}

