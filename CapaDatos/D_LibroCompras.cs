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
    public class D_LibroCompras
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable listarLibroCompras()
        {
            DataTable table = new DataTable();

            SqlDataReader readRows;

            SqlCommand cmd = new SqlCommand("SP_LISTARLIBROCOMPRAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();


            return table;
        }

        public void InsertarLibroCompras(E_LibroCompras e_LibroCompras)
        {


            SqlCommand cmd = new SqlCommand("SP_INSERTARCOMPRA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();


            cmd.Parameters.AddWithValue("@FECHA", e_LibroCompras.Fechalibrocompras);
            cmd.Parameters.AddWithValue("@TIPODOC", e_LibroCompras.Tipodoclibrocompras);
            cmd.Parameters.AddWithValue("@NUMERO", e_LibroCompras.Numerolibrocompras);
            cmd.Parameters.AddWithValue("@NETO", e_LibroCompras.Netolibrocompras);
            cmd.Parameters.AddWithValue("@IVA", e_LibroCompras.Ivalibrocompras);
            cmd.Parameters.AddWithValue("@TOTAL", e_LibroCompras.Totallibrocompras);
            cmd.Parameters.AddWithValue("@METODOPAGO", e_LibroCompras.Metodopagolibrocompras);
            cmd.Parameters.AddWithValue("@IDPROVEEDORES", e_LibroCompras.Idproveedoreslibrocompras);
            cmd.Parameters.AddWithValue("@IDCUENTA", e_LibroCompras.Idcuenta);

            cmd.ExecuteNonQuery();
            conexion.Close();

            return;

        }

        public List<E_LibroCompras> ListarCompras(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTARLIBROCOMPRAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            //cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_LibroCompras> Listar = new List<E_LibroCompras>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_LibroCompras
                {

                    Idlibrocompras = LeerFilas.GetInt32(0),
                    Fechalibrocompras = LeerFilas.GetDateTime(1),
                    Tipodoclibrocompras = LeerFilas.GetString(2),
                    Numerolibrocompras = LeerFilas.GetString(3),
                    Netolibrocompras = LeerFilas.GetInt32(4),
                    Ivalibrocompras = LeerFilas.GetInt32(5),
                    Totallibrocompras = LeerFilas.GetInt32(6),
                    Metodopagolibrocompras = LeerFilas.GetString(7),
                    Idproveedoreslibrocompras = LeerFilas.GetInt32(8),
                    Rutprov = LeerFilas.GetString(9),
                    Nombreprov = LeerFilas.GetString(10),
                    Idcuenta = LeerFilas.GetInt32(11),
                    Codcuenta = LeerFilas.GetString(12),
                    Nombrecuenta = LeerFilas.GetString(13)


                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void EliminarCompra(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCOMPRA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDLIBROCOMPRAS", id);


            cmd.ExecuteNonQuery();
            conexion.Close();

            return;

        }

        public void EditarCompra(E_LibroCompras e_LibroCompras)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCOMPRA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@FECHA", e_LibroCompras.Fechalibrocompras);
            cmd.Parameters.AddWithValue("@TIPODOC", e_LibroCompras.Tipodoclibrocompras);
            cmd.Parameters.AddWithValue("@NUMERO", e_LibroCompras.Numerolibrocompras);
            cmd.Parameters.AddWithValue("@NETO", e_LibroCompras.Netolibrocompras);
            cmd.Parameters.AddWithValue("@IVA", e_LibroCompras.Ivalibrocompras);
            cmd.Parameters.AddWithValue("@TOTAL", e_LibroCompras.Totallibrocompras);
            cmd.Parameters.AddWithValue("@IDPROVEEDORES", e_LibroCompras.Idproveedoreslibrocompras);
            cmd.Parameters.AddWithValue("@IDCUENTA", e_LibroCompras.Idcuenta);

            cmd.ExecuteNonQuery();
            conexion.Close();

            return;
        }




    } 
    }
