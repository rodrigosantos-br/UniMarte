using System.Windows.Controls;
using UniMarteWpf.DAL;
using UniMarteWpf.Modelo.ControleCustomizado;

namespace UniMarteWpf.Modelo.Controle
{
    public class PerguntaControle
    {
        private PerguntaDAO perguntaDAO;
        private List<Pergunta> perguntas;
        private List<IResposta> controles; // Lista de respostas fornecidas pelo usuário
        private bool isFinalizado = false;
        private int perguntaAtualIndex;

        public PerguntaControle(List<IResposta> controles)
        {
            perguntaDAO = new PerguntaDAO(); // Inicializa o DAO para buscar perguntas do banco
            perguntas = perguntaDAO.ObterPerguntas(); // Carrega todas as perguntas do banco
            perguntaAtualIndex = 0; // Inicializa com a primeira pergunta
            this.controles = controles;
        }

        public int PerguntaAtualIndex => perguntaAtualIndex;

        public List<Resposta> ColetarRespostas()
        {
            List<Resposta> respostas = new List<Resposta>();

            foreach (var controle in controles)
            {
                respostas.AddRange(controle.ObterResposta());
            }

            return respostas;
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

        public int ObterIdPerguntaAtual()
        {
            return perguntas[perguntaAtualIndex].Id; // Retorna o ID da pergunta atual
        }

        // Método para avançar para a próxima pergunta
        public bool ProximaPergunta()
        {
            if (perguntaAtualIndex < perguntas.Count - 1)
            {
                perguntaAtualIndex++;
                return true;
            }
            else
            {
                isFinalizado = true; // Define flag como true na última pergunta
                return false;
            }
        }

        // Método para verificar se está na última pergunta
        public bool EhUltimaPergunta()
        {
            return perguntaAtualIndex == perguntas.Count - 1;
        }

        public void SalvarResposta(Panel respostaPanel)
        {
            if (perguntaAtualIndex < perguntas.Count)
            {
                Pergunta perguntaAtual = perguntas[perguntaAtualIndex];
                int idPergunta = perguntaAtual.Id; // Pegando o ID diretamente da pergunta atual
                string respostaTexto = string.Empty;

                foreach (var child in respostaPanel.Children)
                {
                    if (child is IResposta respostaControl)
                    {
                        var respostas = respostaControl.ObterResposta();
                        if (respostas.Any())
                        {
                            respostaTexto = respostas.First().RespostaTexto;
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
                    IdPergunta = idPergunta,
                    RespostaTexto = respostaTexto
                };

                perguntaDAO.SalvarRespostas(new List<Resposta> { novaResposta });
            }
        }

    }
}
