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
    public class D_Kardex
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void InsertarKardex(E_kardex kardex)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARKARDEX", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODIGO", kardex.Codigokardex);
            cmd.Parameters.AddWithValue("@FECHA", kardex.FechaKardex);
            cmd.Parameters.AddWithValue("@TIPODOC", kardex.Tipodockardex);
            cmd.Parameters.AddWithValue("@NUMERO", kardex.Numerokardex);
            cmd.Parameters.AddWithValue("@COMPRA", kardex.Comprakarex);
            cmd.Parameters.AddWithValue("@VENTA", kardex.Ventakardex);
            cmd.Parameters.AddWithValue("@PRECIO", kardex.PrecioKardex);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }




        public List<E_kardex> ListarKardex(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARKARDEX", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_kardex> Listar = new List<E_kardex>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_kardex
                {
                    Idkardex = LeerFilas.GetInt32(0),
                    Codigokardex = LeerFilas.GetString(1),
                    FechaKardex = LeerFilas.GetDateTime(2),
                    Tipodockardex = LeerFilas.GetString(3),
                    Numerokardex = LeerFilas.GetString(4),
                    Comprakarex = LeerFilas.GetInt32(5),
                    Ventakardex = LeerFilas.GetInt32(6),
                    PrecioKardex = LeerFilas.GetInt32(7)

      
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }






    }
    }
