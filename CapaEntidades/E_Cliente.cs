using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Cliente
    {
        private int _Idcliente;
        private string _Rutcliente;
        private string _Nombrecliente;
        private string _Direccioncliente;
        private string _Ciudadcliente;
        private string _Emailcliente;
        private string _Contactocliente;

        public int Idcliente { get => _Idcliente; set => _Idcliente = value; }
        public string Rutcliente { get => _Rutcliente; set => _Rutcliente = value; }
        public string Nombrecliente { get => _Nombrecliente; set => _Nombrecliente = value; }
        public string Direccioncliente { get => _Direccioncliente; set => _Direccioncliente = value; }
        public string Ciudadcliente { get => _Ciudadcliente; set => _Ciudadcliente = value; }
        public string Emailcliente { get => _Emailcliente; set => _Emailcliente = value; }
        public string Contactocliente { get => _Contactocliente; set => _Contactocliente = value; }
    }
}
