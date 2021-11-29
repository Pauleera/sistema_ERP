using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_LibroCompras
    {
        D_LibroCompras objDato = new D_LibroCompras();

        public DataTable ListandoLibroCompras()
        {
            return objDato.listarLibroCompras();
        }


        public List<E_LibroCompras> ListandoCompras(string buscar)
        {
            return objDato.ListarCompras(buscar);
        }

        public void InsertandoCompra(E_LibroCompras e_LibroCompras)
        {

            objDato.InsertarLibroCompras(e_LibroCompras);
        }

        public void EliminandoCompra(int id)
        {
            objDato.EliminarCompra(id);
        }

        public void EditandoCompra(E_LibroCompras e_LibroCompras)
        {
            objDato.EditarCompra(e_LibroCompras);
        }




    }
}
