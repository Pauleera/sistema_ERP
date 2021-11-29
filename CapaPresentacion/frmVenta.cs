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
    public partial class frmVenta : Form
    {

        int idCliente;
        int idExistencia;
        int idProveedor;

        int total;
        int neto;
        int iva;

        int stock_actual;
        int costo_producto;
        DateTime fechaUltimaCompra;

        int nVenta;

        bool nuevoCliente = true;
        

        N_Existencias objNExistencias = new N_Existencias();
        N_Kardex negocioKardex = new N_Kardex();
        N_LibroVentas negociolibroVentas = new N_LibroVentas();
        N_Cliente objNegocioCliente = new N_Cliente();
        N_Indice negocioIndice = new N_Indice();


        E_kardex entidadKardex = new E_kardex();
        E_LibroVentas entidadLibroVentas = new E_LibroVentas();
        E_Cliente entidadCliente = new E_Cliente();
        E_Existencia entidadExistencia = new E_Existencia();



        public frmVenta()
        {
            InitializeComponent();

            tablaGlosa.ClearSelection();
            this.dateCompra.Value = DateTime.Now;

            tablaGlosa.Columns["IdProveedorGlosa"].Visible = false;
            tablaGlosa.Columns["StockActualGlosa"].Visible = false;
            tablaGlosa.Columns["FechaUltimaCompraGlosa"].Visible = false;

        }

        private void limpiarCajas()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtEmail.Text = "";
            txtContacto.Text = "";

        }

        private void limpiarCajasGlosa()
        {
            txtNombreExistencia.Text = "";
            txtCodigo.Text = "";
            txtStock.Value = 0;
            txtPrecio.Text = "";
        }

        private void limpiarCajasProducto()
        {
            txtCodigo.Text = "";
            txtNombreExistencia.Text = "";
            txtPrecio.Text = "";
            txtStock.Value = 1;
        }





        private void frmVenta_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscarRut_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBuscarRut.Text.Length <= 0)
            {
                limpiarCajas();
            }
            else
            {
                
                List<E_Cliente> resultado = objNegocioCliente.ListandoClientes(txtBuscarRut.Text);
                if (resultado.Count > 0)
                {
                    idCliente = resultado[0].Idcliente;
                    txtRut.Text = resultado[0].Rutcliente;
                    txtNombre.Text = resultado[0].Nombrecliente;
                    txtDireccion.Text = resultado[0].Direccioncliente;
                    txtCiudad.Text = resultado[0].Ciudadcliente;
                    txtEmail.Text = resultado[0].Emailcliente;
                    txtContacto.Text = resultado[0].Contactocliente;

                    nuevoCliente = false;
                }
                else if (resultado.Count <= 0)
                {
                    nuevoCliente = true;

                    limpiarCajas();

                    
                }

            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text.Length <= 0)
            {
                //Limpiar caja de productos
                limpiarCajasProducto();
            }
            else
            {
                List<E_Existencia> resultado = objNExistencias.BuscandoExistenciaPorCodigo(txtBuscarProducto.Text);
                if (resultado.Count > 0)
                {
                    idExistencia = resultado[resultado.Count-1].Idexistencias;
                    txtCodigo.Text = resultado[resultado.Count-1].Codigoexistencias;
                    txtNombreExistencia.Text = resultado[resultado.Count-1].Nombreexistencias;
                    txtPrecio.Text = resultado[resultado.Count-1].Precioexistencias.ToString();
                    txtStockActual.Text = resultado[resultado.Count-1].Stockexistencias.ToString();
                    idProveedor = resultado[resultado.Count-1].Idproveedorexistencias;
                    fechaUltimaCompra = resultado[resultado.Count-1].Fechaultimacompraexistencias;
                    costo_producto = resultado[resultado.Count-1].Costoexistencias;

                }
                else if (resultado.Count <= 0)
                {
                    //Limpiar caja de productos
                    limpiarCajasProducto();
                  
                }
            }
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombreExistencia.Text != "" && txtStock.Text != ""  && txtPrecio.Text != "")
            {

                List<E_Existencia> Listar = new List<E_Existencia>();

                Listar.Add(new E_Existencia
                {
                    Nombreexistencias = txtNombreExistencia.Text,
                    Codigoexistencias = txtCodigo.Text,
                    Stockexistencias = Convert.ToInt32(txtStock.Value),
                    Fechaultimacompraexistencias = dateCompra.Value,
                    Precioexistencias = Convert.ToInt32(txtPrecio.Text),

                });


                int RowID = tablaGlosa.Rows.Add();

                DataGridViewRow Row = tablaGlosa.Rows[RowID];
                
                Row.Cells["IdExistenciaGlosa"].Value = idExistencia;
                Row.Cells["Nombre"].Value = txtNombreExistencia.Text.ToString().ToUpper();
                Row.Cells["Codigo"].Value = txtCodigo.Text.ToString();
                Row.Cells["StockActualGlosa"].Value = Convert.ToInt32(txtStockActual.Text);
                Row.Cells["Stock"].Value = Convert.ToInt32(txtStock.Value);
                Row.Cells["Precio"].Value = Convert.ToInt32(txtPrecio.Text);
                Row.Cells["IdProveedorGlosa"].Value = idProveedor;
                Row.Cells["FechaUltimaCompraGlosa"].Value = fechaUltimaCompra;
                Row.Cells["CostoGlosa"].Value = costo_producto;
                Row.Cells["totalGlosa"].Value = Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtStock.Value);



                total = total + (Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtStock.Value));
                iva = Convert.ToInt32(total * 0.19);
                neto = total - iva;


                
                txtNeto.Text = neto.ToString();
                txtIva.Text = iva.ToString();
                txtTotal.Text = total.ToString();

                limpiarCajasGlosa();


            }

            limpiarCajasProducto();
        }

        private void tablaGlosa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaGlosa.Rows[e.RowIndex].Cells["eliminarFila"].Selected)
            {

                int precio_unitario = Convert.ToInt32(tablaGlosa.Rows[e.RowIndex].Cells["Precio"].Value);
                int cantidad_comprada = Convert.ToInt32(tablaGlosa.Rows[e.RowIndex].Cells["Stock"].Value);

                total = total - (precio_unitario * cantidad_comprada);
                iva = Convert.ToInt32(total * 0.19);
                neto = total - iva;

                txtTotal.Text = total.ToString();
                txtNeto.Text = neto.ToString();
                txtIva.Text = iva.ToString();


                tablaGlosa.Rows.Remove(tablaGlosa.Rows[e.RowIndex]);

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int numeroVenta = 0;

            //boleta o factura??

            //boleta obtengo numero boleta
            //factura obtengo numero factura 

            if(txtTipoDoc.Text == "FACTURA")
            {
                numeroVenta = negocioIndice.obtenerNumeroFactura();
            }else if(txtTipoDoc.Text == "BOLETA")
            {
                numeroVenta = negocioIndice.obtenerNumeroBoleta();
            }
            else
            {
                numeroVenta = 0;
            }

            try
            {
                foreach (DataGridViewRow row in tablaGlosa.Rows)
                {
                    if(row.Cells["Codigo"].Value != null)
                    {
                        //Añadir cliente 
                        if (nuevoCliente == true)
                        {
                            //añado cliente y capturo id

                            //MessageBox.Show("Se insetara un nuevo cliente rut: " + txtRut.Text );

                            entidadCliente.Nombrecliente = txtNombre.Text.ToUpper();
                            entidadCliente.Rutcliente = txtRut.Text;
                            entidadCliente.Direccioncliente = txtDireccion.Text;
                            entidadCliente.Ciudadcliente = txtCiudad.Text.ToUpper();
                            entidadCliente.Emailcliente = txtEmail.Text;
                            entidadCliente.Contactocliente = txtContacto.Text;

                            idCliente = objNegocioCliente.InsertandoCliente(entidadCliente);
  
                            
                        }

                        



                        //Actualizar kardex

                        entidadKardex.Codigokardex = row.Cells["Codigo"].Value.ToString();
                        entidadKardex.FechaKardex = dateCompra.Value;
                        entidadKardex.Tipodockardex = txtTipoDoc.Text.ToString();
                        entidadKardex.Numerokardex = numeroVenta.ToString();
                        entidadKardex.Ventakardex= Convert.ToInt32(row.Cells["Stock"].Value);
                        entidadKardex.PrecioKardex = (Convert.ToInt32(row.Cells["Precio"].Value) * Convert.ToInt32(row.Cells["Stock"].Value));
                        negocioKardex.InsertandoKardex(entidadKardex);

                        //Actualizar stock

                        entidadExistencia.Fechaultimacompraexistencias = Convert.ToDateTime(row.Cells["FechaUltimaCompraGlosa"].Value);
                        stock_actual = Convert.ToInt32(row.Cells["StockActualGlosa"].Value) - Convert.ToInt32(row.Cells["Stock"].Value);
                        entidadExistencia.Idexistencias = Convert.ToInt32(row.Cells["IdExistenciaGlosa"].Value);
                        entidadExistencia.Nombreexistencias = row.Cells["Nombre"].Value.ToString().ToUpper();
                        entidadExistencia.Stockexistencias = stock_actual;
                        entidadExistencia.Precioexistencias = Convert.ToInt32(row.Cells["Precio"].Value);
                        entidadExistencia.Costoexistencias = Convert.ToInt32(row.Cells["CostoGlosa"].Value);
                        entidadExistencia.Idproveedorexistencias = Convert.ToInt32(row.Cells["IdProveedorGlosa"].Value);
                        

                        objNExistencias.EditandoExistencia(entidadExistencia);
                        //MessageBox.Show("Producto Actualizado");


                    }


                }

                //Añadir venta al libro de venta

                entidadLibroVentas.Fechalibroventas = dateCompra.Value;
                entidadLibroVentas.Tipodoclibroventas = txtTipoDoc.Text.ToUpper();
                entidadLibroVentas.Netolibroventas = Convert.ToInt32(neto);
                entidadLibroVentas.Ivalibroventas = Convert.ToInt32(iva);
                entidadLibroVentas.Totallibroventas = Convert.ToInt32(txtTotal.Text);
                entidadLibroVentas.Metodopagolibroventas = txtFormaPago.Text.ToUpper();
                entidadLibroVentas.Idclientelibroventas = idCliente;
                entidadLibroVentas.Numerolibroventas = numeroVenta.ToString();

                negociolibroVentas.InsertandoVenta(entidadLibroVentas);


                MessageBox.Show("Se emitió el documento N° " + numeroVenta);

                limpiarCajas();
                limpiarCajasGlosa();
                limpiarCajasProducto();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            if(txtStock.Value > Convert.ToInt32(txtStockActual.Text))
            {
                MessageBox.Show("No hay sufienciente stock");
            }
        }
    }
}
