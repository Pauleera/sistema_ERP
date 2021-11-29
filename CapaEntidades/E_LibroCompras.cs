using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class E_LibroCompras
    {

        private int _Idlibrocompras;
        private DateTime _Fechalibrocompras;
        private string _Tipodoclibrocompras;
        private string _Numerolibrocompras;
        private int _Netolibrocompras;
        private int _Ivalibrocompras;
        private int _Totallibrocompras;
        private string _Metodopagolibrocompras;
        private int _idproveedoreslibrocompras;
        private int _idcuenta;
        private string _Rutprov;
        private string _Nombreprov;
        private string _Codcuenta;
        private string _Nombrecuenta;


        public int Idlibrocompras { get => _Idlibrocompras; set => _Idlibrocompras = value; }
        public DateTime Fechalibrocompras { get => _Fechalibrocompras; set => _Fechalibrocompras = value; }
        public string Tipodoclibrocompras { get => _Tipodoclibrocompras; set => _Tipodoclibrocompras = value; }
        public string Numerolibrocompras { get => _Numerolibrocompras; set => _Numerolibrocompras = value; }
        public int Netolibrocompras { get => _Netolibrocompras; set => _Netolibrocompras = value; }
        public int Ivalibrocompras { get => _Ivalibrocompras; set => _Ivalibrocompras = value; }
        public int Totallibrocompras { get => _Totallibrocompras; set => _Totallibrocompras = value; }
        public string Metodopagolibrocompras { get => _Metodopagolibrocompras; set => _Metodopagolibrocompras = value; }
        public int Idproveedoreslibrocompras { get => _idproveedoreslibrocompras; set => _idproveedoreslibrocompras = value; }
        public int Idcuenta { get => _idcuenta; set => _idcuenta = value; }
        public string Rutprov { get => _Rutprov; set => _Rutprov = value; }
        public string Nombreprov { get => _Nombreprov; set => _Nombreprov = value; }
        public string Codcuenta { get => _Codcuenta; set => _Codcuenta = value; }
        public string Nombrecuenta { get => _Nombrecuenta; set => _Nombrecuenta = value; }
    }
}
