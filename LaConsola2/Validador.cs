using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola2
{
    public class Validador
    {
        public static string ValidarStringNoVacio(string mensaje)
        {

            string opcion;
            bool valido = false;
            string mensajeValidador = "\n Puede ser combinación de minúsculas, MAYÚSCULAS, caracteres y números";
            string mensajeError = "\n Por favor ingrese un valor no vacio para que pueda continuar. ";

            do
            {

                Console.WriteLine(mensaje);
                Console.WriteLine(mensajeValidador);

                opcion = Console.ReadLine();

                if (opcion == "")
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(mensajeError);
                }
                else
                {
                    valido = true;
                }

            } while (!valido);

            return opcion;
        }

        public static void ImpresionFinal(string mensaje)
        {
            
            Console.Clear();
            Console.WriteLine("\n\n Su texto ingresado es " + "*" + mensaje + "*");
            Console.WriteLine("\n\n Ingrese cualquier tecla para Finalizar");
            
        }

    }
}
