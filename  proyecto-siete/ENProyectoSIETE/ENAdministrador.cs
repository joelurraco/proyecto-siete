using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENProyectoSIETE
{
    class ENAdministrador
    {
        private int idAdministrador;
        private string nombreAdministrador;
        private string claveAdministrador;

        public ENAdministrador(int id, string nombre, string clave)
        {
            idAdministrador = id;
            nombreAdministrador = nombre;
            claveAdministrador = clave;
        }
        public int IdAdministrador
        {
            get { return idAdministrador; }
            set { idAdministrador = value; }
        }
        public string NombreAdministrador
        {
            get { return nombreAdministrador; }
            set { nombreAdministrador = value; }
        }
        public string ClaveAdministrador
        {
            get { return claveAdministrador; }
            set { claveAdministrador = value; }
        }
    }
}

