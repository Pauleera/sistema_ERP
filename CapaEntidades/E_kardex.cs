using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_kardex
    {
        private int _Idkardex;
        private string _Codigokardex;
        private DateTime _fechaKardex;
        private string _Tipodockardex;
        private string _Numerokardex;
        private int _Comprakarex;
        private int _Ventakardex;
        private int _PrecioKardex;


        public int Idkardex { get => _Idkardex; set => _Idkardex = value; }
        public string Codigokardex { get => _Codigokardex; set => _Codigokardex = value; }
        public DateTime FechaKardex { get => _fechaKardex; set => _fechaKardex = value; }
        public string Tipodockardex { get => _Tipodockardex; set => _Tipodockardex = value; }
        public string Numerokardex { get => _Numerokardex; set => _Numerokardex = value; }
        public int Comprakarex { get => _Comprakarex; set => _Comprakarex = value; }
        public int Ventakardex { get => _Ventakardex; set => _Ventakardex = value; }
        public int PrecioKardex { get => _PrecioKardex; set => _PrecioKardex = value; }
    }
}
