using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeCalificaciones4
{
    public class LibroCalificaciones
    {
        private string nombreCurso; //nombre del curso que representa LibroCalificaciones
        //el constructor inicializa nombreCruso
        public LibroCalificaciones(string nombre)
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
            int promedio; // promedio de las calificaciones

            // fase de inicialización
            total = 0; //inicializa el total
            contadorCalif = 1; // inicializa el contrador del ciclo}

            //fase de procesamiento 

            while(contadorCalif<=10)//itera 10 veces
            {
                Console.Write("Escriba calificacion: ");
                calificacion = Convert.ToInt32(Console.ReadLine()); //lee calificacion
                total = total + calificacion;
                contadorCalif = contadorCalif + 1; //incrementa el contador en 1
            }// fin de while

            //fase terminacion 
            promedio = total / 10; // division entera produce resultado entero 

            //muestra el total y el promedio de las calificaciones
            Console.WriteLine("\nEl total de las 10 calificaciones es {0}", total);
            Console.WriteLine(" El promedo de la clase es {0}", promedio);

        }// fin del metodo DeterminarPromedioClase










    }//fin de la clase LibroCalificaciones
}
