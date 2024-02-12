namespace Entidades
{
    public class Usuario
    {
        public int Id {get;set;}
        public string NombreDeUsuario {get;set;}

        public Usuario(int id){
            int Id = id;
        }

        public Usuario(int id, string nombre){
            int Id = id;
            string NombreDeUsuario = nombre;
        }
    }    
}