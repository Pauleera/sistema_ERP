using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_DiccionarioCuentas
    {
        private int _IdDiccionarioCuentas;
        private string _CodigoDiccionarioCuentas;
        private string _NombreDiccionarioCuentas;

        public int IdDiccionarioCuentas { get => _IdDiccionarioCuentas; set => _IdDiccionarioCuentas = value; }
        public string CodigoDiccionarioCuentas { get => _CodigoDiccionarioCuentas; set => _CodigoDiccionarioCuentas = value; }
        public string NombreDiccionarioCuentas { get => _NombreDiccionarioCuentas; set => _NombreDiccionarioCuentas = value; }
    }
}
