using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using UniMarteWpf.Apresentacao;

namespace UniMarteWpf
{
    public class ObrasControle
    {
        private List<string> _imagens;
        private int _indiceAtual;
        private DispatcherTimer _temporizador; // Timer para controle de tempo na última imagem
        private const int TempoPopUp = 10; // Tempo em segundos para exibir o pop-up
        private Window _owner; // Janela "dona" para exibir o popup

        public ObrasControle(Window owner)
        {
            _owner = owner; // Atribui a janela recebida
            CarregarImagens();
            _indiceAtual = 0;

            // Configurar o temporizador
            _temporizador = new DispatcherTimer();
            _temporizador.Interval = TimeSpan.FromSeconds(TempoPopUp);
            _temporizador.Tick += ExibirPopUp;
        }

        private void CarregarImagens()
        {
            _imagens = new List<string>
            {
                "pack://application:,,,/Imagens/Obras/chegada_marte.jpg",
                "pack://application:,,,/Imagens/Obras/colonia_espacial.jpg",
                "pack://application:,,,/Imagens/Obras/crateras_vulcoes.jpg",
                "pack://application:,,,/Imagens/Obras/exploracao_robotica.jpg",
                "pack://application:,,,/Imagens/Obras/horizonte_marte.jpg",
                "pack://application:,,,/Imagens/Obras/paisagens_noturnas.jpg",
                "pack://application:,,,/Imagens/Obras/primeira_base_marte.jpg",
                "pack://application:,,,/Imagens/Obras/solo_formacao_marte.jpg",
                "pack://application:,,,/Imagens/Obras/solo_vermelho.jpg",
                "pack://application:,,,/Imagens/Obras/tecnologia_colonizacao.jpg",
                "pack://application:,,,/Imagens/Obras/vales_marte.jpg",
                "pack://application:,,,/Imagens/Obras/viagem_marte.jpg",
            };
        }

        public string ObterImagemAtual() => _imagens[_indiceAtual];

        public string ObterImagemAnterior() => _indiceAtual > 0 ? _imagens[_indiceAtual - 1] : null;

        public string ObterImagemPosterior() => _indiceAtual < _imagens.Count - 1 ? _imagens[_indiceAtual + 1] : null;

        public void Proximo()
        {
            if (_indiceAtual < _imagens.Count - 1)
            {
                _indiceAtual++;
            }

            // Verificar se estamos na última imagem e iniciar o temporizador
            if (_indiceAtual == _imagens.Count - 1)
            {
                _temporizador.Start();
            }
        }

        public void Anterior()
        {
            if (_indiceAtual > 0)
            {
                _indiceAtual--;
            }
        }

        public void AtualizarImagens(Image imagemAtual, Image imagemAnterior, Image imagemPosterior)
        {
            string imagemAtualPath = ObterImagemAtual();
            string imagemAnteriorPath = ObterImagemAnterior();
            string imagemPosteriorPath = ObterImagemPosterior();

            // Define a imagem atual
            if (string.IsNullOrEmpty(imagemAtualPath))
            {
                throw new InvalidOperationException("Imagem atual não pode ser nula.");
            }
            imagemAtual.Source = new BitmapImage(new Uri(imagemAtualPath, UriKind.RelativeOrAbsolute));

            // Define a imagem anterior
            if (!string.IsNullOrEmpty(imagemAnteriorPath))
            {
                imagemAnterior.Source = new BitmapImage(new Uri(imagemAnteriorPath, UriKind.RelativeOrAbsolute));
                imagemAnterior.Visibility = Visibility.Visible;
            }
            else
            {
                imagemAnterior.Visibility = Visibility.Hidden;
            }

            // Define a imagem posterior
            if (!string.IsNullOrEmpty(imagemPosteriorPath))
            {
                imagemPosterior.Source = new BitmapImage(new Uri(imagemPosteriorPath, UriKind.RelativeOrAbsolute));
                imagemPosterior.Visibility = Visibility.Visible;
            }
            else
            {
                imagemPosterior.Visibility = Visibility.Hidden;
            }
        }

        private void ExibirPopUp(object sender, EventArgs e)
        {
            _temporizador.Stop();

            PopupSatisfacao satisfacao = new PopupSatisfacao
            {
                Owner = _owner,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            satisfacao.PopupFechado += () =>
            {
                _owner.Close(); // Fecha a janela "dona" (Obras)
            };

            satisfacao.ShowDialog();
        }
    }
}
