using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_Indice
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public int obtenerNumeroBoleta()
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARINDICEBOLETA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Int32 id = -1;
            id = (int)cmd.ExecuteScalar();


            conexion.Close();

            return (int)id;

        }


        public int obtenerNumeroFactura()
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARINDICEFACTURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Int32 id = -1;
            id = (int)cmd.ExecuteScalar();


            conexion.Close();

            return (int)id;

        }



    }
}
