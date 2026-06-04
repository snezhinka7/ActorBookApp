using System;
using System.Collections.Generic;
using System.Text;

namespace ActorBookApp.Models
{
    internal abstract class Actor
    {
        public abstract string Nombre { get; set; }
        public abstract string Apellido { get; set; }
        
        public abstract string Actuar();
        public virtual string LeerGuion() { return $"{Nombre} está leyendo el guion"; }
    }
}
