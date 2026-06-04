using System;
using System.Collections.Generic;
using System.Text;

namespace ActorBookApp.Models
{
    internal class ActorDoblaje : ActorCine
    {
        public string IdiomaDoblaje(string idioma) 
        { return $"El actor {NombreYApellido} realiza el doblaje en {idioma}"; }
    }
}
