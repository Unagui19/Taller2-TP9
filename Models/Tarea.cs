namespace Entidades.Models
{
    public enum Estado{Ideas = 1, ToDo, Doing, Review, Done};
    public class Tarea
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Descripcion{get;set;}
        public string Color{get;set;}
        public Estado EstadoTarea{get;set;}
        public int? IdUsuarioAsignado{get;set;}

        public Tarea(int id){
            Id=id;
            EstadoTarea=Estado.Ideas;
        }
        public Tarea(int id, string nombre, string descrip, string color, Estado estado, int? idUsu){
            Id = id;
            Nombre = nombre;
            Descripcion = descrip;
            Color = color;
            EstadoTarea = estado;
            IdUsuarioAsignado = idUsu;
        }
    }
}