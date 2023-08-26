using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class._2
{
    internal class ExerciseThree
    {
        public static void ExecuteExercise()
        {
          //7. Diseñar un algoritmo que genere un número aleatorio del 10 al 50, lo muestre y luego calcule y muestre el mismo número disminuido en un 15%.

        Random random = new Random();
        int numAleatorio = random.Next(10, 51);

        Console.WriteLine("El número aleatorio es: " + numAleatorio);
        double disminuido = numAleatorio * 0.85;
        Console.WriteLine("El número  "+numAleatorio+" menos el 15% es "+ disminuido.ToString("0.00"));
        }
    }
}
