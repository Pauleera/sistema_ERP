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
    public partial class FrmKardex : Form
    {
        N_Existencias n_Existencias = new N_Existencias();
        E_kardex entidadKardex = new E_kardex();
        E_Existencia e_existencias = new E_Existencia();

        List<E_kardex> list = new List<E_kardex>();
        List<E_kardex> list_sort = new List<E_kardex>();



        public FrmKardex()
        {
            InitializeComponent();

        }

        private void FrmKardex_Load(object sender, EventArgs e)
        {
            //mostrarBuscarTabla("");
            //accionesTabla();

            txtOrden.Text = "Ordenar por";

        }


        public void mostrarBuscarTabla(string buscar)
        {
            N_Kardex objNegocio = new N_Kardex();


            list = objNegocio.ListandoKardex(buscar);


            List<E_Existencia> producto = n_Existencias.BuscandoExistenciaPorCodigo(buscar);
            if (producto.Count > 0)
            {
                string nombre = producto[0].Nombreexistencias;

                txtName.Text = nombre;

            }
            else
            {
                txtName.Text = "";
            }

            //Orden 

            if (txtOrden.Text == "Orden ascendente")
            {
                if (list != null)
                {
                    list.Sort((x, y) => DateTime.Compare(Convert.ToDateTime(x.FechaKardex), Convert.ToDateTime(y.FechaKardex)));
                    tablaKardex.DataSource = list;
                    //tablaKardex.Refresh();
                }
            }

            if (txtOrden.Text == "Orden descendente")
            {
                if (list != null)
                {
                    list.Sort((x, y) => DateTime.Compare(Convert.ToDateTime(y.FechaKardex), Convert.ToDateTime(x.FechaKardex)));
                    tablaKardex.DataSource = list;
                    //tablaKardex.Refresh();
                }
            }

            if (txtOrden.Text == "Orden por ingreso" || txtOrden.Text == "Ordenar por")
            {
                list = objNegocio.ListandoKardex(buscar);
                tablaKardex.DataSource = list;
                //tablaKardex.Refresh();

            }


        }

        public void accionesTabla()
        {
            tablaKardex.Columns[2].ValueType = System.Type.GetType("System.Date");

            tablaKardex.Columns[0].Visible = false;

            tablaKardex.Columns[1].Width = 40;
            tablaKardex.Columns[2].DefaultCellStyle.ForeColor = Color.Red;
            tablaKardex.Columns[2].Width = 80;
            tablaKardex.Columns[3].Width = 80;
            tablaKardex.Columns[4].Width = 40;
            tablaKardex.Columns[5].Width = 40;
            tablaKardex.Columns[5].DefaultCellStyle.ForeColor = Color.Red;
            tablaKardex.Columns[6].DefaultCellStyle.ForeColor = Color.Green;
            tablaKardex.Columns[6].Width = 40;
            tablaKardex.Columns[7].Width = 60;
        }

        public void hacerResumen()
        {
            int stock = 0;
            int total = 0;


            foreach (DataGridViewRow row in tablaKardex.Rows)
            {

                total = total + Convert.ToInt32(row.Cells[7].Value);

                stock = stock  + Convert.ToInt32(row.Cells[5].Value) - Convert.ToInt32(row.Cells[6].Value);

            }

            labelTotal.Text = Convert.ToString(total);
            labelStock.Text = Convert.ToString(stock);


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
            accionesTabla();
            hacerResumen();
            

            if(txtBuscar.Text == "")
            {
                tablaKardex.DataSource = "";
            }


        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {

            if(list != null)
            {
                list.Sort((x, y) => DateTime.Compare(Convert.ToDateTime(x.FechaKardex), Convert.ToDateTime(y.FechaKardex)));
                tablaKardex.Refresh();
            }
           

        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            if(list != null)
            {
                list.Sort((x, y) => DateTime.Compare(Convert.ToDateTime(y.FechaKardex), Convert.ToDateTime(x.FechaKardex)));
                tablaKardex.Refresh();
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }


        private void txtOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtOrden.Text == "Orden ascendente")
            {
                if (list != null)
                {
                    list.Sort((x, y) => DateTime.Compare(Convert.ToDateTime(x.FechaKardex), Convert.ToDateTime(y.FechaKardex)));
                    tablaKardex.Refresh();
                }
            }

            if (txtOrden.Text == "Orden descendente")
            {
                if (list != null)
                {
                    list.Sort((x, y) => DateTime.Compare(Convert.ToDateTime(y.FechaKardex), Convert.ToDateTime(x.FechaKardex)));
                    tablaKardex.Refresh();
                }
            }

            if (txtOrden.Text == "Orden por ingreso")
            {
                mostrarBuscarTabla(txtBuscar.Text);
            }
        }


        private void txtOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrden_SelectedValueChanged(object sender, EventArgs e)
        {

        }


    }
}
