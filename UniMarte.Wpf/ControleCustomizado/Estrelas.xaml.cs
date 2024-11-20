using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using UniMarte.Wpf.Modelo;

namespace UniMarte.Wpf.ControleCustomizado
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
                AtualizarImagem(estrelaPessimo, "/Imagens/Icones/estrelaPessimo.png");
                respostaSelecionada = "1";
            }
            else if (sender == estrelaRuim)
            {
                AtualizarImagem(estrelaRuim, "/Imagens/Icones/estrelaRuim.png");
                respostaSelecionada = "2";
            }
            else if (sender == estrelaRegular)
            {
                AtualizarImagem(estrelaRegular, "/Imagens/Icones/estrelaRegular.png");
                respostaSelecionada = "3";
            }
            else if (sender == estrelaBom)
            {
                AtualizarImagem(estrelaBom, "/Imagens/Icones/estrelaBom.png");
                respostaSelecionada = "4";
            }
            else if (sender == estrelaOtimo)
            {
                AtualizarImagem(estrelaOtimo, "/Imagens/Icones/estrelaOtimo.png");
                respostaSelecionada = "5";
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // Voltar a imagem para cinza quando desmarcado
            if (sender == estrelaPessimo)
                AtualizarImagem(estrelaPessimo, "/Imagens/Icones/estrelaPessimoCinza.png");
            else if (sender == estrelaRuim)
                AtualizarImagem(estrelaRuim, "/Imagens/Icones/estrelaRuimCinza.png");
            else if (sender == estrelaRegular)
                AtualizarImagem(estrelaRegular, "/Imagens/Icones/estrelaRegularCinza.png");
            else if (sender == estrelaBom)
                AtualizarImagem(estrelaBom, "/Imagens/Icones/estrelaBomCinza.png");
            else if (sender == estrelaOtimo)
                AtualizarImagem(estrelaOtimo, "/Imagens/Icones/estrelaOtimoCinza.png");
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

        public List<Resposta> ObterResposta()
        {
            return new List<Resposta> { new Resposta { RespostaTexto = respostaSelecionada } };
        }
    }
}
