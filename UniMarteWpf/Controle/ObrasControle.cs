using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UniMarteWpf
{
    public class ObrasControle
    {
        private List<string> _imagens;
        private int _indiceAtual;

        public ObrasControle()
        {
            CarregarImagens();
            _indiceAtual = 0; // Começar na primeira imagem
        }

        private void CarregarImagens()
        {
                // Carregar imagens como recursos
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

        public string ObterImagemAnterior()
        {
            if (_indiceAtual > 0)
                return _imagens[_indiceAtual - 1];
            return null; // ou retornar a primeira imagem
        }

        public string ObterImagemPosterior()
        {
            if (_indiceAtual < _imagens.Count - 1)
                return _imagens[_indiceAtual + 1];
            return null; // ou retornar a última imagem
        }

        public void Proximo()
        {
            if (_indiceAtual < _imagens.Count - 1)
                _indiceAtual++;
        }

        public void Anterior()
        {
            if (_indiceAtual > 0)
                _indiceAtual--;
        }
    }
}
