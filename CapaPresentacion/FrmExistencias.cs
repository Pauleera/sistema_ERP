using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmExistencias : Form
    {
        public FrmExistencias()
        {
            InitializeComponent();
            mostrarBuscarTabla("");
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Existencias objNegocio = new N_Existencias();
            tablaExistencias.DataSource = objNegocio.BuscandoExistenciaPorCodigo(buscar);
        }



    }
}
