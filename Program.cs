Serie[] seriesArray = new Serie[5];
Videojuego[] videojuegosArray = new Videojuego[5];

seriesArray[0] = new Serie();
seriesArray[1] = new Serie("Dark", "Baran bo Odar");
seriesArray[2] = new Serie("The Flash", "Greg Berlanti", "Comics", 7);
seriesArray[3] = new Serie("The Walking Dead", "Rick Grimes", "Zombie", 8);
seriesArray[4] = new Serie("Rick and Morty", "Andy Bernard", "Comics", 9);

videojuegosArray[0] = new Videojuego();
videojuegosArray[1] = new Videojuego("God of War", "Santa Monica Studio");
videojuegosArray[2] = new Videojuego("Red dead Redemption 2", "Rockstar Games", "Accion", 60);
videojuegosArray[3] = new Videojuego("Nier Automata", "Nier Automata", "Accion", 40);
videojuegosArray[4] = new Videojuego("The Witcher 3", "Naugthy Dog", "Accion", 60);



seriesArray[0].entregar();
seriesArray[2].entregar();

videojuegosArray[0].entregar();
videojuegosArray[4].entregar();


int entregados = 0;

for (int i = 0; i < seriesArray.Length; i++)
{
    if (seriesArray[i].isEntregado())
    {
        entregados++;
        seriesArray[i].devolver();
    }
}

for (int i = 0; i < videojuegosArray.Length; i++)
{
    if (videojuegosArray[i].isEntregado())
    {
        entregados++;
        videojuegosArray[i].devolver();
    }
}

Console.WriteLine($"Hay {entregados} series entregadas");

Serie serieP = seriesArray[0];
Videojuego videojuegoP = videojuegosArray[0];

for (int i = 1; i < seriesArray.Length; i++)
{
    if(seriesArray[i].compareTo(serieP)==Serie.MayorQue)
    {
        serieP = seriesArray[i];
    }

    if (videojuegosArray[i].compareTo(videojuegoP) == Videojuego.MayorQue)
    {
        videojuegoP = videojuegosArray[i];
    }
}



Console.WriteLine();
Console.WriteLine($"La serie mas entregada es {serieP.getTitulo()}");
Console.WriteLine();
Console.WriteLine($"El videojuego mas entregado es {videojuegoP.getTitulo()}");
Console.WriteLine();
Console.WriteLine(serieP);
Console.WriteLine();
Console.WriteLine(videojuegoP);












