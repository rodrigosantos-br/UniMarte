using System.Windows;
using System.Windows.Controls;

namespace UniMarteWpf.Modelo.ControleCustomizado
{
    /// <summary>
    /// Interação lógica para SimNao.xam
    /// </summary>
    public partial class SimNao : UserControl, IResposta
    {
        public string RespostaSelecionada { get; private set; }

        public SimNao()
        {
            InitializeComponent();
        }

        private void ChkSim_Checked(object sender, RoutedEventArgs e)
        {
            RespostaSelecionada = "Sim";
            chkNao.IsChecked = false; // Desmarca "Não"
        }

        private void ChkNao_Checked(object sender, RoutedEventArgs e)
        {
            RespostaSelecionada = "Não";
            chkSim.IsChecked = false; // Desmarca "Sim"
        }

        public string ObterResposta()
        {
            return RespostaSelecionada; // Retorna a resposta escolhida
        }
    }
}
