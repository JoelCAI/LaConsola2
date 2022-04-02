using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola2
{
    public class Sistema
    {
        public void Saludo()
        {
            string mensaje;

            mensaje = Validador.ValidarStringNoVacio("\nIngrese cualquier texto");

            Validador.ImpresionFinal(mensaje);
           
        }

        public void Iniciar()
        {
            Saludo();
        }


    }
}
