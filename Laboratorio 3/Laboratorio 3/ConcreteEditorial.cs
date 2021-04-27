using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public class ConcreteEditorial: Editorial
    {
        public override IPublicacion getPublicacion(string Publicacion)
        {
            switch (Publicacion)
            {
                case "Revista":
                    return new Revista();

                case "Libro":
                    return new Libro();
                default:
                    throw new Exception(string.Format("Publicacion '{0}' no puede ser creada!!", Publicacion));
            }

        }
        
         
    }
}
