using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmLibroVentas : Form
    {

        N_LibroVentas negocioLibroVentas = new N_LibroVentas();

        E_LibroVentas entidadLibroVentas = new E_LibroVentas();

        List<E_LibroVentas> listLibroVentas = new List<E_LibroVentas>();


        public FrmLibroVentas()
        {
            InitializeComponent();
            //mostrarBuscarTabla("");

            labelCheq.Text = "0";
            labelEfectivo.Text = "0";
            labelDeb.Text = "0";
            labelCred.Text = "0";

            this.dateDesde.Value = DateTime.Now;
            this.dateHasta.Value = DateTime.Now;

            txtAño.Text = Convert.ToString(DateTime.Now.Year);
            txtAñoyMes.Text = Convert.ToString(DateTime.Now.Year);

            listLibroVentas = obtenerLibroVentas("");
        }

        

        public void diseñoGlosa()
        {
            tablaLibroVentas.Columns[0].Visible = false;
            tablaLibroVentas.Columns[8].Visible = false;

            tablaLibroVentas.Columns[1].Width = 150;
            tablaLibroVentas.Columns[2].Width = 200;
            tablaLibroVentas.Columns[3].Width = 91;
            tablaLibroVentas.Columns[4].Width = 150;
            tablaLibroVentas.Columns[5].Width = 150;
            tablaLibroVentas.Columns[6].Width = 150;
            tablaLibroVentas.Columns[7].Width = 150;
            tablaLibroVentas.Columns[8].Width = 150;
        }



        public List<E_LibroVentas> obtenerLibroVentas(string buscar)
        {
            return negocioLibroVentas.ListandoVentas(buscar);
        }

        public void mostrarBuscarTabla(string buscar)
        {

            tablaLibroVentas.DataSource = negocioLibroVentas.ListandoVentas(buscar);
        }



        public void hacerResumen()
        {
            int total_efectivo = 0;
            int total_deb = 0;
            int total_cheq = 0;
            int total_cred = 0;


            foreach (DataGridViewRow row in tablaLibroVentas.Rows)
            {
                if (Convert.ToString(row.Cells[7].Value) == "EFECTIVO")
                {
                    total_efectivo = total_efectivo + Convert.ToInt32(row.Cells[6].Value);
                }

                if (Convert.ToString(row.Cells[7].Value) == "DEBITO")
                {
                    total_deb = total_deb + Convert.ToInt32(row.Cells[6].Value);
                }

                if (Convert.ToString(row.Cells[7].Value) == "CHEQUE")
                {
                    total_cheq = total_cheq + Convert.ToInt32(row.Cells[6].Value);
                }

                if (Convert.ToString(row.Cells[7].Value) == "CREDITO")
                {
                    total_cred = total_cred + Convert.ToInt32(row.Cells[6].Value);
                }

            }

            labelEfectivo.Text = Convert.ToString(total_efectivo);
            labelCheq.Text = Convert.ToString(total_cheq);
            labelDeb.Text = Convert.ToString(total_deb);
            labelCred.Text = Convert.ToString(total_cred);


        }

        public static List<E_LibroVentas> ItemsBetweenDates(List<E_LibroVentas> items, DateTime startDate, DateTime endDate)
        {
            return items.Where(i => i.Fechalibroventas.Date >= startDate.Date && i.Fechalibroventas.Date <= endDate.Date).ToList();
        }


        private void btnBetweenDates_Click(object sender, EventArgs e)
        {
            tablaLibroVentas.DataSource = ItemsBetweenDates(listLibroVentas, Convert.ToDateTime(dateDesde.Value), Convert.ToDateTime(dateHasta.Value));
            diseñoGlosa();
            hacerResumen();
        }

        private void btnPorAño_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(txtAño.Text);

            DateTime desde = new DateTime(año, 01, 01);
            DateTime hasta = new DateTime(año, 12, 31);

            tablaLibroVentas.DataSource = ItemsBetweenDates(listLibroVentas, Convert.ToDateTime(desde), Convert.ToDateTime(hasta));
            diseñoGlosa();
            hacerResumen();

        }

        private void btnPorMes_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(txtAñoyMes.Text);
            string mes_string = txtMes.Text.Substring(0, 2);
            int mes = Convert.ToInt32(mes_string);
            int last_day = Convert.ToInt32(DateTime.DaysInMonth(año, mes));


            DateTime desde = new DateTime(año, mes, 01);
            DateTime hasta = new DateTime(año, mes, last_day);

            tablaLibroVentas.DataSource = ItemsBetweenDates(listLibroVentas, Convert.ToDateTime(desde), Convert.ToDateTime(hasta));
            diseñoGlosa();
            hacerResumen();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
