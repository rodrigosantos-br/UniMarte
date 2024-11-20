using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using UniMarteWpf.Apresentacao;
using UniMarteWpf.DAL;
using UniMarteWpf.Modelo;

namespace UniMarteWpf
{
    public class ObrasControle
    {
        private List<string> _imagensPaths;
        private int _indiceAtual;
        private Dictionary<string, Obra> _obrasInfo;
        private Obras _janela; // Janela "dona" para exibir o popup
        private DispatcherTimer _temporizador; // Timer para controle de tempo na última imagem
        private const int TempoPopUp = 10; // Tempo em segundos para exibir o pop-up

        public ObrasControle(Obras janela)
        {
            _janela = janela;
            _imagensPaths = new List<string>
            {
                "chegada_marte.jpg",
                "colonia_espacial.jpg",
                "crateras_vulcoes.jpg",
                "exploracao_robotica.jpg",
                "horizonte_marte.jpg",
                "paisagens_noturnas.jpg",
                "primeira_base_marte.jpg",
                "solo_formacao_marte.jpg",
                "solo_vermelho.jpg",
                "tecnologia_colonizacao.jpg",
                "vales_marte.jpg",
                "viagem_marte.jpg"
            };
            _indiceAtual = 0;
            _obrasInfo = new ObraDAO().ObterInformacoesObras();
            // Configurar o temporizador
            _temporizador = new DispatcherTimer();
            _temporizador.Interval = TimeSpan.FromSeconds(TempoPopUp);
            _temporizador.Tick += ExibirPopUp;
        }

        public void Proximo()
        {
            if (_indiceAtual < _imagensPaths.Count - 1) // Não vai para a primeira obra se já estiver na última
            {
                _indiceAtual++;
                AtualizarImagens();  // Atualiza as imagens e verifica o pop-up
            }
        }

        public void Anterior()
        {
            if (_indiceAtual > 0)
            {
                _indiceAtual--;
                AtualizarImagens();  // Atualiza as imagens e reinicia o temporizador
            }
        }

        public void AtualizarImagens()
        {
            int indiceAnterior = _indiceAtual == 0 ? -1 : _indiceAtual - 1; // -1 indica que não há imagem anterior
            int indicePosterior = _indiceAtual == _imagensPaths.Count - 1 ? -1 : _indiceAtual + 1; // -1 indica que não há imagem posterior

            string caminhoBase = "/Imagens/Obras/";

            // Atualiza a imagem atual
            _janela.ImagemAtual.Source = new BitmapImage(new Uri(caminhoBase + _imagensPaths[_indiceAtual], UriKind.Relative));

            // Se não houver imagem anterior (primeira imagem), torna a imagem anterior transparente
            if (indiceAnterior == -1)
            {
                _janela.ImagemAnterior.Source = null;
                _janela.ImagemAnterior.Opacity = 0; // Torna a imagem anterior invisível, mas mantém a borda
            }
            else
            {
                _janela.ImagemAnterior.Source = new BitmapImage(new Uri(caminhoBase + _imagensPaths[indiceAnterior], UriKind.Relative));
                _janela.ImagemAnterior.Opacity = 1; // Torna a imagem visível
            }

            // Se não houver imagem posterior (última imagem), torna a imagem posterior transparente
            if (indicePosterior == -1)
            {
                _janela.ImagemPosterior.Source = null;
                _janela.ImagemPosterior.Opacity = 0; // Torna a imagem posterior invisível, mas mantém a borda
            }
            else
            {
                _janela.ImagemPosterior.Source = new BitmapImage(new Uri(caminhoBase + _imagensPaths[indicePosterior], UriKind.Relative));
                _janela.ImagemPosterior.Opacity = 1; // Torna a imagem visível
            }

            // Atualiza as informações da obra atual
            if (_obrasInfo.TryGetValue(_imagensPaths[_indiceAtual], out Obra obraAtual))
            {
                _janela.TituloObra.Text = obraAtual.Titulo;
                _janela.HistoricoObra.Text = obraAtual.Historico;
            }

            // Verifica se é a última obra
            if (_indiceAtual == _imagensPaths.Count - 1)
            {
                // Inicia o temporizador para exibir o pop-up após 10 segundos se for a última obra
                if (!_temporizador.IsEnabled)
                {
                    _temporizador.Start();  // Inicia o temporizador somente se ainda não estiver rodando
                }
            }
        }

        private void ExibirPopUp(object sender, EventArgs e)
        {
            _temporizador.Stop(); // Para o temporizador após exibir o pop-up

            PopupSatisfacao satisfacao = new PopupSatisfacao
            {
                Owner = _janela,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            satisfacao.PopupFechado += () =>
            {
                _janela.Close(); // Fecha a janela "dona" (Obras)
            };

            satisfacao.ShowDialog();
        }

    }
}
