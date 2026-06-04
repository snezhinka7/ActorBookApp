using System;
using System.Collections.Generic;
using System.Text;

namespace ActorBookApp.Models
{
    class Actor
    {
        public int Id;
        private string _Nombre;
        
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value.Trim(); }
        }

        public string NombreYApellido { get { return $"{Nombre} {Apellido}"; } }

        public string Apellido;
        public bool Oscar;
        public List<PeliculaEstelar> Peliculas;

        public Actor()
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
    }

}
