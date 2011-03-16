using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoSIETE
{
    class Usuario
    {
        private
            void setNombre(string nombre);
            void setClave(string clave);
            void setIdPersonaje(int idPersonaje);
            void setCorreo(string correo);
            void setExperiencia(string experiencia);

            int getId();
            string getNombre();
            string getClave();
            int getIdPersonaje();
            string getCorreo();
            int getExperiencia();

        public
            int id;
            string nombre;
            string clave;
            int idPersonaje;
            string correo;
            int experiencia;
    }
}
