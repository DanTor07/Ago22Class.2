using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class._2
{
    public class ExerciseOne
    {
        public static void ExecuteExercise()
        {
            //13. Diseñar un algoritmo que convierta y muestre la temperatura en Fahrenheit ingresando la temperatura en Celsius.

            Console.WriteLine("Ingrese la temperatura en grados Celsius");
            int tempCel, tempFar;
            tempCel = int.Parse(Console.ReadLine());
            tempFar = (tempCel * 9 / 5) + 32;
            Console.WriteLine(tempCel + " grados Celsius equivale a " + tempFar + " grados Fahrenheit de temperatura");

        }
    }
}
