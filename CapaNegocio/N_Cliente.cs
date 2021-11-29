using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Cliente
    {
        D_Cliente objDato = new D_Cliente();

        public int InsertandoCliente(E_Cliente Cliente)
        {
           return objDato.InsertarCliente(Cliente);
        }

        public List<E_Cliente> ListandoClientes(string buscar)
        {
            return objDato.ListarClientes(buscar);
        }




    }
}
