using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Kardex
    {
        D_Kardex objData = new D_Kardex();



        public List<E_kardex> ListandoKardex(string buscar)
        {
            return objData.ListarKardex(buscar);
        }


        public void InsertandoKardex(E_kardex kardex)
        {
            objData.InsertarKardex(kardex);
        }





    }
}
