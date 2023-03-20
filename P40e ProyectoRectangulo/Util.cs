using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40e_ProyectoRectangulo
{
    class Util
    {
        public static bool PreguntaSiNo()
        {
            char respuesta;

            do
            {
                Console.Write("\n\t¿Quieres Modificar?: ");
                respuesta = Console.ReadKey(true).KeyChar;

                if (respuesta=='s' ||respuesta =='S')
                    return true;
                else if(respuesta =='N' || respuesta=='n')
                    return false;
                else
                    Console.WriteLine("** Error, no ha introducido S o N **");

            } while (true);
        }
        public static int CapturaEntero(string texto,int min, int max) 
        {
            int num;
            bool numOk;

            do
            {
                Console.Write("\n\t{0} [{1}..{2}]:",texto,min,max);
                numOk = int.TryParse(Console.ReadLine(),out num);

                if (!numOk)
                    Console.WriteLine("\n\t** Error, no ha introducido un número entero");
                else if (num>max || num < min) 
                {
                    Console.WriteLine("\n\t** Error, el número introducido está fuera del rango posible **");
                    numOk = false;
                }

            } while (!numOk);

            return num;

        }
        public static string CuadraTexto(string texto, int numCaracteres)
        {
            if(texto.Length>numCaracteres)
                return texto.Substring(0,numCaracteres);

            while (texto.Length < numCaracteres)
                texto += " ";

            return texto;
        }
    }
}
