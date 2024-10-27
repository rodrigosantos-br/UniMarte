using System.Windows;
using UniMarteWpf.Estatico;
using UniMarteWpf.Modelo.Controle;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Satisfacao.xaml
    /// </summary>
    public partial class Satisfacao : Window
    {
        private PerguntaControle perguntaControle;

        
        public Satisfacao()
        {
            InitializeComponent();
            perguntaControle = new PerguntaControle();

            // Carrega as perguntas na view, passando o StackPanel onde as perguntas serão exibidas
            perguntaControle.ExibirPerguntaAtual(PerguntaTextBlock, RespostaPanel);
        }

        // Evento do botão "Próxima"
        private void ProximaPergunta_Click(object sender, RoutedEventArgs e)
        {
            if (perguntaControle.ProximaPergunta())
            {
                perguntaControle.ExibirPerguntaAtual(PerguntaTextBlock, RespostaPanel); // Exibe a próxima pergunta
            }
            else if (perguntaControle.EhUltimaPergunta())
            {
                
                btnProximaPergunta.Visibility = Visibility.Collapsed; // Esconde o botão de próxima pergunta
                btnSalvar.Visibility = Visibility.Visible;               // Mostra o botão de salvar
            }
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            int idPergunta = perguntaControle.ObterIdPerguntaAtual();
            
            // Aqui você chama o método SalvarResposta do controle de perguntas, passando o ID do visitante e da pergunta
            perguntaControle.SalvarResposta(idPergunta,AtualVisitanteId.atualVisitanteId, RespostaPanel);
            MessageBox.Show("Respostas salvas com sucesso!"); // Mensagem de sucesso ao salvar
            this.Close(); // Opcional: fecha a janela após salvar
        }
    }
}


