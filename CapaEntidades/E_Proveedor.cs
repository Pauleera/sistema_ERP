using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Proveedor
    {
        private int _Idproveedor;
        private string _Rutproveedor;
        private string _Nombreproveedor;
        private string _Razonsocialproveedor;
        private string _Direccionproveedor;
        private string _Ciudadproveedor;
        private string _Emailproveedor;
        private string _Contactoproveedor;

        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string Rutproveedor { get => _Rutproveedor; set => _Rutproveedor = value; }
        public string Nombreproveedor { get => _Nombreproveedor; set => _Nombreproveedor = value; }
        public string Razonsocialproveedor { get => _Razonsocialproveedor; set => _Razonsocialproveedor = value; }
        public string Direccionproveedor { get => _Direccionproveedor; set => _Direccionproveedor = value; }
        public string Ciudadproveedor { get => _Ciudadproveedor; set => _Ciudadproveedor = value; }
        public string Emailproveedor { get => _Emailproveedor; set => _Emailproveedor = value; }
        public string Contactoproveedor { get => _Contactoproveedor; set => _Contactoproveedor = value; }
    }
}
