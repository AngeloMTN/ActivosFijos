using ActivosFijos.Properties;
using Npgsql;
using System.Windows.Forms;

namespace ActivosFijos.Clases
{
    class ClsObtenerConexion
    {
        public static string obtenerCadenaConexion = Settings.Default.ActivosFijosConnectionString;

        public static NpgsqlConnection Conexion()
        {
            NpgsqlConnection conexion = new NpgsqlConnection(obtenerCadenaConexion);
            return conexion;
        }

        public static void ValidarCaracteres(KeyPressEventArgs e)
        {
            //Valida que no se pueda ingresar (,)(;)(')(") etc.

            //if ((e.KeyChar >= 0 & e.KeyChar <= 7) || (e.KeyChar >= 9 & e.KeyChar <= 16) || (e.KeyChar >= 21 & e.KeyChar <= 31) ||
            if ((e.KeyChar >= 33 & e.KeyChar <= 39) || (e.KeyChar >= 94 & e.KeyChar <= 96) ||
                (e.KeyChar >= 58 & e.KeyChar <= 59) || e.KeyChar == 44 || e.KeyChar == 46 ||
                e.KeyChar == 64)
            {
                e.Handled = true;
                return;
            }
        }

        public static void ValidarNumeros(KeyPressEventArgs e)
        {
            //Valida que solo se pueda ingresar numeros
            if ((e.KeyChar >= 0 & e.KeyChar <= 7) || (e.KeyChar >= 9 & e.KeyChar <= 45) || (e.KeyChar >= 58 & e.KeyChar <= 255) || e.KeyChar == 47)
            {
                e.Handled = true;
                return;
            }
        }

    }
}
