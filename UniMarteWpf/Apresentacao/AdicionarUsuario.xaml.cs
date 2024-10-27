using System.Windows;
using UniMarteWpf.Modelo;
using UniMarteWpf.Modelo.Controle;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para AdicionarUsuario.xaml
    /// </summary>
    public partial class AdicionarUsuario : Window
    {
        private UsuarioControle usuarioControle;
        public event Action<Usuario> UsuarioAdicionado;
        public AdicionarUsuario()
        {
            InitializeComponent();
            usuarioControle = new UsuarioControle();
        }

        private void Adicionar_Click(object sender, RoutedEventArgs e)
        {
            // Cria um novo objeto Usuario e preenche com os dados da interface
            Usuario novoUsuario = new Usuario
            {
                NomeUsuario = txtNomeUsuario.Text,
                Senha = txtSenha.Password, // Captura a senha da PasswordBox
                NomeCompleto = txtNomeCompleto.Text,
                Idade = int.TryParse(txtIdade.Text, out int idade) ? idade : 0, // Atribui 0 se a conversão falhar
                Email = txtEmail.Text
            };

            // Chama o método de adição no controle
            if (usuarioControle.InserirUsuario(novoUsuario))
            {
                UsuarioAdicionado?.Invoke(novoUsuario);
                MessageBox.Show("Usuário adicionado com sucesso.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                DialogResult = true; // Fecha a janela com sucesso
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o usuário.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
