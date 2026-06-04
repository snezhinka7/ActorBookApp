using System;
using System.Collections.Generic;
using System.Text;

namespace ActorBookApp.Models
{
    class ActorCine : Actor
    {
        public int Id;
        private string _Nombre;
        
        public override string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value.Trim(); }
        }

        public string NombreYApellido { get { return $"{Nombre} {Apellido}"; } }

        private string _Apellido;
        public override string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value.Trim(); }
        }
        public bool Oscar;
        public List<PeliculaEstelar> Peliculas;

        public ActorCine()
        {
            Id = 1;
            Peliculas = new List<PeliculaEstelar>();
            Oscar = false;
        }

        public string UsarPeliculas()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var pelicula in Peliculas)
            {
                sb.AppendLine($"El actor {NombreYApellido} participo en la pelicula '{pelicula.Nombre}'");
            }
            return sb.ToString();
        }

        public override string Actuar()
        {
            return $"{NombreYApellido} ha realizado una actuacion";
        }

        public override string LeerGuion()
        {
            return $"{NombreYApellido} está leyendo el guion de la película";
        }
    }

}
