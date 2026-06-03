using System.Text;

Console.WriteLine("Bienvenido al ActorBook!");

var pelicula1 = new PeliculaEstelar();
pelicula1.Nombre = "The Dark Night";
pelicula1.Descripcion = "Batman se enfrenta a su mayor desafío";
pelicula1.Nivel = NivelAlcance.Internacional;

var pelicula2 = new PeliculaEstelar();
pelicula2.Nombre = "Inception";
pelicula2.Descripcion = "Un ladrón que roba secretos a través de los sueños";
pelicula2.Nivel = NivelAlcance.Nacional;

var person1 = new Actor();

person1.Id = 1;
person1.Nombre = "Christian Bale";
person1.Oscar = true;
List<PeliculaEstelar> peliculas = new List<PeliculaEstelar>();
peliculas.Add(pelicula1);
peliculas.Add(pelicula2);
person1.Peliculas = peliculas;

string resultadoPeliculas = person1.UsarPeliculas();
Console.WriteLine(resultadoPeliculas);



class Actor
{
    public int Id;
    public string Nombre;
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
            sb.AppendLine($"El actor {Nombre} participo en la pelicula '{pelicula.Nombre}'");
        }
        return sb.ToString();
    }
}

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

enum NivelAlcance
{
    Local,
    Nacional,
    Internacional
}