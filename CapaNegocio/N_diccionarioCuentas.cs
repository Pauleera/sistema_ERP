using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_diccionarioCuentas
    {
        D_DiccionarioCuentas objDato = new D_DiccionarioCuentas();

        public List<E_DiccionarioCuentas> ListandoDiccionarioCuentas(string buscar)
        {
            return objDato.ListarDiccionario(buscar);
        }


        public void InsertandoDiccionarioCuentas(E_DiccionarioCuentas e_DiccionarioCuentas)
        {
            objDato.InsertarCuenta(e_DiccionarioCuentas);
        }

        public void EliminandoDiccionarioCuentas(int id)
        {
            objDato.EliminarCuenta(id);
        }



    }



}
