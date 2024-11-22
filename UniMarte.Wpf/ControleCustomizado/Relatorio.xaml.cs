using System.Windows;
using System.Windows.Controls;
using UniMarte.Wpf.Controle;

namespace UniMarte.Wpf.ControleCustomizado
{
    /// <summary>
    /// Interação lógica para Relatorio.xam
    /// </summary>
    public partial class Relatorio : UserControl
    {
        private RelatorioControle relatorioControle = new RelatorioControle();

        public Relatorio()
        {
            InitializeComponent();
        }

        public void CarregarRelatorio()
        {
            var relatorio = relatorioControle.GerarRelatorio();

            txbAgradecimento.Text = "Muito obrigado por responder ao nosso questionário de satisfação!";
            txbMensagem.Text = "Sua opinião é fundamental para que possamos melhorar continuamente a experiência de nossos visitantes. Esperamos que tenha desfrutado da sua visita e que continue explorando as maravilhas do nosso museu. Até a próxima!";
            txbMedia.Text = $"{relatorio.mediaRespostas:F1}";
            txbTotalUsuarios.Text = $"({relatorio.totalVisitantes})";

            estrelasRelatorio.AtualizarEstrelas(relatorio.mediaRespostas);
            stkRelatorio.Visibility = Visibility.Visible;
        }

    }
}
