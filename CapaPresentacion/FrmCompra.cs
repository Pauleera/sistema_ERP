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
    
    public partial class FrmCompra : Form
    {
        private int idproveedor;
        private int idexistencia;

        private bool editarse = false;

        private int stock_actual = 0;

        private int total = 0;


        List<E_Existencia> Listar = new List<E_Existencia>();

        N_Proveedor objNegocio = new N_Proveedor();
        N_Existencias objNExistencias = new N_Existencias();
        N_Kardex negocioKardex = new N_Kardex();


        E_Existencia objEntidad = new E_Existencia();
        E_kardex entidadKardex = new E_kardex();
        
      
        public FrmCompra()
        {
            InitializeComponent();

            tablaGlosa.ClearSelection();

            txtTipoDoc.Text = "FACTURA";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void limpiarCajas()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtEmail.Text = "";
            txtContacto.Text = "";
            txtNumero.Text = "";
            txtTipoDoc.Text = "FACTURA";
            txtBuscarRut.Text = "";
            tablaGlosa.DataSource = "";

        }

        private void limpiarCajasGlosa()
        {
            txtNombreExistencia.Text = "";
            txtCodigo.Text = "";
            txtStock.Value = 1;
            txtCosto.Text = "";
            txtPrecio.Text = "";
            txtBuscarProducto.Text = "";
        }

        private void limpiarCajasProducto()
        {
            txtCodigo.Text = "";
            txtNombreExistencia.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";
            txtStock.Value = 1;
            txtBuscarProducto.Text = "";
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
                    idproveedor = resultado[0].Idproveedor;
                    txtRut.Text = resultado[0].Rutproveedor;
                    txtNombre.Text = resultado[0].Nombreproveedor;
                    txtRazonSocial.Text = resultado[0].Razonsocialproveedor;
                    txtDireccion.Text = resultado[0].Direccionproveedor;
                    txtCiudad.Text = resultado[0].Ciudadproveedor;
                    txtEmail.Text = resultado[0].Emailproveedor;
                    txtContacto.Text = resultado[0].Contactoproveedor;
                }
                else if (resultado.Count <= 0)
                {
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
                List<E_Existencia> resultado = objNExistencias.ListandoExistencia(txtBuscarProducto.Text);
                if (resultado.Count > 0)
                {
                    idexistencia = resultado[0].Idexistencias;
                    txtCodigo.Text = resultado[0].Codigoexistencias;
                    txtNombreExistencia.Text = resultado[0].Nombreexistencias;
                    txtCosto.Text = resultado[0].Costoexistencias.ToString();
                    txtPrecio.Text = resultado[0].Precioexistencias.ToString();

                    stock_actual = Convert.ToInt32(resultado[0].Stockexistencias);

                    editarse = true;
                }
                else if (resultado.Count <= 0)
                {
                    //Limpiar caja de productos
                    limpiarCajasProducto();
                }
            }
        }


        private void txtNombreExistencia_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnIngresarExistencia_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text != "" && txtNombreExistencia.Text != "" && txtStock.Text != "" && txtCosto.Text != "" && txtPrecio.Text != "")
            {

                List<E_Existencia> Listar = new List<E_Existencia>();



                Listar.Add(new E_Existencia
                {
                    Nombreexistencias = txtNombreExistencia.Text,
                    Codigoexistencias = txtCodigo.Text,
                    Stockexistencias = Convert.ToInt32(txtStock.Value),
                    Fechaultimacompraexistencias = dateCompra.Value,
                    Costoexistencias = Convert.ToInt32(txtCosto.Text),
                    Precioexistencias = Convert.ToInt32(txtPrecio.Text),
                    Idproveedorexistencias = idproveedor

                });



                int RowID = tablaGlosa.Rows.Add();

                DataGridViewRow Row = tablaGlosa.Rows[RowID];

                Row.Cells["IdExistenciaGlosa"].Value = idexistencia;
                Row.Cells["Nombre"].Value = txtNombreExistencia.Text.ToString().ToUpper();
                Row.Cells["Codigo"].Value = txtCodigo.Text.ToString();
                Row.Cells["Stock"].Value = Convert.ToInt32(txtStock.Value);
                Row.Cells["StockActual"].Value = stock_actual;
                Row.Cells["Costo"].Value = Convert.ToInt32(txtCosto.Text);
                Row.Cells["Precio"].Value = Convert.ToInt32(txtPrecio.Text);
                //Row.Cells["Id"].Value = idproveedor;

                total = total + (Convert.ToInt32(txtCosto.Text) * Convert.ToInt32(txtStock.Value));

                txtTotal.Text = total.ToString();

                limpiarCajasGlosa();


            }

            limpiarCajasProducto();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {



            try
            {

                foreach (DataGridViewRow row in tablaGlosa.Rows)
                {

                    if(row.Cells["Codigo"].Value != null)
                    {

                        if(editarse == false)
                        {
                            objEntidad.Codigoexistencias = row.Cells["Codigo"].Value.ToString();
                            objEntidad.Nombreexistencias = row.Cells["Nombre"].Value.ToString().ToUpper();
                            objEntidad.Stockexistencias = Convert.ToInt32(row.Cells["Stock"].Value);
                            objEntidad.Precioexistencias = Convert.ToInt32(row.Cells["Precio"].Value);
                            objEntidad.Costoexistencias = Convert.ToInt32(row.Cells["Costo"].Value);
                            objEntidad.Fechaultimacompraexistencias = dateCompra.Value;
                            objEntidad.Idproveedorexistencias = idproveedor;

                            objNExistencias.InsertandoExistencia(objEntidad);

                            MessageBox.Show("Nuevo productos han sido agregados");
                        }
                        else
                        { //Actualizar stock

                            stock_actual = Convert.ToInt32(row.Cells["StockActual"].Value) + Convert.ToInt32(row.Cells["Stock"].Value);

                            objEntidad.Idexistencias = Convert.ToInt32(row.Cells["IdExistenciaGlosa"].Value);
                            objEntidad.Nombreexistencias = row.Cells["Nombre"].Value.ToString().ToUpper();
                            objEntidad.Stockexistencias = stock_actual;
                            objEntidad.Precioexistencias = Convert.ToInt32(row.Cells["Precio"].Value);
                            objEntidad.Costoexistencias = Convert.ToInt32(row.Cells["Costo"].Value);
                            objEntidad.Fechaultimacompraexistencias = dateCompra.Value;
                            objEntidad.Idproveedorexistencias = idproveedor;

                            objNExistencias.EditandoExistencia(objEntidad);
                            MessageBox.Show("Producto Actualizado");

                        }


                        entidadKardex.Codigokardex = row.Cells["Codigo"].Value.ToString();
                        entidadKardex.FechaKardex = dateCompra.Value;
                        entidadKardex.Tipodockardex = txtTipoDoc.Text.ToString();
                        entidadKardex.Numerokardex = txtNumero.Text.ToString();
                        entidadKardex.Comprakarex = Convert.ToInt32(row.Cells["Stock"].Value);
                        entidadKardex.PrecioKardex= -(Convert.ToInt32(row.Cells["Costo"].Value) * Convert.ToInt32(row.Cells["Stock"].Value));
                        negocioKardex.InsertandoKardex(entidadKardex);

                        limpiarCajas();
                        limpiarCajasProducto();
                        limpiarCajasGlosa();

                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

                
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tablaGlosa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaGlosa.Rows[e.RowIndex].Cells["eliminarFila"].Selected)
            {
               

                int precio_unitario = Convert.ToInt32(tablaGlosa.Rows[e.RowIndex].Cells["Costo"].Value);
                int cantidad_comprada = Convert.ToInt32(tablaGlosa.Rows[e.RowIndex].Cells["Stock"].Value);

                total = total - (precio_unitario * cantidad_comprada);

                txtTotal.Text = total.ToString();

                tablaGlosa.Rows.Remove(tablaGlosa.Rows[e.RowIndex]);

            }

        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text.Length < 13 && txtCodigo.Text.Length >= 1)
            {
                MessageBox.Show("Código debe ser de 13 digitos");
                txtCodigo.Focus();
            }
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            if(txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Numero de documento vacio");
                txtNumero.Focus();
            }
        }
    }
}
