using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENProyectoSIETE
{
    public class ENObjetos
    {
        // declaraciones de las variables
        private int idObjeto;
        private string nombreObjeto;
        private string tipoObjeto;
        private int ataqueObjeto;
        private int defensaObjeto;
        private int curacionObjeto;
        private int precioObjeto;
        private string descripcionObjeto;
        private string imagenOBjeto;

        // get's y set's
        public ENObjetos(int newIdObjeto, string newNombreOjeto, string newTipoObjeto,
            int newAtaqueObjeto, int newDefensaObjeto, int newCuracionObjeto, int newPrecioObjeto,
            string newDescripcionObjeto="", string newImagenObjeto="") {

                idObjeto = newIdObjeto;
                nombreObjeto = newNombreOjeto;
                tipoObjeto = newTipoObjeto;
                ataqueObjeto = newAtaqueObjeto;
                defensaObjeto = newDefensaObjeto;
                curacionObjeto = newCuracionObjeto;
                precioObjeto = newPrecioObjeto;
                descripcionObjeto = newDescripcionObjeto;
                imagenOBjeto = newImagenObjeto;
        
        }

    }
}
