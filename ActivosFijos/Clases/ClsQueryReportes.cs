using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace ActivosFijos.Clases
{
    class ClsQueryReportes
    {
        readonly SQLiteConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable CargarRpvActivos()
        {
            conexion.Open();
            string cadenaSql = null;
            //cadenaSql += "SELECT * FROM Activos";
            cadenaSql += "SELECT Activos.actId, Activos.actArchivo, Activos.actArea, Areas.areNombre, ";
            cadenaSql += "Activos.actNombre, Activos.actObservaciones, Activos.actValorBase0, ";
            cadenaSql += "Activos.actValorBaseIva, Activos.actPctjeIva, Activos.actValorIva, ";
            cadenaSql += "Activos.actValorTotal, actFechaCompra, Activos.actPropietario, ";
            cadenaSql += "Propietarios.proNombre ";
            cadenaSql += "FROM Activos ";
            cadenaSql += "INNER JOIN Areas ON Activos.actArea = Areas.areId ";
            cadenaSql += "INNER JOIN Propietarios ON Activos.actPropietario = Propietarios.proId ";
            cadenaSql += "ORDER BY Activos.actNombre";

            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
    }
}
