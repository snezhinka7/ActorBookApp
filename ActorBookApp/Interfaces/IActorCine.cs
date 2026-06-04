using System;
using System.Collections.Generic;
using System.Text;

namespace ActorBookApp.Interfaces
{
    internal interface IActorCine
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }

        void MensajeFinalizacion() {Console.WriteLine("Fin del Programa");}
    }
}
