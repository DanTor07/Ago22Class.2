namespace Ago22Class._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija la opción del ejercicio");
            string opcion;
            opcion = Console.ReadLine();
            Console.WriteLine("La opcion elegida es " + opcion);
            switch (opcion)
            {
                case "1":
                    ExerciseOne.ExecuteExercise();
                    break;
                case "2":
                    ExcerciseTwo.ExecuteExercise();
                    break;
                case "3":
                    ExerciseThree.ExecuteExercise();
                    break;
            }
        }
    }
}