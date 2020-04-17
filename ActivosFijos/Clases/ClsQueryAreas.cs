using System.Data;
using Npgsql;

namespace ActivosFijos.Clases
{
    class ClsQueryAreas
    {
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT areId AS AreaId, areNombre AS NombreDelArea ";
            cadenaSql += "FROM Areas ";
            cadenaSql += "ORDER BY areNombre";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(cadenaSql, nombre), conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public string SecuenciaId()
        {
            conexion.Open();
            string secId = null;
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(areId) FROM Areas"), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("INSERT INTO Areas VALUES('{0}', '{1}')", new string[] { areId, areNombre}), conexion);
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
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
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
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }
    }
}
