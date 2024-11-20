using System.Collections.ObjectModel;
using System.Windows.Controls;
using UniMarte.Wpf.Modelo;

namespace UniMarte.Wpf.ControleCustomizado
{
    public partial class EscolhaObra : UserControl, IResposta
    {
        public string RespostaSelecionada { get; private set; }
        public ObservableCollection<Obra> obras { get; set; } = new ObservableCollection<Obra>();

        public EscolhaObra()
        {
            InitializeComponent();
            ImageListBox.ItemsSource = obras;
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/chegada_marte.jpg", Titulo = "Chegada à Marte" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/colonia_espacial.jpg", Titulo = "Colônia Espacial"});
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/crateras_vulcoes.jpg", Titulo = "Cratera e Vulcões" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/exploracao_robotica.jpg", Titulo = "Exploração Robótica"});
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/horizonte_marte.jpg", Titulo = "Horizonte Marte" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/paisagens_noturnas.jpg", Titulo = "Paisagens Noturnas" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/primeira_base_marte.jpg", Titulo = "Primeira Base em Marte" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/solo_formacao_marte.jpg", Titulo = "Solo Foormação Marte" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/solo_vermelho.jpg", Titulo = "Solo Vermelho" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/tecnologia_colonizacao.jpg", Titulo = "Tecnologia de Colonização" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/vales_marte.jpg", Titulo = "Vales de Marte" });
            obras.Add(new Obra { ImagemUrl = "/Imagens/Obras/viagem_marte.jpg", Titulo = "Viagem à Marte" });

            ImageListBox.SelectionChanged += ImageListBox_SelectionChanged;
        }

        // Método chamado ao selecionar uma obra
        private void ImageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ImageListBox.SelectedIndex >= 0) // Verifica se há uma seleção
            {
                // Retorna "Obra 1", "Obra 2", etc., conforme o índice
                RespostaSelecionada = $"Obra {ImageListBox.SelectedIndex + 1}";
            }
        }

        // Método ObterResposta retorna a obra selecionada
        public List<Resposta> ObterResposta()
        {
            return new List<Resposta> { new Resposta { RespostaTexto = RespostaSelecionada } };
        }
    }
}
