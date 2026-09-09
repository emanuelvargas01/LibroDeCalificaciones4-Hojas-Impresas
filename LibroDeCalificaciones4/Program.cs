using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeCalificaciones4
{
    //Fig. 5.6: PruebaLibroCalificaciones.cs
    //Crea el objeto LibroCalificaciones e invoca a su metodo DeterminarPromedio
    public class LibroCalificaciones4
    {
        public static void Main(string[] args)
        {
            // crea el objeto miLibroCalificaciones y
            // pasa el nombre del curso al constructor
          LibroCalificaciones miLibroCalificaciones2 = new LibroCalificaciones("CS101 Introduccion a la programacion en C#");
            miLibroCalificaciones2.MostrarMensaje(); //muestra el mensaje de bienvenida
            miLibroCalificaciones2.DeterminarPromedioClase();// encuentra el promedio de 10 calificaciones
            LibroCalificaciones1 miLibroCalificaciones = new LibroCalificaciones1("CS101 Introduccion a la programacion en C#");
            miLibroCalificaciones.MostrarMensaje(); //muestra el mensaje de bienvenida
            miLibroCalificaciones.DeterminarPromedioClase();// encuentra el promedio de 10 calificaciones
        }//fin del main 
    }//fin de la clase PruebaLibroCalificaciones
}
