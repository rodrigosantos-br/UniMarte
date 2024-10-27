using System.Windows;
using UniMarteWpf.Modelo;
using UniMarteWpf.Modelo.Controle;

namespace UniMarteWpf.Apresentacao
{
    /// <summary>
    /// Lógica interna para EditarUsuario.xaml
    /// </summary>
    public partial class EditarUsuario : Window
    {
        public Usuario Usuario { get; private set; }
        private UsuarioControle usuarioControle;

        public EditarUsuario(Usuario usuario)
        {
            InitializeComponent();
            usuarioControle = new UsuarioControle();
            Usuario = usuario;
            // Carrega os dados do usuário nos campos
            txtNomeUsuario.Text = usuario.NomeUsuario;
            txtSenha.Password = usuario.Senha;
            txtNomeCompleto.Text = usuario.NomeCompleto;
            txtIdade.Text = usuario.Idade.ToString();
            txtEmail.Text = usuario.Email;
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            // Atualiza os dados do objeto Usuario com os valores dos campos
            Usuario.NomeCompleto = txtNomeCompleto.Text;
            Usuario.Idade = int.TryParse(txtIdade.Text, out int idade) ? idade : Usuario.Idade; // Usa o valor atual se a conversão falhar
            Usuario.Email = txtEmail.Text;

            // Adicione a linha abaixo para atualizar a senha
            // Verifique se a PasswordBox tem algum valor antes de atribuir
            if (!string.IsNullOrWhiteSpace(txtSenha.Password))
            {
                Usuario.Senha = txtSenha.Password; // Atualiza a senha se for preenchida
            }

            // Chama o método de atualização no controle
            if (usuarioControle.AtualizarUsuario(Usuario))
            {
                MessageBox.Show("Usuário atualizado com sucesso.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                DialogResult = true; // Fecha a janela com sucesso
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o usuário.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Fecha a janela
        }
    }
}
