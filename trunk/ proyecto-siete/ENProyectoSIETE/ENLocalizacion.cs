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
        private ArrayList ENObjeto;
        private ArrayList ENEnemigo;

        // Constructor sobrecargado
        public ENLocalizacion(int newId, string newName, string newDesc = "", string newImage = "", string newBG = "")
        {
            idLocalizacion = newId;
            nombreLocalizacion = newName;
            descripcionLocalizacion = newDesc;
            imagenLocalizacion = newImage;
            fondoLocalizacion = newBG;
        }
        // Sets
        public void setId(int newId)
        {
            idLocalizacion = newId;
        }
        public void setNombre(string newName)
        {
            nombreLocalizacion = newName;
        }
        public void setDescripcion(string newDesc)
        {
            descripcionLocalizacion = newDesc;
        }
        public void setImagen(string newImage)
        {
            imagenLocalizacion = newImage;
        }
        public void setFondo(string newBG)
        {
            fondoLocalizacion = newBG;
        }
        // Gets
        public int getId()
        {
            return(idLocalizacion);
        }
        public string getNombre()
        {
            return (nombreLocalizacion);
        }
        public string getDescripcion()
        {
            return(descripcionLocalizacion);
        }
        public string getImagen()
        {
            return(imagenLocalizacion);
        }
        public string getFondo()
        {
            return(fondoLocalizacion);
        }
    }
}
