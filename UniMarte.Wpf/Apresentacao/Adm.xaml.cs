using System.Windows;
using UniMarte.Wpf.ControleCustomizado;

namespace UniMarte.Wpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Adm.xaml
    /// </summary>
    public partial class Adm : Window
    {
        public Adm()
        {
            InitializeComponent();
            CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            // Limpa o conteúdo anterior do Grid
            grdGerenciador.Children.Clear();
            grdGerenciador.Children.Add(relatorioAdm);
        }

        private void Relatorio_Click(object sender, RoutedEventArgs e)
        {
            grdGerenciador.Children.Clear();
            CarregarRelatorio();
        }

        public void Gerencia_Click(object sender, RoutedEventArgs e)
        {
            grdGerenciador.Children.Clear();
            Gerenciador gerenciador = new Gerenciador();
            grdGerenciador.Children.Add(gerenciador);
        }

        private void FinalizarSoftware_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
