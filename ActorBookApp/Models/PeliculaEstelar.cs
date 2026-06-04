using System;
using System.Collections.Generic;
using System.Text;

namespace ActorBookApp.Models
{
    class PeliculaEstelar
    {
        public string Nombre;
        public string Descripcion;
        public NivelAlcance Nivel;

        public PeliculaEstelar()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Nivel = NivelAlcance.Local;
        }
    }
}
