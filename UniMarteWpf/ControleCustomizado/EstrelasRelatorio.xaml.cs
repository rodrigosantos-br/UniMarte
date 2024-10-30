using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media; // Adicione esta linha

namespace UniMarteWpf.ControleCustomizado
{
    /// <summary>
    /// Interação lógica para EstrelasRelatorio.xam
    /// </summary>
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
                    GetStar(i).Foreground = Brushes.Gold; // Estrela cheia
                    Debug.WriteLine($"Estrela {i} preenchida");
                }
                else if (i == estrelasCompletas + 1 && metadeEstrela >= 0.5)
                {
                    GetStar(i).Foreground = Brushes.Gold; // Estrela meia cheia
                    Debug.WriteLine($"Estrela {i} meia preenchida");
                }
                else
                {
                    GetStar(i).Foreground = Brushes.Gray; // Estrela vazia
                    Debug.WriteLine($"Estrela {i} vazia");
                }
            }
        }


        private TextBlock GetStar(int index)
        {
            return (TextBlock)FindName($"Star{index}");
        }
    }
}