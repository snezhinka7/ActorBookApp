Console.WriteLine("Actores");

var pelicula1 = new PeliculaEstelar();
pelicula1.Nombre = "The Dark Night";
pelicula1.Descripcion = "Batman se enfrenta a su mayor desafío";
pelicula1.Nivel = NivelAlcance.Internacional;

var person1 = new Actor();
var person2 = new Actor();

person1.Id = 1;
person1.Nombre = "Christian Bale";
person1.Oscar = true;
List<PeliculaEstelar> peliculas = new List<PeliculaEstelar>();
peliculas.Add(pelicula1);
person1.Peliculas = peliculas;



class Actor
{
    public int Id;
    public string Nombre;
    public bool Oscar;
    public List<PeliculaEstelar> Peliculas;
}

class PeliculaEstelar
{
    public string Nombre;
    public string Descripcion;
    public NivelAlcance Nivel;
}

enum NivelAlcance
{
    Local,
    Nacional,
    Internacional
}