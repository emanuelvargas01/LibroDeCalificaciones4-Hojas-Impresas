using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeCalificaciones4
{
    public class LibroCalificaciones1
    {
        private string nombreCurso; //nombre del curso que representa LibroCalificaciones
        //el constructor inicializa nombreCruso
        public LibroCalificaciones1(string nombre)
        {
            nombreCurso = nombre;//inicializa nombrecurso usando la propiedas
        }//fin del constructor
        //propiedad para obtener (get) y establecer (set) el nombre del curso
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            }//fin del get
            set
            {
                nombreCurso = value; //set deberia validad
            }// fin del set
        }
        //fin de la propiedad nombre curso 

        //muestra un mensaje de  bienvenida para el usuario del LibroCalificaciones
        public void MostrarMensaje()
        {
            // La propiedad NombreCurso obtiene el nombre del curso
            Console.WriteLine("Bienvenido al libro de calificaciones de \n{0}!\n", NombreCurso);
        }// fin del metodo MostrarMensaje

        //Determina el promedio de la clase con base en lqas 10 calificaciones introducidas por el usuario

        public void DeterminarPromedioClase()
        {
            int total; // suma de las calificaicones introducidas por el usuario
            int contadorCalif; // numero de las siguiente calificacion a introducir
            int calificacion; // valor de la calificacion introducida por el usuario
            double promedio; // promedio de las calificaciones

            // fase de inicialización
            total = 0; //inicializa el total
            contadorCalif = 0; // inicializa el contrador del ciclo}

            //fase de procesamiento 

            //mensaje para recibir como entrada la calificacion del usuario
            Console.Write("Escriba calificacion o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
            //itera hasta que se lee el valor centinela del usuario
            while( calificacion != -1)
            {
                total = total + calificacion; // suma califiacion a total
                contadorCalif = contadorCalif + 1; // incrementa el contador
                //mensaje para recribir como entrada la siguiente calificacion del usuario
                Console.Write("Escriba calificacion o -1 para salir: ");
                calificacion = Convert.ToInt32((Console.ReadLine()));
            }// fin del while
             //fase terminacion 
             // si el usuario introdujo cuando menosuna calificacion
            if (contadorCalif != 0)
            {
                //calcula el promedio de todas la calificaciones introducidas
                promedio = (double)total / contadorCalif;
                //muestra el total y el promedio (con dos digitos de precision)
                Console.WriteLine("\nEl total de las {0} calificaciones introducidas es {1}", contadorCalif, total);
                Console.WriteLine(" El promedio de la clase es {0:F2}", promedio);
            }// fin del if
            else // no se introdujeron calificaciones, entonces mostrar mensaje de error
                Console.WriteLine("No se introdujeron calificaciones");
        }// fin del metodo DeterminarPromedioClase










    }//fin de la clase LibroCalificaciones
}
