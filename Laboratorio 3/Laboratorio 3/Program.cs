using System;

namespace Laboratorio_3
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Editorial editorial = new ConcreteEditorial();

            Console.Write("SECCION LIBROS");
            Console.Write(" \n");
            IPublicacion libro = editorial.getPublicacion("Libro");
            libro.registrar("Pedro", "2000", "Este es un Libro!");
            libro.revisar("autor");

            Console.Write("\n");
            Console.Write("\n");

            Console.Write("SECCION REVISTA");
            Console.Write(" \n");
            IPublicacion revista = editorial.getPublicacion("Revista");
            revista.registrar("Marco", "2012", "Esta es una revista!");
            revista.leer(20);

            Console.ReadKey();
        }
    }
}
