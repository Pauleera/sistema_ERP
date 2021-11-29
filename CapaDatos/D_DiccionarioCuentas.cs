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
    public class D_DiccionarioCuentas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_DiccionarioCuentas> ListarDiccionario(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCUENTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_DiccionarioCuentas> Listar = new List<E_DiccionarioCuentas>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_DiccionarioCuentas
                {
                    IdDiccionarioCuentas = LeerFilas.GetInt32(0),
                    CodigoDiccionarioCuentas = LeerFilas.GetString(1),
                    NombreDiccionarioCuentas = LeerFilas.GetString(2),
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }


        public void InsertarCuenta(E_DiccionarioCuentas e_DiccionarioCuentas)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCUENTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODIGO", e_DiccionarioCuentas.CodigoDiccionarioCuentas);
            cmd.Parameters.AddWithValue("@NOMBRECUENTA", e_DiccionarioCuentas.NombreDiccionarioCuentas);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarCuenta(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCUENTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCUENTA", id);


            cmd.ExecuteNonQuery();
            conexion.Close();

        }

    }



}
