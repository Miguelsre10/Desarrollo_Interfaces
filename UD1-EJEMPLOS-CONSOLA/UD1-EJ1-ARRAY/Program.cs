using System;

namespace UD1_EJ1_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            String[] people = new string[3];
            int cont = 0;

            //Pedimos al usario dots de entrada
            while (cont < people.Length)
            {
                //Console.WriteLine("Introduce el nombre de la persona nuemero" + (cont+1));
                Console.WriteLine($"Introduce el nombre de la persona numero {cont+1}");
                people[cont] = Console.ReadLine();
                cont++;
            }
            //mostramos los datos introducidos
            foreach (string i in people)
            {
                Console.WriteLine(i);
            }
        }
    }
}
