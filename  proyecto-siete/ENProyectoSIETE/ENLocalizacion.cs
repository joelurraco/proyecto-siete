using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ENProyectoSIETE
{
    class ENLocalizacion
    {
        // declaraciones de las variables
        private int idLocalizacion;
        private string nombreLocalizacion;
        private string descripcionLocalizacion;
        private string imagenLocalizacion;
        private string fondoLocalizacion;
        private ArrayList objetos;
        private ArrayList enemigos;

        // Constructor sobrecargado
        public ENLocalizacion(int newId, string newName, string newDesc = "", string newImage = "", string newBG = "")
        {
            idLocalizacion = newId;
            nombreLocalizacion = newName;
            descripcionLocalizacion = newDesc;
            imagenLocalizacion = newImage;
            fondoLocalizacion = newBG;
        }

        public int IdLocalizacion
        {
            get { return (idLocalizacion); }
            set { idLocalizacion = value; }
        }

        public string NombreLocalizacion
        {
            get { return (nombreLocalizacion); }
            set { nombreLocalizacion = value; }
        }

        public string DescripcionLocalizacion
        {
            get { return (descripcionLocalizacion); }
            set { descripcionLocalizacion = value; }
        }

        public string ImagenLocalizacion
        {
            get { return (imagenLocalizacion); }
            set { imagenLocalizacion = value; }
        }

        public string FondoLocalizacion
        {
            get { return (fondoLocalizacion); }
            set { fondoLocalizacion = value; }
        }

        public ArrayList EnemigosLocalizacion
        {
            get { return (enemigos); }
            set { enemigos = value; }
        }
        
        public ArrayList ObjetosLocalizacion
        {
            get { return (objetos); }
            set { objetos = value; }
        }
    }
}
