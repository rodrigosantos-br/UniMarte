using System.Windows;
using System.Windows.Controls;
using UniMarteWpf.Apresentacao;
using UniMarteWpf.Controle;
using UniMarteWpf.Modelo;

namespace UniMarteWpf.ControleCustomizado
{
    /// <summary>
    /// Interação lógica para Gerenciador.xam
    /// </summary>
    public partial class Gerenciador : UserControl
    {
        private UsuarioControle usuarioControle;
        public List<Usuario> Usuarios { get; set; }

        public Gerenciador()
        {
            InitializeComponent();
            usuarioControle = new UsuarioControle();
            Loaded += Gerenciador_Loaded;
        }

        private void Gerenciador_Loaded(object sender, RoutedEventArgs e) 
        {
            CarregarUsuarios();   
        }

        private void CarregarUsuarios()
        { 
            var usuarios = usuarioControle.ObterTodosUsuarios();
            dgUsuarios.ItemsSource = usuarios;
        }

        private void Adicionar_Click(object sender, RoutedEventArgs e)
        {
            AdicionarUsuario adicionarUsuario = new AdicionarUsuario();
            adicionarUsuario.UsuarioAdicionado += AdicionarUsuario_UsuarioAdicionado;
            adicionarUsuario.ShowDialog();
        }

        private void AdicionarUsuario_UsuarioAdicionado(Usuario novoUsuario)
        {
            CarregarUsuarios(); // Atualiza o DataGrid
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            if (dgUsuarios.SelectedItem is Usuario usuarioSelecionado)
            {
                // Abra o diálogo de edição com o usuário selecionado
                var editarUsuarioWindow = new EditarUsuario(usuarioSelecionado);

                if (editarUsuarioWindow.ShowDialog() == true)
                {
                    // Se o diálogo retornou true, recarregue a lista de usuários
                    CarregarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Verifica se existem usuários na lista
                if (dgUsuarios.Items.Count <= 1)
                {
                    MessageBox.Show("Não é possível excluir o último usuário.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return; // Sai do método para evitar a exclusão
                }

                if (dgUsuarios.SelectedItem is Usuario usuarioSelecionado)
                {
                    MessageBoxResult resultado = MessageBox.Show(
                        $"Você tem certeza que deseja excluir o usuário {usuarioSelecionado.NomeUsuario}?",
                        "Confirmação de Exclusão",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Warning);

                    if (resultado == MessageBoxResult.Yes)
                    {
                        if (usuarioControle.ExcluirUsuario(usuarioSelecionado.NomeUsuario))
                        {
                            MessageBox.Show("Usuário excluído com sucesso.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                            CarregarUsuarios(); // Recarrega a lista de usuários
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir o usuário.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um usuário para remover.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
