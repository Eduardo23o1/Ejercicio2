using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            char sexo;
            double pulsacion = 0;
            Console.WriteLine("Djite edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dijite sexo M/F: ");
            sexo = Convert.ToChar(Console.ReadLine());
           
                if (sexo != 'm' && sexo != 'M' && sexo != 'f' && sexo != 'F')
                {
                    Console.WriteLine("Datos incorectos");
                }
            

            if(sexo.Equals('f') || sexo.Equals('F'))
            {
                 pulsacion = (220 - edad) / 10;

            }
            else
            {
                if (sexo.Equals('m') || sexo.Equals('M'))
                {
                     pulsacion = (210 - edad) / 10;

                }
            }
            Console.WriteLine("Las pulsaciones segun su genero es:");
            Console.WriteLine(pulsacion);
            Console.ReadKey();
        }
    }
}