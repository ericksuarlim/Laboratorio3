﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public class Libro: IPublicacion
    {
        public string autor { get; set; }
        public string fechaPublicacion { get; set; }
        public string presentacion { get; set; }

        public void leer(int pagina)
        {
            Console.WriteLine("Presentacion: " + presentacion);
            Console.WriteLine("Leendo la: " + pagina.ToString() + "pag.");
        }

        public void revisar(string peticion)
        {

            if(peticion == "autor")
            {
                Console.WriteLine("Usted esta leyendo un libro de: " + autor);
            }
            else if(peticion == "fecha")
            {
                Console.WriteLine("La fecha de publicacion del libro es: " + fechaPublicacion);
            }
            else
            {
                Console.WriteLine("No existe la peticion", peticion);
            }
                     
        }

        public void registrar(string autorIn, string fechaPublicacionIn, string presentacionIn)
        {
            autor = autorIn;
            fechaPublicacion = fechaPublicacionIn;
            presentacion = presentacionIn;

        }
    }
}
