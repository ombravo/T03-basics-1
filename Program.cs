using System;

namespace T03_basics_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables numéricas
            float variable1 = 5;
            float variable2 = 7;
            float resultado = 0;

            //Mostrar resultados de operaciones
            Console.WriteLine("Variable 1 es {0}", variable1);
            Console.WriteLine("Variable 2 es {0}", variable2);
            Console.WriteLine("Resultado de operaciones con variable 1 y variable 2");


                resultado = variable1 + variable2;
                Console.WriteLine("La suma es {0}", resultado);

                resultado = variable1 - variable2;
                Console.WriteLine("La resta es {0}", resultado);

                resultado = variable1 * variable2;
                Console.WriteLine("La multiplicación es {0}", resultado);

                resultado = variable1 / variable2;
                Console.WriteLine("La división es {0}", resultado);

                resultado = variable1 % variable2;
                Console.WriteLine("El módulo es {0}", resultado);

        }
    }
}
