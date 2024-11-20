using UniMarte.Wpf.DAL;
using UniMarte.Wpf.Estatico;
using UniMarte.Wpf.Modelo;

namespace UniMarte.Wpf.Controle
{
    public class UsuarioControle
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public bool InserirUsuario(Usuario usuario)
        {
            if (Validacao.ValidarUsuario(usuario))
            {
                return usuarioDAO.InserirUsuario(usuario);
            }
            return false;
        }

        public List<Usuario> ObterTodosUsuarios()
        {
            return usuarioDAO.ObterTodosUsuarios();
        }

        public Usuario ObterUsuarioPorNome(string nomeUsuario)
        {
            return usuarioDAO.ObterUsuarioPorNome(nomeUsuario);
        }

        public bool AtualizarUsuario(Usuario usuario)
        {
            if (Validacao.ValidarUsuario(usuario))
            {
                return usuarioDAO.AtualizarUsuario(usuario);
            }
            return false;
        }

        public bool ExcluirUsuario(string nomeUsuario)
        {
            return usuarioDAO.ExcluirUsuario(nomeUsuario);
        }
    }
}
