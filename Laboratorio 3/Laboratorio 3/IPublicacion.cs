using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public interface IPublicacion
    {
        string autor { get; set; }
        string fechaPublicacion { get; set; }

        void revisar(string peticion);
        void leer(int pagina);
        void registrar(string autorIn, string fechaPublicacionIn, string presentacionIn);
    }
}
