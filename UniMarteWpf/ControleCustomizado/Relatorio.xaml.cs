using System.Windows;
using System.Windows.Controls;
using UniMarteWpf.Controle;

namespace UniMarteWpf.ControleCustomizado
{
    /// <summary>
    /// Interação lógica para Relatorio.xam
    /// </summary>
    public partial class Relatorio : UserControl
    {
        private RelatorioControle relatorioControle = new RelatorioControle();

        public Relatorio()
        {
            //InitializeComponent();
            CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            var relatorio = relatorioControle.GerarRelatorio();

            //Atualiza os TextBlocks com as informações do relatório

            txbTotalUsuarios.Text = $"Total de Visitantes: {relatorio.totalVisitantes}";
            txbMedia.Text = $"Média das Respostas: {relatorio.mediaRespostas:F2}";

            // Atualiza o UserControl de estrelas
            estrelasRelatorio.AtualizarEstrelas(relatorio.mediaRespostas);
            stkRelatorio.Visibility = Visibility.Visible;
            //Muda a visibilidade do StackPanel para Visible
        }
    }
}
