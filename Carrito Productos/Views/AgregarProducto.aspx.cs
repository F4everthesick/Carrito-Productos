using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Carrito_Productos.Models.ProductosTableAdapters;

namespace Carrito_Productos.Views
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            decimal costo = decimal.Parse(txtCosto.Text);
            byte[] imagenBytes = null;

            if (fileimagen.HasFile)
            {
                using (BinaryReader br = new BinaryReader(fileimagen.PostedFile.InputStream))
                {
                    imagenBytes = br.ReadBytes(fileimagen.PostedFile.ContentLength);
                }
            }

            productosTableAdapter productos = new productosTableAdapter();
            productos.Insert(nombre, cantidad, costo, imagenBytes);

            Response.Redirect("AgregarProducto.aspx");
        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            CargarProductos();  // Llama a CargarProductos solo cuando se hace clic en "Mostrar Productos"
        }

        private void CargarProductos()
        {
            productosTableAdapter productos = new productosTableAdapter();
            GridDatos.DataSource = productos.GetData();  // Obtiene los datos de la base de datos
            GridDatos.DataBind();  // Enlaza los datos al GridView
        }
    }
}