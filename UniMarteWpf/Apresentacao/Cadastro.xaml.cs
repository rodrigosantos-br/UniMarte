using System.Windows;
using System.Windows.Controls;
using UniMarteWpf.Controle;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        private Control activeControl;
        public Cadastro()
        {
            InitializeComponent();
            Teclado.OnKeyPressed += Teclado_OnKeyPressed;
        }

        private void Teclado_OnKeyPressed(object sender, string key)
        {
            // Obter a janela atual
            Window currentWindow = Window.GetWindow(this);

            // Processa a tecla pressionada para o controle ativo (TextBox, PasswordBox, ou DatePicker)
            if (activeControl != null)
            {
                Utils.TecladoUtils.ProcessarTeclaPressionada(key, activeControl, currentWindow);
            }

            // Verifica se o texto do TextBox ativo corresponde à senha "entraradm" para exibir o botão administrativo
            if (txbNome.Text == "entraradm")
            {
                btnAdm.Visibility = Visibility.Visible;
            }
            else
            {
                btnAdm.Visibility = Visibility.Hidden;
            }
        }

        private void Control_GotFocus(object sender, RoutedEventArgs e)
        {
            activeControl = sender as Control; // Define o controle ativo como o que recebeu o foco
        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            // Obtém os valores dos controles
            string nome = txbNome.Text;
            DateTime? dataNascimento = dtpDataNascimento.SelectedDate;

            if (dataNascimento == null)
            {
                MessageBox.Show("Por favor, selecione uma data de nascimento válida.");
                return;
            }

            // Instancia o controle e cadastra o visitante
            VisitanteControle controle = new VisitanteControle();
            bool sucesso = controle.CadastrarVisitante(nome, dataNascimento.Value);

            // Exibe o resultado do cadastro
            if (sucesso)
            {
                Obras obras = new Obras();
                obras.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }
        }

        private void btnAdm_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void PaginaInicial_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
