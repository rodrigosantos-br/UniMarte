using System.Windows;
using System.Windows.Controls;
using UniMarteWpf.DAL;
using UniMarteWpf.Estatico;
using UniMarteWpf.Modelo;
using UniMarteWpf.ControleCustomizado;

namespace UniMarteWpf.Controle
{
    public class PerguntaControle
    {
        private PerguntaDAO perguntaDAO;
        private List<Pergunta> perguntas;
        private List<IResposta> controles; // Lista de respostas fornecidas pelo usuário
        private int perguntaAtualIndex;

        public PerguntaControle(List<IResposta> controles)
        {
            perguntaDAO = new PerguntaDAO(); // Inicializa o DAO para buscar perguntas do banco
            perguntas = perguntaDAO.ObterPerguntas(); // Carrega todas as perguntas do banco
            perguntaAtualIndex = 0; // Inicializa com a primeira pergunta
            this.controles = controles;
        }

        // Método para exibir a pergunta atual na View
        public void ExibirPerguntaAtual(TextBlock perguntaTextBlock, Panel respostaPanel)
        {
            // Limpa o painel de resposta antes de adicionar novos controles
            respostaPanel.Children.Clear();

            // Obtém a pergunta atual
            Pergunta perguntaAtual = perguntas[perguntaAtualIndex];

            // Exibe o texto da pergunta
            perguntaTextBlock.Text = perguntaAtual.Texto;

            // Verifica o tipo de resposta e cria o controle adequado
            switch (perguntaAtual.TipoResposta.ToLower())
            {
                case "escolhaobra":
                    EscolhaObra escolhaObraControl = new EscolhaObra();
                    respostaPanel.Children.Add(escolhaObraControl);
                    break;

                case "estrelas":
                    Estrelas estrelasControl = new Estrelas();
                    respostaPanel.Children.Add(estrelasControl);
                    break;

                case "simnao":
                    SimNao simNaoControl = new SimNao();
                    respostaPanel.Children.Add(simNaoControl);
                    break;

                default:
                    TextBox textBox = new TextBox { Width = 300, Height = 30 };
                    respostaPanel.Children.Add(textBox);
                    break;
            }
        }

        // Método para avançar para a próxima pergunta
        public bool ProximaPergunta(Panel respostaPanel)
        {
            if (perguntaAtualIndex < perguntas.Count - 1)
            {
                perguntaAtualIndex++;
                return true;
            }
            else
            {
                return false; // Se já estiver na última pergunta, não avança
            }
        }

        // Método para verificar se está na última pergunta
        public bool EhUltimaPergunta()
        {
            return perguntaAtualIndex == perguntas.Count - 1;
        }

        // Método para salvar a resposta e validar se está preenchida usando o método ValidarRespostas
        public bool SalvarResposta(Panel respostaPanel)
        {
            string mensagemErro;
            var respostas = new List<Resposta>();

            if (perguntaAtualIndex < perguntas.Count)
            {
                Pergunta perguntaAtual = perguntas[perguntaAtualIndex];
                int idVisitante = SessaoVisitante.IdVisitante;
                int idPergunta = perguntaAtual.Id;
                string respostaTexto = string.Empty;

                // Extrair resposta do controle atual
                foreach (var child in respostaPanel.Children)
                {
                    if (child is IResposta respostaControl)
                    {
                        var respostaObtida = respostaControl.ObterResposta();
                        if (respostaObtida.Any())
                        {
                            respostaTexto = respostaObtida.First().RespostaTexto;
                        }
                        break;
                    }
                    else if (child is TextBox textBox)
                    {
                        respostaTexto = textBox.Text;
                        break;
                    }
                }

                Resposta novaResposta = new Resposta
                {
                    IdVisitante = idVisitante,
                    IdPergunta = idPergunta,
                    RespostaTexto = respostaTexto
                };

                respostas.Add(novaResposta);

                // Usa o método de validação para verificar se a resposta está preenchida
                if (!Validacao.ValidarRespostas(respostas, out mensagemErro))
                {
                    MessageBox.Show(mensagemErro, "Validação de Resposta", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false; // Impede o avanço se a resposta não for válida
                }

                // Salvar a resposta no banco de dados
                perguntaDAO.SalvarRespostas(new List<Resposta> { novaResposta });
                return true;
            }

            return false; // Caso nenhuma resposta seja adicionada
        }

    }
}
