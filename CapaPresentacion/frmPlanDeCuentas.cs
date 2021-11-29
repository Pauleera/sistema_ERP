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
    public partial class frmPlanDeCuentas : Form
    {
        N_diccionarioCuentas negocioDiccionarioCuentas = new N_diccionarioCuentas();
        E_DiccionarioCuentas e_DiccionarioCuentas = new E_DiccionarioCuentas();


        N_LibroCompras negocioLibroCompras = new N_LibroCompras();
        E_LibroCompras e_LibroCompras = new E_LibroCompras();

        List<E_LibroCompras> listaResumen = new List<E_LibroCompras>();
        DataTable datatableLibroCompras = new DataTable();


        int idProveedor;
        int idCuenta;

        int neto;
        int iva;
        int total;

        int netoFinal;
        int ivaFinal;
        int totalFinal;




        public frmPlanDeCuentas()
        {
            InitializeComponent();

            this.dateCompra.Value = DateTime.Now;

            actualizarLibro();
            datatableLibroCompras = negocioLibroCompras.ListandoLibroCompras();

            mostrarBuscarTablaDiccionario("");
            tablaDiccionarioCuentas.Columns[0].Visible = false;

            txtCrearCuenta.Visible = false;
            txtCrearGlosaCuenta.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            bunifuFlatButton4.Visible = false;
            btnEliminarCuenta.Visible = false;

        }


        public void mostrarBuscarTablaDiccionario(string buscar)
        {
            N_Kardex objNegocio = new N_Kardex();
            tablaDiccionarioCuentas.DataSource = negocioDiccionarioCuentas.ListandoDiccionarioCuentas(buscar);
            tablaDiccionarioCuentas.Columns[0].Visible = false;
            tablaDiccionarioCuentas.Columns[1].HeaderText = "COD";
            tablaDiccionarioCuentas.Columns[2].HeaderText = "CUENTA";
            
        }


        public List<E_LibroCompras> mostrarLibroCompras(string buscar)
        {
            return negocioLibroCompras.ListandoCompras(buscar);

        }

        public void actualizarLibro()
        {
            listaResumen = mostrarLibroCompras("");
        }




        private void limpiarCajas()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            txtNumero.Text = "";
            txtTipoDoc.Text = "FACTURA";
            txtBuscarRut.Text = "";

        }

        private void limpiarCajaCuenta()
        {
            txtBuscarProducto.Text = "";
            txtNombreCuenta.Text = "";
            txtNetoCuenta.Text = "";
        }

        private void limpiarGlosa()
        {
            tablaGlosa.DataSource = "";
        }


        private void txtBuscarRut_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscarRut.Text.Length <= 0)
            {
                limpiarCajas();
            }
            else
            {
                N_Proveedor objNegocio = new N_Proveedor();
                List<E_Proveedor> resultado = objNegocio.ListandoProveedor(txtBuscarRut.Text);
                if (resultado.Count > 0)
                {
                    idProveedor = resultado[0].Idproveedor;
                    txtRut.Text = resultado[0].Rutproveedor;
                    txtNombre.Text = resultado[0].Nombreproveedor;
                    txtRazonSocial.Text = resultado[0].Razonsocialproveedor;
                    
                }
                else if (resultado.Count <= 0)
                {
                    limpiarCajas();
                }

            }

        }

        private void btnAñadirCompra_Click(object sender, EventArgs e)
        {
            if(txtRut.Text != "" && txtBuscarProducto.Text != "" && txtNombreCuenta.Text != "" && txtNetoCuenta.Text != "")
            {

                neto = Convert.ToInt32(txtNetoCuenta.Text);
                iva = Convert.ToInt32(neto * 0.19);
                total = neto + iva;
                


                List<E_LibroCompras> Listar = new List<E_LibroCompras>();

                Listar.Add(new E_LibroCompras
                {
                    Fechalibrocompras = dateCompra.Value,
                    Tipodoclibrocompras = txtTipoDoc.Text ,
                    Numerolibrocompras = txtNumero.Text,
                    Netolibrocompras = neto,
                    Ivalibrocompras = iva,
                    Totallibrocompras = total,
                    Metodopagolibrocompras = txtFormaPago.Text,
                    Idproveedoreslibrocompras = idProveedor,
                    Idcuenta = idCuenta,
                });

                int RowID = tablaGlosa.Rows.Add();

                DataGridViewRow Row = tablaGlosa.Rows[RowID];

                Row.Cells[0].Value = txtBuscarProducto.Text;
                Row.Cells[1].Value = Listar[0].Fechalibrocompras;
                Row.Cells[2].Value = Listar[0].Tipodoclibrocompras;
                Row.Cells[3].Value = Listar[0].Numerolibrocompras;
                Row.Cells[4].Value = Listar[0].Ivalibrocompras;
                Row.Cells[5].Value = Listar[0].Totallibrocompras;
                Row.Cells[6].Value = Listar[0].Metodopagolibrocompras;
                Row.Cells[7].Value = Listar[0].Idproveedoreslibrocompras;
                Row.Cells[8].Value = Listar[0].Idcuenta;
                Row.Cells[9].Value = txtNombreCuenta.Text;
                Row.Cells[10].Value = Listar[0].Netolibrocompras;

                totalFinal = total + totalFinal;
                ivaFinal = iva + ivaFinal;
                netoFinal = neto + netoFinal;

                lblTotal.Text = totalFinal.ToString();
                lblIva.Text = ivaFinal.ToString();
                lblNeto.Text = netoFinal.ToString();



                limpiarCajaCuenta();

            }
        }


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }



        private void frmPlanDeCuentas_Load(object sender, EventArgs e)
        {

        }

        private void tablaDiccionarioCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtCrearCuenta.Visible = false;
            txtCrearGlosaCuenta.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            bunifuFlatButton4.Visible = false;

            btnEliminarCuenta.Visible = true;

            int index = e.RowIndex;
            tablaDiccionarioCuentas.Rows[index].Selected = true;

            idCuenta = Convert.ToInt32(tablaDiccionarioCuentas.CurrentRow.Cells[0].Value);
            txtBuscarProducto.Text = tablaDiccionarioCuentas.CurrentRow.Cells[1].Value.ToString();
            txtNombreCuenta.Text = tablaDiccionarioCuentas.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void tablaDiccionarioCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //mostrar botones añadir cuenta nuevaAñadir una nueva cuenta
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        //añadir diccionario cuentas
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if(txtCrearCuenta.TextLength > 0)
            {
                e_DiccionarioCuentas.CodigoDiccionarioCuentas = txtCrearCuenta.Text;
            }
            else
            {
                MessageBox.Show("Ingrese código cuenta");
                txtCrearCuenta.Focus();
            }

            if(txtCrearGlosaCuenta.TextLength > 0)
            {
                e_DiccionarioCuentas.NombreDiccionarioCuentas = txtCrearGlosaCuenta.Text;
            }
            else
            {
                MessageBox.Show("Ingrese nombre de cuenta");
                txtCrearCuenta.Focus();
            }

            if (e_DiccionarioCuentas.CodigoDiccionarioCuentas.Length > 0 & e_DiccionarioCuentas.NombreDiccionarioCuentas.Length > 0)
            {
                negocioDiccionarioCuentas.InsertandoDiccionarioCuentas(e_DiccionarioCuentas);
                txtCrearCuenta.Text = "";
                txtCrearGlosaCuenta.Text = "";

                MessageBox.Show("Se ingresó la cuenta nueva");

                mostrarBuscarTablaDiccionario("");
            }


        }

        private void btnAddCuenta_Click(object sender, EventArgs e)
        {
            txtCrearCuenta.Visible = true;
            txtCrearGlosaCuenta.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            bunifuFlatButton4.Visible = true;
            btnEliminarCuenta.Visible = false;

            txtCrearCuenta.Focus();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
           if(idCuenta > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar la cuenta?", "Eliminar cuenta", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    negocioDiccionarioCuentas.EliminandoDiccionarioCuentas(idCuenta);
                    btnEliminarCuenta.Visible = false;
                    mostrarBuscarTablaDiccionario("");

                }
                else
                {
                    
                    btnEliminarCuenta.Visible = false;
                }


            }
        }

        private void txtBuscarRut_TextChanged_1(object sender, EventArgs e)
        {

            if (txtBuscarRut.Text.Length <= 0)
            {
                limpiarCajas();
            }
            else
            {
                N_Proveedor objNegocio = new N_Proveedor();
                List<E_Proveedor> resultado = objNegocio.ListandoProveedor(txtBuscarRut.Text);
                if (resultado.Count > 0)
                {
                    idProveedor = resultado[0].Idproveedor;
                    txtRut.Text = resultado[0].Rutproveedor;
                    txtNombre.Text = resultado[0].Nombreproveedor;
                    txtRazonSocial.Text = resultado[0].Razonsocialproveedor;
                }
                else if (resultado.Count <= 0)
                {
                    limpiarCajas();
                }


        }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in tablaGlosa.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        //añadir cuentas a plan de compras
                        e_LibroCompras.Fechalibrocompras = dateCompra.Value;
                        e_LibroCompras.Tipodoclibrocompras = txtTipoDoc.Text;
                        e_LibroCompras.Numerolibrocompras = txtNumero.Text;
                        e_LibroCompras.Netolibrocompras = Convert.ToInt32(row.Cells[10].Value);
                        e_LibroCompras.Ivalibrocompras = Convert.ToInt32(row.Cells[4].Value);
                        e_LibroCompras.Totallibrocompras = Convert.ToInt32(row.Cells[5].Value);
                        e_LibroCompras.Metodopagolibrocompras = txtFormaPago.Text;
                        e_LibroCompras.Idproveedoreslibrocompras = idProveedor;
                        e_LibroCompras.Idcuenta = Convert.ToInt32(row.Cells[8].Value);

                        negocioLibroCompras.InsertandoCompra(e_LibroCompras);

                    }
                    
                }
                actualizarLibro();
                MessageBox.Show("Guardado con éxito");
                limpiarCajaCuenta();
                limpiarCajas();
                limpiarGlosa();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }


        private void tablaGlosa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaGlosa.Rows[e.RowIndex].Cells["eliminarFila"].Selected)
            {
                int netoEliminar = Convert.ToInt32(tablaGlosa.Rows[e.RowIndex].Cells[10].Value);
                int ivaEliminar = Convert.ToInt32(tablaGlosa.Rows[e.RowIndex].Cells[4].Value);
                int totalEliminar = Convert.ToInt32(tablaGlosa.Rows[e.RowIndex].Cells[5].Value);


                totalFinal = totalFinal - totalEliminar;
                ivaFinal = ivaFinal - ivaEliminar;
                netoFinal = netoFinal - netoEliminar;

                lblTotal.Text = totalFinal.ToString();
                lblIva.Text = ivaFinal.ToString();
                lblNeto.Text = netoFinal.ToString();

                tablaGlosa.Rows.Remove(tablaGlosa.Rows[e.RowIndex]);

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            actualizarLibro();

            consultarLibroPorMes();

        }

        public void consultarLibroPorMes()
        {
            
            int año = Convert.ToInt32(txtAñoyMes.Text);
            string mes_string = txtMes.Text.Substring(0, 2);
            int mes = Convert.ToInt32(mes_string);
            int last_day = Convert.ToInt32(DateTime.DaysInMonth(año, mes));


            DateTime desde = new DateTime(año, mes, 01);
            DateTime hasta = new DateTime(año, mes, last_day);

            tablaResumen.DataSource = ItemsBetweenDates(listaResumen, Convert.ToDateTime(desde), Convert.ToDateTime(hasta));


            diseñoGlosaResumen();
            hacerResumen();
        }

        private void btnPorMes_Click(object sender, EventArgs e)
        {

        }

        public static List<E_LibroCompras> ItemsBetweenDates(List<E_LibroCompras> items, DateTime startDate, DateTime endDate)
        {
            return items.Where(i => i.Fechalibrocompras.Date >= startDate.Date && i.Fechalibrocompras.Date <= endDate.Date).ToList();
        }



        public void diseñoGlosaResumen()
        {
            tablaResumen.ColumnHeadersVisible = true;
            tablaResumen.Columns[0].Visible = false;
            tablaResumen.Columns[1].Visible = true;
            tablaResumen.Columns[2].Visible = true;
            tablaResumen.Columns[3].Visible = true;
            tablaResumen.Columns[4].Visible = true;
            tablaResumen.Columns[5].Visible = true;
            tablaResumen.Columns[6].Visible = true;
            tablaResumen.Columns[7].Visible = true;
            tablaResumen.Columns[8].Visible = false;
            tablaResumen.Columns[9].Visible = false;
            tablaResumen.Columns[10].Visible = true;
            tablaResumen.Columns[11].Visible = true;
            tablaResumen.Columns[12].Visible = true;
            tablaResumen.Columns[13].Visible = true;

            tablaResumen.Columns[10].DisplayIndex = 9;
            tablaResumen.Columns[11].DisplayIndex = 8;
            tablaResumen.Columns[4].DisplayIndex = 11;
            tablaResumen.Columns[5].DisplayIndex = 12;
            tablaResumen.Columns[6].DisplayIndex = 13;

            tablaResumen.Columns[1].HeaderText = "FECHA";
            tablaResumen.Columns[2].HeaderText = "TIPO DOC";
            tablaResumen.Columns[3].HeaderText = "N° DOC";

            tablaResumen.Columns[4].HeaderText = "NETO";
            tablaResumen.Columns[5].HeaderText = "IVA";
            tablaResumen.Columns[6].HeaderText = "TOTAL";

            tablaResumen.Columns[7].HeaderText = "METODO PAGO";
            tablaResumen.Columns[11].HeaderText = "NOMBRE";
            tablaResumen.Columns[10].HeaderText = "RUT";


            tablaResumen.Columns[12].HeaderText = "COD";
            tablaResumen.Columns[13].HeaderText = "CUENTA";


            //tablaResumen.Columns[12].DisplayIndex = 0;

        }

        public void hacerResumen()
        {
            int total_efectivo = 0;
            int total_deb = 0;
            int total_cheq = 0;
            int total_cred = 0;

            int total_IVA = 0;
            int total_NETO = 0;
            int total_TOTAL = 0;

            int total_IVAb = 0;
            int total_NETOb = 0;
            int total_TOTALb = 0;
            int total_IVAf = 0;
            int total_NETOf = 0;
            int total_TOTALf = 0;



            foreach (DataGridViewRow row in tablaResumen.Rows)
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

                if (Convert.ToString(row.Cells[2].Value) == "BOLETA")
                {
                    total_NETOb += Convert.ToInt32(row.Cells[4].Value);
                    total_IVAb += Convert.ToInt32(row.Cells[5].Value);
                    total_TOTALb += Convert.ToInt32(row.Cells[6].Value);
                }
                if (Convert.ToString(row.Cells[2].Value) == "FACTURA")
                {
                    total_NETOf += Convert.ToInt32(row.Cells[4].Value);
                    total_IVAf += Convert.ToInt32(row.Cells[5].Value);
                    total_TOTALf += Convert.ToInt32(row.Cells[6].Value);
                }

                total_NETO += Convert.ToInt32(row.Cells[4].Value);
                total_IVA += Convert.ToInt32(row.Cells[5].Value);
                total_TOTAL += Convert.ToInt32(row.Cells[6].Value);

            }

            labelEfectivo.Text = Convert.ToString(total_efectivo);
            labelCheq.Text = Convert.ToString(total_cheq);
            labelDeb.Text = Convert.ToString(total_deb);
            labelCred.Text = Convert.ToString(total_cred);

            lblResumenIva.Text = Convert.ToString(total_IVA);
            lblResumenNeto.Text = Convert.ToString(total_NETO);
            lblResumenTotal.Text = Convert.ToString(total_TOTAL);

            lblResumenIvaFact.Text = Convert.ToString(total_IVAf);
            lblResumenNetoFact.Text = Convert.ToString(total_NETOf);
            lblResumenTotalFact.Text = Convert.ToString(total_TOTALf);

            lblResumenIvabol.Text = Convert.ToString(total_IVAb);
            lblResumenNetoboleta.Text = Convert.ToString(total_NETOb);
            lblResumenTotalBol.Text = Convert.ToString(total_TOTALb);

        }

        private void btnResumenCuentas_Click(object sender, EventArgs e)
        {
            tablaResumen.DataSource = hacerResumenPorCuenta();
            tablaResumen.Columns[0].Visible = false;
            tablaResumen.Columns[1].Visible = false;
            tablaResumen.Columns[2].Visible = false;
            tablaResumen.Columns[3].Visible = false;
            tablaResumen.Columns[7].Visible = false;
            tablaResumen.Columns[8].Visible = false;
            tablaResumen.Columns[9].Visible = false;
            tablaResumen.Columns[10].Visible = false;
            tablaResumen.Columns[11].Visible = false;
            tablaResumen.Columns[4].HeaderText = "NETO";
            tablaResumen.Columns[5].HeaderText = "IVA";
            tablaResumen.Columns[6].HeaderText = "TOTAL";

            tablaResumen.Columns[12].DisplayIndex = 0;
            tablaResumen.Columns[13].DisplayIndex = 1;

            tablaResumen.Columns[12].HeaderText = "COD";
            tablaResumen.Columns[13].HeaderText = "CUENTA";


        }


        public List<E_LibroCompras> hacerResumenPorCuenta()
        {
            consultarLibroPorMes();

            List<E_LibroCompras> ListResumenPorCuentas = new List<E_LibroCompras>();

            string codCuentaActual;
            int totalCargo = 0;
            int netoCargo = 0;
            int ivaCargo = 0;

            foreach (DataGridViewRow row in tablaDiccionarioCuentas.Rows)
            {
                totalCargo = 0;
                netoCargo = 0;
                ivaCargo = 0;
                codCuentaActual = Convert.ToString(row.Cells[1].Value);
                foreach (DataGridViewRow rowi in tablaResumen.Rows)
                {

                    if (codCuentaActual == Convert.ToString(rowi.Cells[12].Value))
                    {
                        netoCargo += Convert.ToInt32(rowi.Cells[4].Value);
                        ivaCargo += Convert.ToInt32(rowi.Cells[5].Value);
                        totalCargo += Convert.ToInt32(rowi.Cells[6].Value);

                    }
                }

                ListResumenPorCuentas.Add(new E_LibroCompras
                {
                    Codcuenta = codCuentaActual,
                    Nombrecuenta = Convert.ToString(row.Cells[2].Value),
                    Ivalibrocompras = ivaCargo,
                    Netolibrocompras = netoCargo,
                    Totallibrocompras = totalCargo,
                });

            }


            if (ListResumenPorCuentas != null)
            {
                ListResumenPorCuentas.Sort((x, y) => Convert.ToInt32(y.Totallibrocompras).CompareTo(Convert.ToInt32(x.Totallibrocompras)));
                tablaResumen.DataSource = ListResumenPorCuentas;

            }

            return ListResumenPorCuentas;
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }


    }
}
