using System.Data;
using System.Data.SQLite;

namespace ActivosFijos.Clases
{
    class ClsQueryPropietarios
    {
        readonly SQLiteConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT proId AS PptroId, proNombre AS NombreDelPropietario ";
            cadenaSql += "FROM Propietarios ";
            cadenaSql += "ORDER BY proNombre";
            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable Buscar(string nombre)
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT proId AS PptroId, proNombre AS NombreDelPropietario ";
            cadenaSql += "FROM Propietarios ";
            if (nombre != "")
            {
                cadenaSql += "WHERE proNombre LIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY proNombre";
            SQLiteCommand cmd = new SQLiteCommand(string.Format(cadenaSql, nombre), conexion);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public string SecuenciaId()
        {
            conexion.Open();
            string secId = null;
            SQLiteCommand cmd = new SQLiteCommand(string.Format("SELECT max(proId) FROM Propietarios"), conexion);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string proId, string proNombre)
        {
            conexion.Open();
            SQLiteCommand cmd = new SQLiteCommand(string.Format("INSERT INTO Propietarios VALUES('{0}', '{1}')", new string[] { proId, proNombre}), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string proId)
        {
            conexion.Open();
            string cadenaSql = "DELETE FROM Propietarios WHERE proId = " + proId;
            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string proId, string proNombre)
        {
            conexion.Open();
            string cadenaSql = "UPDATE Propietarios SET proNombre = '" + proNombre + "' WHERE proId = " + proId;
            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }
    }
}
