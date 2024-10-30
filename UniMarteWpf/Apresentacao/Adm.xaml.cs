using Microsoft.Web.WebView2.Wpf;
using System.Windows;
using UniMarteWpf.ControleCustomizado;

namespace UniMarteWpf.Apresentacao
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

            // Cria uma nova instância do WebView2
            WebView2 powerBIWebView = new WebView2();

            // Define as propriedades necessárias (opcional)
            powerBIWebView.HorizontalAlignment = HorizontalAlignment.Stretch;
            powerBIWebView.VerticalAlignment = VerticalAlignment.Stretch;

            // Define a URL do relatório Power BI
            string reportUrl = "https://app.powerbi.com/view?r=eyJrIjoiZGFjNTc5YmQtY2JhZC00MzYyLWJhOGQtNDdmNzU4ZWFjMTAzIiwidCI6ImIxMDUxYzRiLTNiOTQtNDFhYi05NDQxLWU3M2E3MjM0MmZkZCJ9";
            powerBIWebView.Source = new Uri(reportUrl);

            // Adiciona o WebView2 ao Grid
            grdGerenciador.Children.Add(powerBIWebView);
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

        private void FecharAdm_Click(object sender, RoutedEventArgs e)
        { 
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void FinalizarSoftware_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
