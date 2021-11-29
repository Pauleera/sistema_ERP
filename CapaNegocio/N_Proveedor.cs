using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Proveedor
    {
        D_Proveedor objDato = new D_Proveedor();

        public List<E_Proveedor>ListandoProveedor(string buscar)
        {
            return objDato.ListarProvedores(buscar);
        }

        public int InsertandoProveedor(E_Proveedor Proveedor)
        {
            return objDato.InsertarProveedor(Proveedor);
        }

        public void EditandoProveedor(E_Proveedor Proveedor)
        {
            objDato.EditarProveedor(Proveedor);
        }

        public void EliminandoProveedor(E_Proveedor Proveedor)
        {
            objDato.EliminarProveedor(Proveedor);
        }


    }
}
