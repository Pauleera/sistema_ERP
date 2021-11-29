using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Indice
    {
        D_Indice objData = new D_Indice();

        public int obtenerNumeroBoleta()
        {
            return objData.obtenerNumeroBoleta();
        }

        public int obtenerNumeroFactura()
        {
            return objData.obtenerNumeroFactura();
        }

    }
}
