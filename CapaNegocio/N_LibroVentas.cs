using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_LibroVentas
    {
        D_LibroVentas objDato = new D_LibroVentas();

        public List<E_LibroVentas> ListandoVentas(string buscar)
        {
            return objDato.ListarVentas(buscar);
        }

        public void InsertandoVenta(E_LibroVentas Libroventas)
        {
            
            objDato.InsertarLibroVentas(Libroventas);
        }

        public int ObteniendoIdUltimaVenta()
        {
           return objDato.obtenerNumLibroVentas();
        }




    }
}
