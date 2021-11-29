using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Existencia
    {
        private int _Idexistencias;
        private string _Codigoexistencias;
        private string _Nombreexistencias;
        private int _Stockexistencias;
        private DateTime _Fechaultimacompraexistencias;
        private int _Costoexistencias;
        private int _Precioexistencias;
        private int _Idproveedorexistencias;

        public int Idexistencias { get => _Idexistencias; set => _Idexistencias = value; }
        public string Codigoexistencias { get => _Codigoexistencias; set => _Codigoexistencias = value; }
        public string Nombreexistencias { get => _Nombreexistencias; set => _Nombreexistencias = value; }
        public int Stockexistencias { get => _Stockexistencias; set => _Stockexistencias = value; }
        public DateTime Fechaultimacompraexistencias { get => _Fechaultimacompraexistencias; set => _Fechaultimacompraexistencias = value; }
        public int Costoexistencias { get => _Costoexistencias; set => _Costoexistencias = value; }
        public int Precioexistencias { get => _Precioexistencias; set => _Precioexistencias = value; }
        public int Idproveedorexistencias { get => _Idproveedorexistencias; set => _Idproveedorexistencias = value; }
    }
}
