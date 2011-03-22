using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoSIETE
{
    class Objeto
    {
        public
            void setNombre(string nombre);
            void setImagen(string imagen);

            string getNombre();
            string getImagen();
        private
            string nombre;
            string imagen;
    }
}
