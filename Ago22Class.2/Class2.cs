using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class._2
{
    internal class ExcerciseTwo
    {
        public static void ExecuteExercise()
        {
            //16. Diseñar un algoritmo para calcular el porcentaje de hombres y de
            //mujeres que hay en un grupo, dados los totales de hombres y de mujeres.

            Console.WriteLine("Ingrese el número de hombres en el grupo: ");
            int numHombres, numMujeres, totPersonas;
            numHombres = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el número de mujeres en el grupo: ");
            numMujeres = int.Parse(Console.ReadLine());

            totPersonas = numHombres + numMujeres;
            double porcHombres = (double)numHombres / totPersonas * 100;
            double porcMujeres = (double)numMujeres / totPersonas * 100;

            Console.WriteLine("El porcentaje de hombres es: " + porcHombres+"%");
            Console.WriteLine("El porcentaje de mujeres es: " + porcMujeres+"%");
        }
    }
}
