using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ENProyectoSIETE
{
    class ENMapa
    {
        // declaraciones de las variables
        private int idMapa;
        private string nombreMapa;
        private string descripcionMapa;
        private string imagenMapa;
        private ArrayList localizaciones;

        // Constructor sobrecargado
        public ENMapa(int newId, string newName, string newDesc = "", string newImage = "")
        {
            idMapa = newId;
            nombreMapa = newName;
            descripcionMapa = newDesc;
            imagenMapa = newImage;
        }

        public int IdMapa
        {
            get { return(idMapa); }
            set { idMapa = value; }
        }

        public string NombreMapa
        {
            get { return (nombreMapa); }
            set { nombreMapa = value; }
        }

        public string DescripcionMapa
        {
            get { return (descripcionMapa); }
            set { descripcionMapa = value; }
        }

        public string ImagenMapa
        {
            get { return (imagenMapa); }
            set { imagenMapa = value; }
        }

        public ArrayList LocalizacionesMapa
        {
            get { return (localizaciones); }
            set { localizaciones = value; }
        }
    }
}
