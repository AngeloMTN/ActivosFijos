using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ActivosFijos.Clases
{
    class ClsQueryPrestamos
    {
        string cadenaSql;
        readonly NpgsqlConnection conexion = ClsObtenerConexion.Conexion();
        private DataSet ds;

        public class Prestamos
        {
            public int EmpId { get; set; }
            public string EmpNombre { get; set; }
        }

        public string ConsultaSql()
        {
            string cadenaSql = null;
            cadenaSql += "SELECT ";
            cadenaSql += "pre.\"preId\" AS PtmoId, ";
            cadenaSql += "pre.\"preCedula\" AS Cedula, ";
            cadenaSql += "emp.\"empNombre\" AS Nombre, ";
            cadenaSql += "pre.\"preFechaPrestamo\" AS FechaPrestamo, ";
            cadenaSql += "pre.\"preValorPrestamo\" AS ValorPrestamo, ";
            cadenaSql += "pre.\"preNumeroCuotas\" AS NroCuotas, ";
            cadenaSql += "pre.\"preValorCuota\" AS ValorCuota, ";
            cadenaSql += "pre.\"preFechaAbono\" AS FechaAbono, ";
            cadenaSql += "pre.\"preValorAbono\" AS ValorAbono, ";
            cadenaSql += "pre.\"preSaldoParcial\" AS SaldoParcial, ";
            cadenaSql += "pre.\"preObservaciones\" AS Observaciones ";
            cadenaSql += "FROM \"Prestamos\" AS pre ";
            cadenaSql += "INNER JOIN \"Empleados\" AS emp ON pre.\"preCedula\" = emp.\"empCedula\" ";
            return cadenaSql;
        }

        public string ConsultaSqlEmpleados()
        {
            string cadenaSql = null;
            cadenaSql += "SELECT ";
            cadenaSql += "\"Empleados\".\"empCedula\" AS Cedula, ";
            cadenaSql += "\"Empleados\".\"empNombre\" AS Nombre, ";
            cadenaSql += "\"Empleados\".\"empSaldoPrestamo\" AS SaldoPrestamo, ";
            cadenaSql += "\"Empleados\".\"empCuotasPorPagar\" AS CuotasPorPagar, ";
            cadenaSql += "\"Empleados\".\"empValorCuota\" AS ValorCuota ";
            cadenaSql += "FROM \"Empleados\" ";
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

        public DataTable MostrarDatosEmpleados()
        {
            conexion.Open();
            string cadenaSql = ConsultaSqlEmpleados();
            cadenaSql += "ORDER BY \"empNombre\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable Buscar(string cedula)
        {
            conexion.Open();
            string cadenaSql = ConsultaSql();
            if (cedula != "")
            {
                cadenaSql += "WHERE \"preCedula\" = '{0}' ";
            }
            cadenaSql += "ORDER BY \"empNombre\" ";
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format(cadenaSql, cedula), conexion);
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
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT max(\"preId\") FROM \"Prestamos\" "), conexion);
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

        public bool Insertar(string secId,
                             string preCedula,
                             DateTime preFechaPrestamo,
                             decimal preValorPrestamo,
                             decimal preNumeroCuotas,
                             decimal preValorCuota,
                             DateTime preFechaAbono,
                             decimal preValorAbono,
                             string preObservaciones,
                             string newsaldo)
        {
            conexion.Open();
            cadenaSql = null;
            cadenaSql += "INSERT INTO \"Prestamos\" (";
            cadenaSql += "\"preId\", ";
            cadenaSql += "\"preCedula\", ";
            cadenaSql += "\"preFechaPrestamo\", ";
            cadenaSql += "\"preValorPrestamo\", ";
            cadenaSql += "\"preNumeroCuotas\", ";
            cadenaSql += "\"preValorCuota\", ";
            cadenaSql += "\"preFechaAbono\", ";
            cadenaSql += "\"preValorAbono\", ";
            cadenaSql += "\"preSaldoParcial\", ";
            cadenaSql += "\"preObservaciones\" ";
            cadenaSql += ") ";
            cadenaSql += "VALUES('";
            cadenaSql += secId + "', '";
            cadenaSql += preCedula + "', '";
            cadenaSql += preFechaPrestamo.ToString() + "', '";
            cadenaSql += preValorPrestamo.ToString() + "', '";
            cadenaSql += preNumeroCuotas.ToString() + "', '";
            cadenaSql += preValorCuota.ToString() + "', '";
            cadenaSql += preFechaAbono.ToString() + "', '";
            cadenaSql += preValorAbono.ToString() + "', '";
            cadenaSql += newsaldo.ToString() + "', '";
            cadenaSql += preObservaciones + "' ";
            cadenaSql += ") ";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public bool ActualizarSaldo(string empCedula, string newsaldo, string valorcuota)
        {
            var reciduo = Convert.ToDecimal(newsaldo) % Convert.ToDecimal(valorcuota);
            var operacion = Math.Round(Convert.ToDecimal(newsaldo) / Convert.ToDecimal(valorcuota));

            conexion.Open();
            cadenaSql = null;
            cadenaSql += "UPDATE \"Empleados\" ";
            cadenaSql += "SET ";
            cadenaSql += "\"empSaldoPrestamo\" = '" + newsaldo + "', ";
            if (reciduo != 0)
                cadenaSql += "\"empCuotasPorPagar\" = '" + Math.Ceiling(operacion + 1).ToString() + "', ";
            else
                cadenaSql += "\"empCuotasPorPagar\" = '" + Math.Ceiling(operacion).ToString() + "', ";
            cadenaSql += "\"empValorCuota\" = '" + valorcuota + "'";
            cadenaSql += "WHERE \"empCedula\" = '" + empCedula + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(cadenaSql, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0)
                return true;
            else
                return false;
        }

        public void LimpiarCampos(Control ctr, GroupBox GbxPrestamo, GroupBox GbxAbono)
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

            foreach (var combo in GbxPrestamo.Controls)
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

            foreach (var combo in GbxAbono.Controls)
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
        }

        public static List<Prestamos> CargarComboBoxNombre()
        {
            List<Prestamos> lista = new List<Prestamos>();
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
                Prestamos pPrestamos = new Prestamos
                {
                    EmpId = Convert.ToInt32(dr[0]),
                    EmpNombre = Convert.ToString(dr[1])
                };
                lista.Add(pPrestamos);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 0;
            return lista;
        }

        public static List<Prestamos> CargarComboBoxFiltroNombre()
        {
            List<Prestamos> lista = new List<Prestamos>();
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
                Prestamos pPrestamos = new Prestamos
                {
                    EmpId = Convert.ToInt32(dr[0]),
                    EmpNombre = Convert.ToString(dr[1])
                };
                lista.Add(pPrestamos);
            }
            dr.Close();
            conexion.Close();
            //cb.SelectedIndex = 0;
            return lista;
        }

        public string RecuperarSaldo(string cedula)
        {
            conexion.Open();
            string saldo = null;
            string valorcuota = null;
            NpgsqlCommand cmd = new NpgsqlCommand(string.Format("SELECT \"empSaldoPrestamo\", \"empValorCuota\" FROM \"Empleados\" WHERE \"empCedula\" = '" + cedula + "'"), conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                saldo = dr[0].ToString();
                valorcuota = dr[1].ToString();
            }
            if (saldo == "")
                saldo = "0";

            dr.Close();
            conexion.Close();
            return saldo+"|"+valorcuota;
        }
    }
}
