namespace UniMarte.Web.Models
{
    public interface IUsuarioRepository
    {
        List<Usuario> ListarUsuarios();
        void AdicionarUsuario(Usuario usuario);
        Usuario ObterUsuarioPorId(int id);
        void EditarUsuario(Usuario usuario);
        void RemoverUsuario(Usuario usuario);
    }
}
