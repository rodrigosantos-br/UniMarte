using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace UniMarteWpf.ControleCustomizado
{
    public partial class EstrelasRelatorio : UserControl
    {
        public EstrelasRelatorio()
        {
            InitializeComponent();
        }

        public void AtualizarEstrelas(float media)
        {
            Debug.WriteLine($"Média: {media}");
            int estrelasCompletas = (int)media;
            double metadeEstrela = media - estrelasCompletas;

            for (int i = 1; i <= 5; i++)
            {
                if (i <= estrelasCompletas)
                {
                    SetStarImage(i, "pack://application:,,,/Imagens/Icones/estrela_cheia.png"); 
                }
                else if (i == estrelasCompletas + 1 && metadeEstrela >= 0.5)
                {
                    SetStarImage(i, "pack://application:,,,/Imagens/Icones/estrela_parcial.png");
                }
                else
                {
                    SetStarImage(i, "pack://application:,,,/Imagens/Icones/estrela_vazia.png");
                }
            }
        }

        private void SetStarImage(int index, string imagePath)
        {
            Image star = (Image)FindName($"Star{index}");
            if (star != null)
            {
                star.Source = new BitmapImage(new Uri(imagePath));
            }
        }
    }
}
