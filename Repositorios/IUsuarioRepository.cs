using Entidades.Models;
using Entidades.Repositorios;
using System.Linq;
using System.Data.SQLite;

namespace Entidades.Repositorios
{
    public interface IUsuarioRepository
    {
        public List<Usuario> ListarUsuarios();
        public void CrearUsuario(Usuario usuario);
    }    
}