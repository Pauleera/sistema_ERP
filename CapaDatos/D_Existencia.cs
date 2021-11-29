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
   public class D_Existencia
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);




        public List<E_Existencia> ListarExistencia(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Existencia> Listar = new List<E_Existencia>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Existencia
                {
                    Idexistencias = LeerFilas.GetInt32(0),
                    Codigoexistencias = LeerFilas.GetString(1),
                    Nombreexistencias = LeerFilas.GetString(2),
                    Stockexistencias = LeerFilas.GetInt32(3),
                    Fechaultimacompraexistencias = LeerFilas.GetDateTime(4),
                    Costoexistencias = LeerFilas.GetInt32(5),
                    Precioexistencias = LeerFilas.GetInt32(6),
                    Idproveedorexistencias = LeerFilas.GetInt32(7)
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }


        //Buscar Existencia por codigo SP_BUSCARPRODUCTOCODIGO
        public List<E_Existencia> BuscarExistenciaPorCodigo(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARPRODUCTOCODIGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Existencia> Listar = new List<E_Existencia>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Existencia
                {
                    Idexistencias = LeerFilas.GetInt32(0),
                    Codigoexistencias = LeerFilas.GetString(1),
                    Nombreexistencias = LeerFilas.GetString(2),
                    Stockexistencias = LeerFilas.GetInt32(3),
                    Fechaultimacompraexistencias = LeerFilas.GetDateTime(4),
                    Costoexistencias = LeerFilas.GetInt32(5),
                    Precioexistencias = LeerFilas.GetInt32(6),
                    Idproveedorexistencias = LeerFilas.GetInt32(7)

                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }













        public DataTable ListExistencias()
        {
            DataTable tabla = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTAREXISTENCIAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            tabla.Load(readRows);

            readRows.Close();
            conexion.Close();

            return tabla;

        }

        public void InsertarExistencia(E_Existencia existencia)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAREXISTENCIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODIGO", existencia.Codigoexistencias);
            cmd.Parameters.AddWithValue("@NOMBRE", existencia.Nombreexistencias);
            cmd.Parameters.AddWithValue("@STOCK", existencia.Stockexistencias);
            cmd.Parameters.AddWithValue("@FECHA_ULTIMA_COMPRA", existencia.Fechaultimacompraexistencias);
            cmd.Parameters.AddWithValue("@COSTO", existencia.Costoexistencias);
            cmd.Parameters.AddWithValue("@PRECIO", existencia.Precioexistencias);
            cmd.Parameters.AddWithValue("@IDPROVEEDORES", existencia.Idproveedorexistencias);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        


        public void ActualizarExistencia(E_Existencia Existencia)
        {
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZAREXISTENCIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDEXISTENCIA", Existencia.Idexistencias);
            cmd.Parameters.AddWithValue("@NOMBRE", Existencia.Nombreexistencias);
            cmd.Parameters.AddWithValue("@STOCK", Existencia.Stockexistencias);
            cmd.Parameters.AddWithValue("@FECHA_ULTIMA_COMPRA", Existencia.Fechaultimacompraexistencias);
            cmd.Parameters.AddWithValue("@COSTO", Existencia.Costoexistencias);
            cmd.Parameters.AddWithValue("@PRECIO", Existencia.Precioexistencias);
            cmd.Parameters.AddWithValue("@IDPROVEEDORES", Existencia.Idproveedorexistencias);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
