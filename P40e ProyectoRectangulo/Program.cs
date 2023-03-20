//Alumno: Nicolás Álvarez Zapata
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40e_ProyectoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo("Rectan-1",10,20);

            bool continuar = false;

            do
            {          
                Console.Clear();
                Console.WriteLine("\n\tNombre    \tBase  \tLateral \tPerím.\tArea");
                Console.WriteLine(" \t----------\t----  \t------- \t------\t------");
                Console.WriteLine(r1.RectanguloAString());

                continuar = Util.PreguntaSiNo();

                if(continuar)                
                    r1 = modificarRectangulo();
                
            } while (continuar) ;

            Console.WriteLine("\n\tPulse una tecla para salir...");
            Console.ReadKey();
        }

        static Rectangulo modificarRectangulo()
        {
            Console.Write("\n\tIntroduce el nuevo nombre del rectángulo: ");
            string nuevoNombre = Console.ReadLine();

            
            while (nuevoNombre == String.Empty)
            {
                if (nuevoNombre == String.Empty)
                    Console.WriteLine("** Error, el nombre del rectángulo no puede estar en blanco. **");

                Console.Write("\n\tIntroduce el nuevo nombre del rectángulo: ");
                nuevoNombre = Console.ReadLine();
            }

            while (nuevoNombre.Length > 8)
            {
                if (nuevoNombre.Length > 8)
                    Console.WriteLine("** Error, el nombre del rectángulo no puede tener mas de 8 caracteres. **");

                Console.Write("\n\tIntroduce el nuevo nombre del rectángulo: ");
                nuevoNombre = Console.ReadLine();
            }

            int nuevoLadoBase, nuevoLadoLateral;

            nuevoLadoBase = Util.CapturaEntero("Introduce la nueva longitud del lado base", 1, 100);
            nuevoLadoLateral = Util.CapturaEntero("Introduce la nueva longitud del lado lateral", 1, 100);

            return new Rectangulo(nuevoNombre, nuevoLadoBase, nuevoLadoLateral); ;
        }
    }
}
