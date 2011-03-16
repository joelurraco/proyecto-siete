using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoSIETE
{
    class Personaje
    {
        public
            void setTipo(string tipo);
            void setAtaque(int ataque);
            void setVida(int vida);
            void setDefensa(int defensa);

            string getTipo();
            int getAtaque();
            int getVida();
            int getDefensa();
        private
        	string tipo;
	        int ataque;
	        int vida;
            int defensa;

    }
}
