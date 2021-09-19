using System;

namespace conditionals
{
    class ConditionalsHomework
    {
        static void Main(string[] args)
        {
            int numA;
            int numB;
            int numC;
            Console.WriteLine("Escribe el primer número: ");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número: ");
            numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el tercer número: ");
            numC = Convert.ToInt32(Console.ReadLine());

            int opcion;
            Console.WriteLine("Escoja una opción: ");
            Console.WriteLine("1. Validar Suma");
            Console.WriteLine("2. Salir");
            int sumOne = numA + numB;
            int sumTwo = numB + numC;
            int sumThree = numA + numC; 
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    if (sumOne == numC)
                    {
                        Console.WriteLine("Son iguales.");
                    } else if (sumTwo == numA)
                    {
                        Console.WriteLine("Son iguales.");
                    } else if (sumThree == numB)
                    {
                        Console.WriteLine("Son iguales.");
                    } else
                    {
                        Console.WriteLine("Son diferentes.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Adiós");
                    break;

                
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        Console.ReadLine();

        }
    }
}
