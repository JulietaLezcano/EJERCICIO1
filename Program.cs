using System;
using System.Collections.Generic;
using System.Text;
namespace Ejercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresar fecha I : dd/mm/yy");
            string FechaI= Console.ReadLine();
            Console.WriteLine("Ingresar fecha II: dd/mm/yy ");
            string FechaII= Console.ReadLine();
            DateTime fechaI= DateTime.Parse(FechaI);
            DateTime fechaII= DateTime.Parse(FechaII);
            
            TimeSpan diff= fechaII.Subtract(fechaI);
             Console.WriteLine("Dias de diferencia:" +" "+ diff);
             Console.WriteLine("Semanas de diferencia:" +" "+ diff/7);

            


            
        }
   }
}