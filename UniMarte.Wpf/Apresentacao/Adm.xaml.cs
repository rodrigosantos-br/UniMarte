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
            // Tenta acessar o controle existente
            if (grdGerenciador.Children.Count > 0 && grdGerenciador.Children[0] is RelatorioAdm relatorioAtual)
            {
                relatorioAtual.AtualizarDados(); // Atualiza os dados sem recriar o controle
            }
            else
            {
                // Caso o controle não exista, cria um novo
                grdGerenciador.Children.Clear();
                grdGerenciador.Children.Add(new RelatorioAdm());
            }
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
