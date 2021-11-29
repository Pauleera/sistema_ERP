using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_LibroVentas
    {
        private int _Idlibroventas;
        private DateTime _Fechalibroventas;
        private string _Tipodoclibroventas;
        private string _Numerolibroventas;
        private int _Netolibroventas;
        private int _Ivalibroventas;
        private int _Totallibroventas;
        private string _Metodopagolibroventas;
        private int _idclientelibroventas;

        public int Idlibroventas { get => _Idlibroventas; set => _Idlibroventas = value; }
        public DateTime Fechalibroventas { get => _Fechalibroventas; set => _Fechalibroventas = value; }
        public string Tipodoclibroventas { get => _Tipodoclibroventas; set => _Tipodoclibroventas = value; }
        public string Numerolibroventas { get => _Numerolibroventas; set => _Numerolibroventas = value; }
        public int Netolibroventas { get => _Netolibroventas; set => _Netolibroventas = value; }
        public int Ivalibroventas { get => _Ivalibroventas; set => _Ivalibroventas = value; }
        public int Totallibroventas { get => _Totallibroventas; set => _Totallibroventas = value; }
        public string Metodopagolibroventas { get => _Metodopagolibroventas; set => _Metodopagolibroventas = value; }
        public int Idclientelibroventas { get => _idclientelibroventas; set => _idclientelibroventas = value; }
    }
}
