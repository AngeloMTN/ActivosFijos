using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ActivosFijos.Clases
{
    class ClsQueryVacaciones
    {
        string cadenaSql;
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public class Empleados
        {
            public int EmpId { get; set; }
            public string EmpNombre { get; set; }
        }

        public string ConsultaSql()
        {
            string cadenaSql = null;
            cadenaSql += "SELECT \"empId\" AS EmpId, \"empCedula\" AS Cedula, \"empNombre\" AS Nombre, ";
            cadenaSql += "\"empFechaEntrada\" AS Entrada, \"empAniosAntiguedad\" AS Antiguedad, ";
            cadenaSql += "\"empDiasPorAnio\" AS DiasPorAnio,\"empDiasAcumulado\" AS Acumulado, ";
            cadenaSql += "\"empDiasUtilizado\" AS Utilizado, \"empDiasPendiente\" AS DiasPendiente ";
            cadenaSql += "FROM \"Empleados\" ";
            return cadenaSql;
        }

        public string ConsultaSqlVacaciones()
        {
            string cadenaSql = null;
            cadenaSql += "SELECT ";
            cadenaSql += "\"Vacaciones\".\"vacId\" AS RegId, ";
            cadenaSql += "\"Vacaciones\".\"vacCedula\" AS Cedula, ";
            cadenaSql += "\"Empleados\".\"empNombre\" AS Nombre, ";
            cadenaSql += "\"Empleados\".\"empFechaEntrada\" AS FechaEntrada, ";
            cadenaSql += "\"Vacaciones\".\"vacFechaSalida\" AS Salida, ";
            cadenaSql += "\"Vacaciones\".\"vacFechaRetorno\" AS Retorno, ";
            cadenaSql += "\"Vacaciones\".\"vacDiasTomados\" AS DiasTomados, ";
            cadenaSql += "\"Vacaciones\".\"vacObservaciones\" AS Observaciones, ";
            cadenaSql += "\"Vacaciones\".\"vacAniosAntiguedad\" AS Antiguedad, ";
            cadenaSql += "\"Vacaciones\".\"vacDiasPorAnio\" AS DiasPorAnio, ";
            cadenaSql += "\"Vacaciones\".\"vacDiasPendiente\" AS DiasPendiente ";
            cadenaSql += "FROM \"Vacaciones\" ";
            cadenaSql += "INNER JOIN \"Empleados\" ON \"Vacaciones\".\"vacCedula\" = \"Empleados\".\"empCedula\" ";

            return cadenaSql;
        }

        public DataTable MostrarDatos()
        {
            conexion.Open();
            string cadenaSql = ConsultaSql();
            cadenaSql += "ORDER BY \"empNombre\" ";
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
            string cadenaSql = ConsultaSql();
            if (nombre != "")
            {
                cadenaSql += "WHERE \"empNombre\" ILIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY \"empNombre\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(cadenaSql, nombre), conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarVacaciones(string cedula)
        {
            conexion.Open();
            string cadenaSql = ConsultaSqlVacaciones();
            if (cedula != "")
            {
                cadenaSql += "WHERE \"vacCedula\" ILIKE '%{0}%' ";
            }
            cadenaSql += "ORDER BY \"vacFechaSalida\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(cadenaSql, cedula), conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable MostrarDatosVacaciones()
        {
            conexion.Open();
            string cadenaSql = ConsultaSqlVacaciones();
            cadenaSql += "ORDER BY \"vacCedula\", \"vacFechaSalida\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(\"empId\") FROM \"Empleados\" "), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            if (secId=="")
                secId = "0";

            dr.Close();
            conexion.Close();
            return secId;
        }

        public string SecuenciaIdVacaciones()
        {
            conexion.Open();
            string secId = null;
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(\"vacId\") FROM \"Vacaciones\" "), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                secId = dr[0].ToString();
            }
            if (secId == "")
                secId = "0";

            dr.Close();
            conexion.Close();
            return secId;
        }

        public bool Insertar(string secId, string empCedula, string empNombre, DateTime empFechaEntrada)
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "INSERT INTO \"Empleados\" (";
            cadenaSql += "\"empId\", ";
            cadenaSql += "\"empCedula\", ";
            cadenaSql += "\"empNombre\", ";
            cadenaSql += "\"empFechaEntrada\" ";
            cadenaSql += ") ";
            cadenaSql += "VALUES('";
            cadenaSql += secId + "', '";
            cadenaSql += empCedula + "', '";
            cadenaSql += empNombre + "', '";
            cadenaSql += empFechaEntrada.ToString() + "')";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
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
            string cadenaSql = "DELETE FROM \"Empleados\" WHERE \"empId\" = " + empId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool Actualizar(string empId, string empCedula, string empNombre, DateTime empFechaEntrada)
        {
            conexion.Open();
            string cadenaSql = "UPDATE \"Empleados\" SET \"empCedula\" = '" + empCedula + "', \"empNombre\" = '" + empNombre + "', \"empFechaEntrada\" = '" + empFechaEntrada + "' WHERE \"empId\" = " + empId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public void LimpiarCampos(Control ctr, GroupBox gb2, GroupBox gb4, GroupBox gb5)
        {
            foreach (var txt in ctr.Controls)
            {
                switch (txt)
                {
                    case TextBox _:
                        ((TextBox)txt).Clear();
                        break;
                    case ComboBox _:
                        ((ComboBox)txt).SelectedIndex = 0;
                        break;
                }
            }

            foreach (var combo in gb2.Controls)
            {
                switch (combo)
                {
                    case TextBox _:
                        ((TextBox)combo).Clear();
                        break;
                    case ComboBox _:
                        ((ComboBox)combo).SelectedIndex = 0;
                        break;
                }
            }

            foreach (var combo in gb4.Controls)
            {
                switch (combo)
                {
                    case TextBox _:
                        ((TextBox)combo).Clear();
                        break;
                    //case ComboBox _:
                    //    ((ComboBox)combo).SelectedIndex = 0;
                    //    break;
                }
            }

            foreach (var combo in gb5.Controls)
            {
                switch (combo)
                {
                    case TextBox _:
                        ((TextBox)combo).Clear();
                        break;
                    //case ComboBox _:
                    //    ((ComboBox)combo).SelectedIndex = 0;
                    //    break;
                }
            }

        }

        public static List<Empleados> CargarComboBoxRegistroNombre()
        {
            List<Empleados> lista = new List<Empleados>();
            NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"empId\", \"empCedula\"||' - '||\"empNombre\" AS NombreDelEmpleado ";
            cadenaSql += "FROM \"Empleados\" ";
            cadenaSql += "ORDER BY substr(\"empNombre\", POSITION(' - ' IN \"empNombre\"))";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Empleados pEmpleados = new Empleados
                {
                    EmpId = Convert.ToInt32(dr[0]),
                    EmpNombre = Convert.ToString(dr[1])
                };
                lista.Add(pEmpleados);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 0;
            return lista;
        }

        public static List<Empleados> CargarComboBoxFiltroRegistroNombre()
        {
            List<Empleados> lista = new List<Empleados>();
            NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
            conexion.Open();
            string cadenaSql = null;
            cadenaSql += "SELECT \"empId\", \"empCedula\"||' - '||\"empNombre\" AS NombreDelEmpleado ";
            cadenaSql += "FROM \"Empleados\" ";
            cadenaSql += "ORDER BY substr(\"empNombre\", POSITION(' - ' IN \"empNombre\"))";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Empleados pEmpleados = new Empleados
                {
                    EmpId = Convert.ToInt32(dr[0]),
                    EmpNombre = Convert.ToString(dr[1])
                };
                lista.Add(pEmpleados);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 0;
            return lista;
        }

        public bool InsertarVacaciones(string secId,
                                       string vacCedula,
                                       DateTime vacFechaSalida,
                                       DateTime vacFechaRetorno,
                                       string vacDiasTomados,
                                       string vacObservaciones,
                                       string vacAniosAntiguedad,
                                       string vacDiasPorAnio,
                                       string vacDiasPendiente)
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "INSERT INTO \"RegistroVacaciones\" (";
            cadenaSql += "\"vacId\", ";
            cadenaSql += "\"vacCedula\", ";
            cadenaSql += "\"vacFechaSalida\", ";
            cadenaSql += "\"vacFechaRetorno\", ";
            cadenaSql += "\"vacDiasTomados\", ";
            cadenaSql += "\"vacObservaciones\", ";
            cadenaSql += "\"vacAniosAntiguedad\", ";
            cadenaSql += "\"vacDiasPorAnio\", ";
            cadenaSql += "\"vacDiasPendiente\", ";
            cadenaSql += "\"vacFechaProceso\" ";
            cadenaSql += ") ";
            cadenaSql += "VALUES('";
            cadenaSql += secId + "', '";
            cadenaSql += vacCedula + "', '";
            cadenaSql += vacFechaSalida.ToString() + "', '";
            cadenaSql += vacFechaRetorno.ToString() + "', '";
            cadenaSql += vacDiasTomados + "', '";
            cadenaSql += vacObservaciones + "', '";
            cadenaSql += vacAniosAntiguedad + "', '";
            cadenaSql += vacDiasPorAnio + "', '";
            cadenaSql += vacDiasPendiente + "', '";
            cadenaSql += DateTime.Today + "'";
            cadenaSql += ") ";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool EliminarVacaciones(string vacId)
        {
            conexion.Open();
            string cadenaSql = "DELETE FROM \"Vacaciones\" WHERE \"vacId\" = " + vacId;
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public void RecalcularVacaciones()
        {

            conexion.Open();
            cadenaSql = null;
            cadenaSql += "UPDATE \"Empleados\" SET \"empAniosAntiguedad\" = ";
            cadenaSql += "CONCAT(";
            cadenaSql += "       EXTRACT(YEAR FROM age(timestamp 'now()', date(\"empFechaEntrada\"))), '|',";
            cadenaSql += "       EXTRACT(MONTH FROM age(timestamp 'now()', date(\"empFechaEntrada\"))), '|',";
            cadenaSql += "       EXTRACT(DAY FROM age(timestamp 'now()', date(\"empFechaEntrada\")))";
            cadenaSql += "      ); ";
            cadenaSql += " ";
            cadenaSql += "UPDATE \"Empleados\" SET ";
            cadenaSql += "  \"empDiasPorAnio\" = subquery.\"parDiasPorAnio\", ";
            cadenaSql += "  \"empDiasAcumulado\" = subquery.\"parTotalDias\" ";
            cadenaSql += "FROM(SELECT pv.\"parAnios\", pv.\"parDiasPorAnio\", \"parTotalDias\" ";
            cadenaSql += "      FROM \"Empleados\" AS em ";
            cadenaSql += "      INNER JOIN \"ParametrosVacaciones\" AS pv ON ";
            cadenaSql += "      CAST(SUBSTRING(em.\"empAniosAntiguedad\" FROM 1 FOR POSITION('|' IN em.\"empAniosAntiguedad\") - 1) AS integer) = ";
            cadenaSql += "      pv.\"parAnios\") AS subquery ";
            cadenaSql += "WHERE cast(substring(\"Empleados\".\"empAniosAntiguedad\" FROM 1 FOR POSITION('|' IN \"Empleados\".\"empAniosAntiguedad\") - 1) AS integer) = ";
            cadenaSql += "      subquery.\"parAnios\"; ";
            cadenaSql += " ";
            cadenaSql += "UPDATE \"Empleados\" SET \"empDiasUtilizado\" = subquery.DiasTomados ";
            cadenaSql += "FROM(SELECT va.\"vacCedula\", SUM (va.\"vacDiasTomados\") AS DiasTomados";
            cadenaSql += "      FROM \"Vacaciones\" AS va";
            cadenaSql += "      INNER JOIN \"Empleados\" AS em ON va.\"vacCedula\" = em.\"empCedula\" ";
            cadenaSql += "      GROUP BY va.\"vacCedula\" ) AS subquery ";
            cadenaSql += "WHERE \"Empleados\".\"empCedula\" = subquery.\"vacCedula\" ;";
            cadenaSql += " ";
            cadenaSql += "UPDATE \"Empleados\" SET \"empDiasPendiente\" = \"empDiasAcumulado\" - \"empDiasUtilizado\"; ";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            _ = cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
