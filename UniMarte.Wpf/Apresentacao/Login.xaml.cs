using System.Windows;
using System.Windows.Controls;
using UniMarte.Wpf.Controle;
using UniMarte.Wpf.Modelo;

namespace UniMarte.Wpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private UsuarioControle usuarioControle;
        private Control activeControl;

        public Login()
        {
            InitializeComponent();
            usuarioControle = new UsuarioControle();
            Teclado.OnKeyPressed += Teclado_OnKeyPressed;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string nomeUsuario = txbNomeUsuario.Text;
            string senha = psbSenha.Password;

            Usuario usuario = usuarioControle.ObterUsuarioPorNome(nomeUsuario);

            if (usuario != null && usuario.Senha == senha)
            {
                // Abre a tela de administração após o login
                Adm adm = new Adm();
                adm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }

        private void Control_GotFocus(object sender, RoutedEventArgs e)
        {
            activeControl = sender as Control; // Define o controle ativo como o que recebeu o foco
        }

        private void Teclado_OnKeyPressed(object sender, string key)
        {
            // Obter a janela atual
            Window currentWindow = Window.GetWindow(this);

            // Verificar qual controle está ativo
            if (activeControl is TextBox textBox)
            {
                Utils.TecladoUtils.ProcessarTeclaPressionada(key, textBox, currentWindow);
            }
            else if (activeControl is PasswordBox passwordBox)
            {
                Utils.TecladoUtils.ProcessarTeclaPressionada(key, passwordBox, currentWindow);
            }
        }
    }
}
