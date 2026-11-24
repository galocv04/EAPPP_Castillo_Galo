using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EAPPP_Castillo_Galo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void rbtnMostrador_CheckedChanged(object sender, EventArgs e)
        {
            rbtnMostrador.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private decimal precioSeleccionado = 0;
        private void Form1_Load(object sender, EventArgs e)

        {
            
            // 1. Configurar el ListView al cargar el formulario
            lvCatalogo.View = View.Details;
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.GridLines = true;
            lvCatalogo.Columns.Clear();

            // Configuramos el tamaño de las columnas
            lvCatalogo.Columns.Add("Producto", 150);
            lvCatalogo.Columns.Add("Precio", 120);

            // 2. Configurar el TextBox como solo lectura
            txtProducto.ReadOnly = true;

            // 3. Cargar los productos y precios
            lvCatalogo.Items.Clear();

            lvCatalogo.Items.Add(new ListViewItem(new[] { "Empanada de Queso", "$1.00" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Sánduche de Pollo", "$2.50" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Bolón de Verde Mixto", "$2.25" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Humita Tradicional", "$1.25" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Tostada con Queso", "$1.50" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Café Pasado", "$1.00" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Jugo Natural (naranja/mora)", "$1.50" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Batido de Fruta", "$2.00" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Botella de agua", "$0.75" }));

            //Inicializar el formulario para las demas 
            btnAgregar.Enabled = false;
            chkServilletas.Checked = false;
            txtProducto.ReadOnly = true;
            rbtnEntrega.Checked = false;
            chkPostre.Checked = false;
            lblTotal.Text = "Total:$0.00";
            lblEstado.Text = "Estado:Seleccione un Producto";
        }

        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validamos si el usuario selecciono un item en el catalogo
            if (lvCatalogo.SelectedItems.Count > 0)
            {
                
                ListViewItem fila = lvCatalogo.SelectedItems[0];

                // 1. Tomamos el producto y precio de la fila elegida
                string producto = fila.SubItems[0].Text;
                string precioTexto = fila.SubItems[1].Text; // Ej: "$1.50"

                // Guardar valor numérico limpio (quita el signo $)
                decimal.TryParse(precioTexto.Replace("$", ""), out precioSeleccionado);

                // 2. Mostrar el nombre en txtProducto
                txtProducto.Text = producto;

                // 3. Habilitar btnAgregar si cantidad >= 1
                //btnAgregar.Enabled = (txtCantidad.Value >= 1);

                // 4. Actualizar lblEstado
                lblEstado.Text = $"Seleccionado: {producto} ({precioTexto})";
            }
            else
            {
                // Si se deselecciona la fila
                txtProducto.Clear();
                btnAgregar.Enabled = false;
                lblEstado.Text = "Seleccione un producto del catálogo.";
            }
        }


        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text)){
                MessageBox.Show("Ingrese el nombre del cliente para el pedido");

            }
            if (string.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto para el pedido");

            }
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Text = "1";
            rbtnMostrador.Enabled = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;
            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Pedido reiniciado";
        }
    }
}



