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
    public class D_Cliente
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public int InsertarCliente(E_Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCLIENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            Int32 newClientID = 0;

            cmd.Parameters.AddWithValue("@RUT", cliente.Rutcliente);
            cmd.Parameters.AddWithValue("@NOMBRE", cliente.Nombrecliente);
            cmd.Parameters.AddWithValue("@DIRECCION", cliente.Direccioncliente);
            cmd.Parameters.AddWithValue("@CIUDAD", cliente.Ciudadcliente);
            cmd.Parameters.AddWithValue("@EMAIL", cliente.Emailcliente);
            cmd.Parameters.AddWithValue("@CONTACTO", cliente.Contactocliente);

            newClientID = (Int32)cmd.ExecuteScalar();

            //cmd.ExecuteNonQuery();
            conexion.Close();

            return (int)newClientID;

        }


        public List<E_Cliente> ListarClientes(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCLIENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Cliente> Listar = new List<E_Cliente>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Cliente
                {
                    Idcliente = LeerFilas.GetInt32(0),
                    Rutcliente = LeerFilas.GetString(1),
                    Nombrecliente = LeerFilas.GetString(2),
                    Direccioncliente = LeerFilas.GetString(3),
                    Ciudadcliente = LeerFilas.GetString(4),
                    Emailcliente = LeerFilas.GetString(5),
                    Contactocliente = LeerFilas.GetString(6)
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }






    }
}
