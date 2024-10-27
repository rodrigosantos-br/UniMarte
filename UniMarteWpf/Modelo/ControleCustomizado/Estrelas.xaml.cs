using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace UniMarteWpf.Modelo.ControleCustomizado
{
    /// <summary>
    /// Interação lógica para Estrelas.xam
    /// </summary>
    public partial class Estrelas : UserControl, IResposta
    {
        private string respostaSelecionada;

        public Estrelas()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            DesmarcarOutros(sender as CheckBox);

            // Atualizar a imagem e a resposta baseada no checkBox selecionado
            if (sender == estrelaPessimo)
            {
                AtualizarImagem(estrelaPessimo, "/Imagens/estrelaPessimo.png");
                respostaSelecionada = "Péssimo";
            }
            else if (sender == estrelaRuim)
            {
                AtualizarImagem(estrelaRuim, "/Imagens/estrelaRuim.png");
                respostaSelecionada = "Ruim";
            }
            else if (sender == estrelaRegular)
            {
                AtualizarImagem(estrelaRegular, "/Imagens/estrelaRegular.png");
                respostaSelecionada = "Regular";
            }
            else if (sender == estrelaBom)
            {
                AtualizarImagem(estrelaBom, "/Imagens/estrelaBom.png");
                respostaSelecionada = "Bom";
            }
            else if (sender == estrelaOtimo)
            {
                AtualizarImagem(estrelaOtimo, "/Imagens/estrelaOtimo.png");
                respostaSelecionada = "Ótimo";
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // Voltar a imagem para cinza quando desmarcado
            if (sender == estrelaPessimo)
                AtualizarImagem(estrelaPessimo, "/Imagens/estrelaPessimoCinza.png");
            else if (sender == estrelaRuim)
                AtualizarImagem(estrelaRuim, "/Imagens/estrelaRuimCinza.png");
            else if (sender == estrelaRegular)
                AtualizarImagem(estrelaRegular, "/Imagens/estrelaRegularCinza.png");
            else if (sender == estrelaBom)
                AtualizarImagem(estrelaBom, "/Imagens/estrelaBomCinza.png");
            else if (sender == estrelaOtimo)
                AtualizarImagem(estrelaOtimo, "/Imagens/estrelaOtimoCinza.png");
        }

        private void DesmarcarOutros(CheckBox selecionado)
        {
            // Desmarcar todas as checkboxes, exceto a selecionada
            if (selecionado != estrelaPessimo) estrelaPessimo.IsChecked = false;
            if (selecionado != estrelaRuim) estrelaRuim.IsChecked = false;
            if (selecionado != estrelaRegular) estrelaRegular.IsChecked = false;
            if (selecionado != estrelaBom) estrelaBom.IsChecked = false;
            if (selecionado != estrelaOtimo) estrelaOtimo.IsChecked = false;
        }

        private void AtualizarImagem(CheckBox checkBox, string imagemUri)
        {
            // Atualiza a imagem no CheckBox
            var image = checkBox.Content as Image;
            if (image != null)
            {
                image.Source = new BitmapImage(new Uri(imagemUri, UriKind.Relative));
            }
        }

        public string ObterResposta()
        {
            return respostaSelecionada; // Retorna a resposta selecionada
        }
    }
}
