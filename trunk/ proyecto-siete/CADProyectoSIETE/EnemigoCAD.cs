using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENProyectoSIETE;
using CADProyectoSIETE.Properties;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CADProyectoSIETE
{
    public class EnemigoCAD
    {
        private string conexion;

        public void insertarEnemigo(ENEnemigo enemigo)
        {
            string cadenaConexion = Settings.Default.BDProyecto7ConnectionString;
            SqlConnection con = new SqlConnection(cadenaConexion);
        }

    }
}
