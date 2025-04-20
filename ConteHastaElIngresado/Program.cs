using System;

namespace ConteHastaElIngresado
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numeroUser = 0;
            string verificacion;

            //blucle que solicita el numero mientras sea 0 o menos
            while (numeroUser <= 0)
            {
                try
                {
                    Console.WriteLine("Ingrese el numero al que desea llegar ");
                    numeroUser = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("¡Error! Ingrese un número valido.");
                }
                
                //variable y mtdo que verifica si es > 0
                verificacion = VerificacionPositivo(numeroUser);
                Console.WriteLine(verificacion);
                
                
            }
           
            //llamada el contador
            BucleContador(numeroUser);
            
            
            Console.WriteLine("\nPrograma Finalizado. Presiona una tecla para salir...");
            Console.ReadKey();
        }
        
        //mtdo que verifica si es mayor a cero
        static string VerificacionPositivo(int numeroUser)
        {
            return (numeroUser <= 0) ? "Asegurese que el numero sea positivo mayor a cero\n" : "\n";
        }
        
        //mtdo bucle que incrementa hasta el numero del usuario
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