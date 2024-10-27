using System.Windows;
using System.Windows.Controls;
using UniMarteWpf.Modelo;
using UniMarteWpf.Modelo.Controle;

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
            // Obter o TextBox ativo (adapte conforme necessário)
            if (activeControl is TextBox textBox)
            {
                // Obter a janela atual
                Window currentWindow = Window.GetWindow(this);

                // Processar a tecla pressionada
                Utils.TecladoUtils.ProcessarTeclaPressionada(key, activeControl, currentWindow);
            }
            // Verifica se o texto é "entraradm" para exibir o botão
            if (txbNome.Text == "entraradm")
            {
                // Exibe o botão na tela (substitua 'meuBotao' pelo nome do seu botão)
                btnAdm.Visibility = Visibility.Visible;
            }
            else
            {
                // Caso contrário, esconde o botão
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
    }
}
