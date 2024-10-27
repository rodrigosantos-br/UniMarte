using System.Windows;
using UniMarteWpf.DAL;
using UniMarteWpf.Modelo;
using UniMarteWpf.Modelo.Controle;
using UniMarteWpf.Modelo.ControleCustomizado;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Satisfacao.xaml
    /// </summary>
    public partial class Satisfacao : Window
    {
        private PerguntaControle perguntaControle;
        private PerguntaDAO perguntaDAO;

        public Satisfacao()
        {
            InitializeComponent();
            this.perguntaDAO = new PerguntaDAO();
            // Inicializa PerguntaControle com os controles de respostas
            this.perguntaControle = new PerguntaControle(new List<IResposta> {
            new SimNao(), new EscolhaObra(), new Estrelas()
        });
            perguntaControle.ExibirPerguntaAtual(PerguntaTextBlock, RespostaPanel);
        }

        // Evento do botão "Próxima"
        private void ProximaPergunta_Click(object sender, RoutedEventArgs e)
        {
            // Salva a resposta antes de ir para a próxima pergunta
            perguntaControle.SalvarResposta(RespostaPanel);

            if (perguntaControle.ProximaPergunta())
            {
                perguntaControle.ExibirPerguntaAtual(PerguntaTextBlock, RespostaPanel);
            }
            else if (perguntaControle.EhUltimaPergunta())
            {
                btnProximaPergunta.Visibility = Visibility.Collapsed;
                btnSalvar.Visibility = Visibility.Visible;
            }
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            // Coleta todas as respostas dos controles
            List<Resposta> respostas = perguntaControle.ColetarRespostas();

            // Salva as respostas no banco de dados associadas ao visitante atual
            // Obtenha o ID da pergunta atual
            int idPerguntaAtual = perguntaControle.ObterIdPerguntaAtual();

            if (!perguntaControle.EhUltimaPergunta())
            {
                perguntaControle.SalvarResposta(RespostaPanel);
                if (!perguntaControle.ProximaPergunta())
                {
                    MessageBox.Show("Questionário concluído.");
                }
            }
            
        }

    }
}


