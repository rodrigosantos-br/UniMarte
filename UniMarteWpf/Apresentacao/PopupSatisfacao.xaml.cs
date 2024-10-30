using System.Windows;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para PopupSatisfacao.xaml
    /// </summary>
    public partial class PopupSatisfacao : Window
    {
        public PopupSatisfacao()
        {
            InitializeComponent();
        }

        private void btnNao_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSim_Click(object sender, RoutedEventArgs e)
        {
            Satisfacao satisfacao = new Satisfacao();
            satisfacao.ShowDialog();
            this.Close();
        }
    }
}
