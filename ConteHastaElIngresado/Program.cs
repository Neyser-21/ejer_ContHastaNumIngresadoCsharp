using System;

namespace ConteHastaElIngresado
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numeroUser;
           
            
            Console.WriteLine("Ingres el numero al que desea llegar ");
            numeroUser = int.Parse(Console.ReadLine());


            BucleContador(numeroUser);
        }

        private static void BucleContador(int numeroUser)
        {
            int contador = 1;
            while (contador <= numeroUser)
            {
                Console.WriteLine("El número es: {0}", contador);
                contador++;

            }
            
        }
    }
}