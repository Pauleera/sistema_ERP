using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Existencias
    {
        D_Existencia objDato = new D_Existencia();

        public void InsertandoExistencia(E_Existencia Existencia)
        {
            objDato.InsertarExistencia(Existencia);
        }
        public List<E_Existencia> ListandoExistencia(string buscar)
        {
            return objDato.ListarExistencia(buscar);
        }

        public void EditandoExistencia(E_Existencia Existencia)
        {
            objDato.ActualizarExistencia(Existencia);
        }

        public List<E_Existencia> BuscandoExistenciaPorCodigo(string buscar)
        {
            return objDato.BuscarExistenciaPorCodigo(buscar);
        }


    }
}
