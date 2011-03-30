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
        private ArrayList ENLocalizacion;

        // Constructor sobrecargado
        public ENMapa(int newId, string newName, string newDesc = "", string newImage = "")
        {
            idMapa = newId;
            nombreMapa = newName;
            descripcionMapa = newDesc;
            imagenMapa = newImage;
        }
        // Sets
        public void setId(int newId)
        {
            idMapa = newId;
        }
        public void setNombre(string newName)
        {
            nombreMapa = newName;
        }
        public void setDescripcion(string newDesc)
        {
            descripcionMapa = newDesc;
        }
        public void setImagen(string newImage)
        {
            imagenMapa = newImage;
        }
        // Gets
        public int getId()
        {
            return (idMapa);
        }
        public string getNombre()
        {
            return (nombreMapa);
        }
        public string getDescripcion()
        {
            return(descripcionMapa);
        }
        public string getImagen()
        {
            return (imagenMapa);
        }
    }
}
