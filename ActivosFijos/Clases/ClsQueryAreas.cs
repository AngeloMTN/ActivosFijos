using System.Data;
using System.Data.SQLite;

namespace ActivosFijos.Clases
{
    class ClsQueryAreas
    {
        readonly SQLiteConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT areId AS AreaId, areNombre AS NombreDelArea ";
            cadenaSql += "FROM Areas ";
            cadenaSql += "ORDER BY areNombre";
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
            cadenaSql += "SELECT areId AS AreaId, areNombre AS NombreDelArea ";
            cadenaSql += "FROM Areas ";
            if (nombre != "")
            {
                cadenaSql += "WHERE areNombre LIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY areNombre";
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
            SQLiteCommand cmd = new SQLiteCommand(string.Format("SELECT max(areId) FROM Areas"), conexion);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string areId, string areNombre)
        {
            conexion.Open();
            SQLiteCommand cmd = new SQLiteCommand(string.Format("INSERT INTO Areas VALUES('{0}', '{1}')", new string[] { areId, areNombre}), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string nivId)
        {
            conexion.Open();
            string cadenaSql = "DELETE FROM Areas WHERE areId = " + nivId;
            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string areId, string areNombre)
        {
            conexion.Open();
            string cadenaSql = "UPDATE Areas SET areNombre = '" + areNombre + "' WHERE areId = " + areId;
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
