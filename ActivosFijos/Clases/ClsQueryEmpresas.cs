using System.Data;
using System.Data.SQLite;

namespace ActivosFijos.Clases
{
    class ClsQueryEmpresas
    {
        readonly SQLiteConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT empId AS Id, empNombre AS NombreDeLaEmpresa ";
            cadenaSql += "FROM Empresas ";
            cadenaSql += "ORDER BY empNombre";
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
            cadenaSql += "SELECT empId AS Id, empNombre AS NombreDeLaEmpresa ";
            cadenaSql += "FROM Empresas ";
            if (nombre != "")
            {
                cadenaSql += "WHERE empNombre LIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY empNombre";
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
            SQLiteCommand cmd = new SQLiteCommand(string.Format("SELECT max(empId) FROM Empresas"), conexion);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string empId, string empNombre)
        {
            conexion.Open();
            SQLiteCommand cmd = new SQLiteCommand(string.Format("INSERT INTO Empresas VALUES('{0}', '{1}')", new string[] { empId, empNombre}), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string empId)
        {
            conexion.Open();
            string cadenaSql = "DELETE FROM Empresas WHERE empId = " + empId;
            SQLiteCommand cmd = new SQLiteCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string empId, string empNombre)
        {
            conexion.Open();
            string cadenaSql = "UPDATE Empresas SET empNombre = '" + empNombre + "' WHERE empId = " + empId;
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
