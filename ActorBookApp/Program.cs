using System.Text;
using ActorBookApp.Models;
using ActorBookApp;
using ActorBookApp.Interfaces;
using System.Collections.Generic;

Console.WriteLine("Bienvenido al ActorBook!");

var imprimirInfo = new ImprimirInfo();

var pelicula1 = new PeliculaEstelar();
pelicula1.Nombre = "The Dark Night";
pelicula1.Descripcion = "Batman se enfrenta a su mayor desafío";
pelicula1.Nivel = NivelAlcance.Internacional;

var pelicula2 = new PeliculaEstelar();
pelicula2.Nombre = "Inception";
pelicula2.Descripcion = "Un ladrón que roba secretos a través de los sueños";
pelicula2.Nivel = NivelAlcance.Nacional;

var pelicula3 = new PeliculaEstelar();
pelicula3.Nombre = "Gato con Botas";
pelicula3.Descripcion = "un gato que lleva botas y pelea";
pelicula3.Nivel = NivelAlcance.Internacional;

var person1 = new ActorCine();

person1.Id = 1;
person1.Nombre = "Christian";
person1.Apellido = "Bale";
person1.Oscar = true;
List<PeliculaEstelar> peliculasChristian = new List<PeliculaEstelar>();
peliculasChristian.Add(pelicula1);
peliculasChristian.Add(pelicula2);
person1.Peliculas = peliculasChristian;
string resultadoPeliculasChris = person1.UsarPeliculas();
Console.WriteLine(resultadoPeliculasChris);
string resultadoActuacionChris = person1.Actuar();
Console.WriteLine(resultadoActuacionChris);
string resultadoLeerGuionChris = person1.LeerGuion();
Console.WriteLine(resultadoLeerGuionChris);
imprimirInfo.ImprimirActor(person1);


var person2 = new ActorDoblaje();
person2.Id = 2;
person2.Nombre = "Antonio";
person2.Apellido = "Banderas";
person2.Oscar = false;
List<PeliculaEstelar> peliculasAntonio = new List<PeliculaEstelar>();
peliculasAntonio.Add(pelicula3);
person2.Peliculas = peliculasAntonio;
string resultadoPeliculasAntonio = person2.UsarPeliculas();
Console.WriteLine(resultadoPeliculasAntonio);
string resultadoDoblajeAntonio = person2.IdiomaDoblaje("español");
Console.WriteLine(resultadoDoblajeAntonio);
imprimirInfo.ImprimirActor(person2);

((IActorCine)person1).MensajeFinalizacion();


enum NivelAlcance
{
    Local,
    Nacional,
    Internacional
}