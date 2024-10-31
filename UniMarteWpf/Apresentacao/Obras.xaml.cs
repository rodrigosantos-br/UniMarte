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
            _obrasControle = new ObrasControle(this);
            _obrasControle.AtualizarImagens(ImagemAtual, ImagemAnterior, ImagemPosterior);
        }

        private void BotaoProximo_Click(object sender, RoutedEventArgs e)
        {
            _obrasControle.Proximo();
            _obrasControle.AtualizarImagens(ImagemAtual, ImagemAnterior, ImagemPosterior);
        }

        private void BotaoAnterior_Click(object sender, RoutedEventArgs e)
        {
            _obrasControle.Anterior();
            _obrasControle.AtualizarImagens(ImagemAtual, ImagemAnterior, ImagemPosterior);
        }

        private void PaginaInicial_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}

