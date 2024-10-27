using System.Windows.Controls;
using UniMarteWpf.DAL;
using UniMarteWpf.Modelo.ControleCustomizado;

namespace UniMarteWpf.Modelo.Controle
{
    public class PerguntaControle
    {
        private PerguntaDAO perguntaDAO;
        private List<Pergunta> perguntas;
        private List<Resposta> respostas; // Lista de respostas fornecidas pelo usuário
        private int perguntaAtualIndex;
        private string mensagem;

        public PerguntaControle()
        {
            perguntaDAO = new PerguntaDAO(); // Inicializa o DAO para buscar perguntas do banco
            perguntas = perguntaDAO.ObterPerguntas(); // Carrega todas as perguntas do banco
            perguntaAtualIndex = 0; // Inicializa com a primeira pergunta
            this.respostas = new List<Resposta>(); // Inicializa a lista de respostas vazia
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
        public bool ProximaPergunta()
        {
            if (perguntaAtualIndex < perguntas.Count - 1)
            {
                perguntaAtualIndex++;
                return true;
            }
            return false;
        }

        // Adicionar uma resposta à lista de respostas
        public void AdicionarResposta(int idPergunta, string respostaTexto)
        {
            var resposta = new Resposta
            {
                IdPergunta = idPergunta,
                RespostaTexto = respostaTexto
            };

            respostas.Add(resposta); // Adiciona à lista de respostas
        }

        // Método para verificar se está na última pergunta
        public bool EhUltimaPergunta()
        {
            return perguntaAtualIndex == perguntas.Count - 1;
        }

        public int ObterIdPerguntaAtual()
        {
            return perguntas[perguntaAtualIndex].Id; // Retorna o ID da pergunta atual
        }

        public void SalvarResposta(int idPergunta, int idVisitante, Panel respostaPanel)
        {
            // Inicializa a variável para a resposta
            string respostaTexto = string.Empty;

            // Obtém a resposta do controle apropriado
            foreach (var child in respostaPanel.Children)
            {
                if (child is IResposta respostaControl)
                {
                    respostaTexto = respostaControl.ObterResposta();
                    break;
                }
                else if (child is TextBox textBox)
                {
                    respostaTexto = textBox.Text;
                    break;
                }
            }

            // Cria um novo objeto Resposta
            Resposta novaResposta = new Resposta
            {
                IdPergunta = idPergunta,
                IdVisitante = idVisitante,
                RespostaTexto = respostaTexto
            };

            // Salva a resposta no banco de dados usando o DAO
            PerguntaDAO perguntaDAO = new PerguntaDAO();
            perguntaDAO.SalvarResposta(new List<Resposta> { novaResposta }); // Usando uma lista para compatibilidade
        }
    }
}
