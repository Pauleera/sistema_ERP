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
    public class D_Proveedor
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Proveedor> ListarProvedores(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARPROVEEDOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Proveedor> Listar = new List<E_Proveedor>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Proveedor
                {
                    Idproveedor = LeerFilas.GetInt32(0),
                    Rutproveedor = LeerFilas.GetString(1),
                    Nombreproveedor = LeerFilas.GetString(2),
                    Razonsocialproveedor = LeerFilas.GetString(3),
                    Direccionproveedor = LeerFilas.GetString(4),
                    Ciudadproveedor = LeerFilas.GetString(5),
                    Emailproveedor = LeerFilas.GetString(6),
                    Contactoproveedor = LeerFilas.GetString(7)
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        } 

        public int InsertarProveedor(E_Proveedor Proveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARPROVEEDOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Int32 newProvID = 0;

            cmd.Parameters.AddWithValue("@RUT", Proveedor.Rutproveedor);
            cmd.Parameters.AddWithValue("@NOMBRE", Proveedor. Nombreproveedor);
            cmd.Parameters.AddWithValue("@RAZONSOCIAL", Proveedor.Razonsocialproveedor);
            cmd.Parameters.AddWithValue("@DIRECCION", Proveedor.Direccionproveedor);
            cmd.Parameters.AddWithValue("@CIUDAD", Proveedor.Ciudadproveedor);
            cmd.Parameters.AddWithValue("@EMAIL", Proveedor.Emailproveedor);
            cmd.Parameters.AddWithValue("@CONTACTO", Proveedor.Contactoproveedor);

            newProvID = (Int32)cmd.ExecuteScalar();
            conexion.Close();

            return (int)newProvID;
        }

        public void EditarProveedor(E_Proveedor Proveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARPROVEEDOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPROVEEDORES", Proveedor.Idproveedor);
            cmd.Parameters.AddWithValue("@RUT", Proveedor.Rutproveedor);
            cmd.Parameters.AddWithValue("@NOMBRE", Proveedor.Nombreproveedor);
            cmd.Parameters.AddWithValue("@RAZONSOCIAL", Proveedor.Razonsocialproveedor);
            cmd.Parameters.AddWithValue("@DIRECCION", Proveedor.Direccionproveedor);
            cmd.Parameters.AddWithValue("@CIUDAD", Proveedor.Ciudadproveedor);
            cmd.Parameters.AddWithValue("@EMAIL", Proveedor.Emailproveedor);
            cmd.Parameters.AddWithValue("@CONTACTO", Proveedor.Contactoproveedor);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarProveedor(E_Proveedor Proveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARPROVEEDOR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPROVEEDORES", Proveedor.Idproveedor);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
