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
    public class D_LibroVentas
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


        public void InsertarLibroVentas(E_LibroVentas venta)
        {


            SqlCommand cmd = new SqlCommand("SP_INSERTARLIBROVENTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@FECHA", venta.Fechalibroventas);
            cmd.Parameters.AddWithValue("@TIPODOC", venta.Tipodoclibroventas);
            cmd.Parameters.AddWithValue("@NUMERO", venta.Numerolibroventas);
            cmd.Parameters.AddWithValue("@NETO", venta.Netolibroventas);
            cmd.Parameters.AddWithValue("@IVA", venta.Ivalibroventas);
            cmd.Parameters.AddWithValue("@TOTAL", venta.Totallibroventas);
            cmd.Parameters.AddWithValue("@METODOPAGO", venta.Metodopagolibroventas);
            cmd.Parameters.AddWithValue("@IDCLIENTE", venta.Idclientelibroventas);



            cmd.ExecuteNonQuery();
            conexion.Close();

            return;

        }

        public int obtenerNumLibroVentas()
        {

            SqlCommand cmd = new SqlCommand("SP_NUMEROVENTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Int32 id = -1;
            id = (int)cmd.ExecuteScalar();


            conexion.Close();

            return (int)id;


        }



        public List<E_LibroVentas> ListarVentas(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARLIBROVENTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_LibroVentas> Listar = new List<E_LibroVentas>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_LibroVentas
                {

                    Idlibroventas = LeerFilas.GetInt32(0),
                    Fechalibroventas = LeerFilas.GetDateTime(1),
                    Tipodoclibroventas = LeerFilas.GetString(2),
                    Numerolibroventas = LeerFilas.GetString(3),
                    Netolibroventas = LeerFilas.GetInt32(4),
                    Ivalibroventas = LeerFilas.GetInt32(5),
                    Totallibroventas = LeerFilas.GetInt32(6),
                    Metodopagolibroventas = LeerFilas.GetString(7),
                    Idclientelibroventas = LeerFilas.GetInt32(8)

                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }







    }
}
