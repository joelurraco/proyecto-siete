using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENProyectoSIETE
{
    class ENEnemigo
    {
        private int idEnemigo;
        private string nombreEnemigo;
        private int ataqueEnemigo;
        private int vidaEnemigo;
        private int defensaEnemigo;
        private int puntosEnemigo;
        private string imagenEnemigo;

        public ENEnemigo(int id, string nombre, int ataque, int vida, int defensa, int puntos, string imagen = null)
        {
            idEnemigo = id;
            nombreEnemigo = nombre;
            ataqueEnemigo = ataque;
            vidaEnemigo = vida;
            defensaEnemigo = defensa;
            puntosEnemigo = puntos;
            imagenEnemigo = imagen;
        }
        public void setId(int id)
        {
            idEnemigo = id;
        }
        public int getId()
        {
            return idEnemigo;
        }
        public void setNombre(string nombre)
        {
            nombreEnemigo = nombre;
        }
        public void setAtaque(int ataque)
        {
            ataqueEnemigo = ataque;
        }
        public void setVida(int vida)
        {
            vidaEnemigo = vida;
        }
        public void setDefensa(int defensa)
        {
            defensaEnemigo = defensa;
        }
        public void setPuntos(int puntos)
        {
            puntosEnemigo = puntos;
        }
        public void setImagen(string imagen)
        {
            imagenEnemigo = imagen;
        }
    }
}
