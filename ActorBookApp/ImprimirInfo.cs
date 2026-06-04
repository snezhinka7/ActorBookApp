using System;
using System.Collections.Generic;
using System.Text;
using ActorBookApp.Interfaces;

namespace ActorBookApp
{
    internal class ImprimirInfo
    {
        public void ImprimirActor(IActorCine actorCine) { 
            Console.WriteLine($"ID: {actorCine.Id}");
            Console.WriteLine($"Nombre: {actorCine.Nombre}");
            Console.WriteLine($"Apellido: {actorCine.Apellido}");
        }
    }
}
