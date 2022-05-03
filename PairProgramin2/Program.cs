using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PairProgramin2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pila();
        }

        static void pila()
        {
            Stack<double> pilaDeNumero = new Stack<double>();

            bool flagEstaTodoBien = true;
            int cuantos = 0;
            Console.Write("Cuantos numeros quiere poner en esta pila? ");
             
            do
            {
                try
                {
                    cuantos = int.Parse(Console.ReadLine());
                    flagEstaTodoBien = true ;
                }
                catch
                {
                    Console.Write("Error al ingresar el numero, ingreselo nuevamente ");
                    flagEstaTodoBien = false ;
                }

            } while (flagEstaTodoBien == false);

            flagEstaTodoBien = true;

            for (int i = 0; i < cuantos; i++)
            {
                do
                {
                    try
                    {
                        Console.Write("ingrese un numero ");
                        pilaDeNumero.Push(double.Parse(Console.ReadLine()));
                        flagEstaTodoBien = true;
                    }
                    catch
                    {
                        Console.Write("lo ingresado es erroneo, ingrese otro numero ");
                        flagEstaTodoBien = false;
                    }
                } while (flagEstaTodoBien == false);
            }
            

            for (int i = 0; i < cuantos; i++)
            {
                Console.WriteLine(pilaDeNumero.Pop());
            }
            Console.ReadLine();
        }
    }
}
