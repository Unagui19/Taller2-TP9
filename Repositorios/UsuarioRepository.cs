using Entidades.Repositorios;
using Entidades.Models;
using System.Linq;
using System.Data.SQLite;

namespace Entidades.Repositorios
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private string cadenaConexion = "Data Source=db/Kanban.db;Cache=Shared"; // crea la conexion , es el string que me enlaza a la base de datos


       // ● Listar todos los usuarios registrados. (devuelve un List de Usuarios) 
        public List<Usuario> ListarUsuarios(){
            string queryString = $"SELECT * FROM Usuario;";
            List<Usuario> usuarios = new List<Usuario>();
            using (SQLiteConnection connection = new SQLiteConnection(cadenaConexion))
            {
                var command = new SQLiteCommand(queryString, connection);
                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())//Devuelve la consulta, es decir que lee la base de datos y trae lo que se pide
                {
                    while (reader.Read())//revisa si hay tuplas para leer, es decir si esta bien hecha la consulta
                    {
                        var usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(reader["id_usuario"]);
                        usuario.NombreDeUsuario = reader["nombre_de_usuario"].ToString();
                        usuarios.Add(usuario);
                    }
                }
                connection.Close();
            }
            return usuarios;
        }

        //         ● Crear un nuevo usuario. (recibe un objeto Usuario)
        public void CrearUsuario(Usuario usuario){
            string queryString = $"INSERT INTO Usuario (nombre_de_usuario) VALUE (@nombre_de_usuario)"; // string on la consulta deseada
            using (SQLiteConnection connection = new SQLiteConnection(cadenaConexion))//CREO LA VARIABLE DE CONEXION Y LA ESTABLEZCO
            {
                connection.Open(); //ABRO LA CONEXION
                var command = new SQLiteCommand(queryString, connection);//paso mi consulta y la conexion 
                    command.Parameters.Add(new SQLiteParameter("@nombre_de_usuario", usuario.NombreDeUsuario));
                    command.ExecuteNonQuery();//ejecutar la consulta sin que me devuelva un dato, solo se actualiza
                    connection.Close();   
            }
        }
        
// ● Modificar un usuario existente. (recibe un Id y un objeto Usuario)

// ● Obtener detalles de un usuario por su ID. (recibe un Id y devuelve un Usuario)
// ● Eliminar un usuario por ID
    }    
}