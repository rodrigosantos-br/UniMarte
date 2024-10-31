using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer imageTimer;
        private string[] imagePaths;
        private int currentImageIndex;
        private TimeSpan transitionDuration = TimeSpan.FromSeconds(1);  // Duração da transição

        public MainWindow()
        {
            InitializeComponent();
            // Definir o caminho das imagens
            imagePaths = new string[]
            {
                "/Imagens/TelaInicial/UniMarte.jpg",
                "/Imagens/TelaInicial/MarteTerra.jpg",
                "/Imagens/TelaInicial/UniMarteInterior.jpg"
            };
            currentImageIndex = 0;

            // Configurar o Timer para trocar de imagem a cada 8 segundos
            imageTimer = new DispatcherTimer();
            imageTimer.Interval = TimeSpan.FromSeconds(7);  // Tempo antes de trocar a imagem
            imageTimer.Tick += ImageTimer_Tick;
            imageTimer.Start();

            // Definir a primeira imagem
            SetBackgroundImage();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                imageTimer.Stop();

                Cadastro cadastro = new Cadastro();
                cadastro.Show();
                this.Close();
            }
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            // Alternar para a próxima imagem
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            TransitionToNextImage();
        }

        private void SetBackgroundImage()
        {
            BackgroundImage.Source = new BitmapImage(new Uri(imagePaths[currentImageIndex], UriKind.Relative));
        }

        private void TransitionToNextImage()
        {
            // Criar animação de fade out
            DoubleAnimation fadeOut = new DoubleAnimation(1, 0, transitionDuration);
            fadeOut.Completed += (s, a) =>
            {
                // Após o fade out, alterar a imagem e fazer fade in
                SetBackgroundImage();

                DoubleAnimation fadeIn = new DoubleAnimation(0, 1, transitionDuration);
                BackgroundImage.BeginAnimation(UIElement.OpacityProperty, fadeIn);
            };

            // Iniciar o fade out
            BackgroundImage.BeginAnimation(UIElement.OpacityProperty, fadeOut);
        }
    }
}