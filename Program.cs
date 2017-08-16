using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int numeroUno;
            int numeroDos;*/
            int resultado;
            string dato;
            bool esNumero;
            int numero[5];

            /*do{
                Console.Write("Ingrese un numero para numeroUno: ");
                dato = Console.ReadLine();
                esNumero = int.TryParse(dato, out numeroUno);
            } while (!int.TryParse(dato, out numeroUno));

            do
            {
                Console.Write("Ingrese un numero para numeroDos: ");
                dato = Console.ReadLine();
                esNumero = int.TryParse(dato, out numeroDos);
            } while (!int.TryParse(dato, out numeroDos));*/

            for(int i=0; i<5;i++){
                do
                {
                    Console.Write("Ingrese un numero para numero[{0}]: ", i);
                    dato = Console.ReadLine();
                    esNumero = int.TryParse(dato, out numero[i]);
                } while (!int.TryParse(dato, out numero[i]));
            }


            resultado = numeroUno + numeroDos;

            Console.Write("\nEl numero es: {0}", resultado);

            //Console.Write("Hola mundo");
            Console.ReadLine();
        }
    }
}
