using System.Data;
using Npgsql;

namespace ActivosFijos.Clases
{
    class ClsQueryPlanCuentas
    {
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"pctId\" AS CtaId, \"pctCuenta\" AS Cuenta, \"pctNombre\" AS NombreDeLaCuenta ";
            cadenaSql += "FROM \"PlanCuentas\" ";
            cadenaSql += "ORDER BY \"pctNombre\" ";
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
            cadenaSql += "SELECT \"pctId\" AS CtaId, \"pctCuenta\" AS Cuenta, \"pctNombre\" AS NombreDeLaCuenta ";
            cadenaSql += "FROM \"PlanCuentas\" ";
            if (nombre != "")
            {
                cadenaSql += "WHERE \"pctNombre\" ILIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY \"pctNombre\" ";
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(\"pctId\") FROM \"PlanCuentas\" "), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string pctId, string pctCuenta, string pctNombre)
        {
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("INSERT INTO \"PlanCuentas\" VALUES('{0}', '{1}', '{2}')", new string[] { pctId, pctCuenta, pctNombre}), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Eliminar(string pctId)
        {
            conexion.Open();
            string cadenaSql = "DELETE FROM \"PlanCuentas\" WHERE \"pctId\" = " + pctId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string pctId, string pctCuenta, string pctNombre)
        {
            conexion.Open();
            string cadenaSql = "UPDATE \"PlanCuentas\" SET \"pctCuenta\" = '" + pctCuenta + "', \"pctNombre\" = '" + pctNombre + "' WHERE \"pctId\" = " + pctId;
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
