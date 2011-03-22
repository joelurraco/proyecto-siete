using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoSIETE
{
    class Enemigo
    {
        public
            void setNombre(string nombre);
            void setAtaque(int ataque);
            void setVida(int vida);
            void setDefensa(int defensa);
            void setPuntos(int puntos);
            void setImagen(string imagen);

            string getNombre();
            int getAtaque();
            int getVida();
            int getDefensa();
            int getPuntos();
            string getImagen();

        private
            string nombre;
            int ataque;
            int vida;
            int defensa;
            int puntos;
            string imagen;
    }
}
