using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

// Autor: Galo Castillo Vargas
// Asignatura: Diseño y Programación de Software
// Aplicación: Gestor de pedidos de cafetería
// Form1 corresponde al formulario principal de pedidos.

namespace EAPPP_Castillo_Galo
{
    public partial class Form1 : Form
    {
        private decimal precioSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Configura las listas y los valores iniciales.
        private void Form1_Load(object sender, EventArgs e)
        {
            lvCatalogo.View = View.Details;
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.GridLines = true;
            lvCatalogo.MultiSelect = false;
            lvCatalogo.HideSelection = false;

            lvCatalogo.Columns.Clear();
            lvCatalogo.Columns.Add("Producto", 220);
            lvCatalogo.Columns.Add("Precio", 90);

            // Catálogo oficial de la guía.
            lvCatalogo.Items.Clear();

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Empanada de queso", "$1.25" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Sánduche de pollo", "$2.50" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Bolón de verde mixto", "$2.25" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Humita tradicional", "$1.50" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Tostada con queso", "$1.00" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Café pasado", "$0.85" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Chocolate caliente", "$1.35" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Jugo natural (naranja/mora)", "$1.50" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Batido de fruta", "$2.00" }));

            lvCatalogo.Items.Add(
                new ListViewItem(new[] { "Botella de agua", "$0.75" }));

            // Configurar la lista del pedido.
            lvPedido.View = View.Details;
            lvPedido.FullRowSelect = true;
            lvPedido.GridLines = true;
            lvPedido.MultiSelect = false;
            lvPedido.HideSelection = false;

            lvPedido.Columns.Clear();
            lvPedido.Columns.Add("Producto", 220);
            lvPedido.Columns.Add("Cant.", 60);
            lvPedido.Columns.Add("Subtotal", 90);
            lvPedido.Items.Clear();

            txtCliente.Clear();
            txtProducto.ReadOnly = true;
            txtProducto.Clear();
            txtCantidad.Text = "1";

            rbtnMostrador.Checked = true;
            rbtnEntrega.Checked = false;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            // Permite limpiar aunque la cantidad sea inválida.
            btnLimpiar.CausesValidation = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto.";
        }

        // Toma el producto y su precio desde el catálogo.
        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatalogo.SelectedItems.Count == 0)
            {
                precioSeleccionado = 0;
                txtProducto.Clear();
                btnAgregar.Enabled = false;
                lblEstado.Text = "Estado: Seleccione un producto.";
                return;
            }

            ListViewItem fila = lvCatalogo.SelectedItems[0];

            string precioTexto = fila.SubItems[1].Text.Replace("$", "");

            // Los precios del catálogo usan punto decimal.
            bool precioValido = decimal.TryParse(
                precioTexto,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out precioSeleccionado);

            if (!precioValido)
            {
                txtProducto.Clear();
                btnAgregar.Enabled = false;
                lblEstado.Text = "Error: No se pudo leer el precio.";
                return;
            }

            txtProducto.Text = fila.SubItems[0].Text;

            ActualizarBotonAgregar();

            lblEstado.Text = "Seleccionado: "
                + txtProducto.Text
                + " ("
                + fila.SubItems[1].Text
                + ")";
        }

        // Habilita Quitar cuando existe una fila seleccionada.
        private void lvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnQuitar.Enabled = lvPedido.SelectedItems.Count > 0;
        }

        // Revisa producto y cantidad para habilitar Agregar.
        private void ActualizarBotonAgregar()
        {
            int cantidad;

            bool cantidadValida = int.TryParse(
                txtCantidad.Text, out cantidad);

            btnAgregar.Enabled =
                !string.IsNullOrWhiteSpace(txtProducto.Text)
                && cantidadValida
                && cantidad >= 1;
        }

        // Se ejecuta cuando cambia la cantidad.
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonAgregar();
        }

        // Se ejecuta cuando cambia el producto mostrado.
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonAgregar();
        }

        // Impide salir de cantidad si el dato es inválido.
        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad)
                || cantidad < 1)
            {
                e.Cancel = true;

                lblEstado.Text =
                    "Error: La cantidad debe ser un entero mayor o igual a 1.";

                txtCantidad.SelectAll();
            }
        }

        // Suma las filas y los extras en un único lugar.
        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (ListViewItem fila in lvPedido.Items)
            {
                // Tag conserva el subtotal como número decimal.
                decimal subtotal = (decimal)fila.Tag;
                total += subtotal;
            }

            if (rbtnEntrega.Checked)
            {
                total += 0.50m;
            }

            if (chkPostre.Checked)
            {
                total += 1.00m;
            }

            lblTotal.Text = "Total: $"
                + total.ToString("F2", CultureInfo.InvariantCulture);
        }

        // Actualiza el total al cambiar a mostrador.
        private void rbtnMostrador_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (rbtnMostrador.Checked)
            {
                lblEstado.Text =
                    "Opción aplicada: Retiro en mostrador ($0.00).";
            }
        }

        // Actualiza el recargo de entrega.
        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (rbtnEntrega.Checked)
            {
                lblEstado.Text =
                    "Opción aplicada: Entrega en aula (+$0.50).";
            }
        }

        // Actualiza el extra fijo de postre.
        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (chkPostre.Checked)
            {
                lblEstado.Text =
                    "Opción aplicada: Postre del día (+$1.00).";
            }
            else
            {
                lblEstado.Text = "Opción retirada: Postre del día.";
            }
        }

        // Informa sobre el extra sin costo.
        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (chkServilletas.Checked)
            {
                lblEstado.Text =
                    "Opción aplicada: Servilletas / Cubiertos ($0.00).";
            }
            else
            {
                lblEstado.Text =
                    "Opción retirada: Servilletas / Cubiertos.";
            }
        }

        // Valida los datos y agrega una fila al pedido.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lblEstado.Text = "Error: Ingrese el nombre del cliente.";
                MessageBox.Show("Ingrese el nombre del cliente.");
                txtCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProducto.Text)
                || lvCatalogo.SelectedItems.Count == 0)
            {
                lblEstado.Text = "Error: Seleccione un producto.";
                MessageBox.Show("Seleccione un producto del catálogo.");
                lvCatalogo.Focus();
                return;
            }

            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad)
                || cantidad < 1)
            {
                lblEstado.Text =
                    "Error: La cantidad debe ser un entero mayor o igual a 1.";

                txtCantidad.Focus();
                txtCantidad.SelectAll();
                return;
            }

            decimal subtotal = cantidad * precioSeleccionado;

            ListViewItem fila = new ListViewItem(txtProducto.Text);

            fila.SubItems.Add(cantidad.ToString());

            fila.SubItems.Add(
                "$" + subtotal.ToString(
                    "F2", CultureInfo.InvariantCulture));

            // Guardar el subtotal numérico para calcular el total.
            fila.Tag = subtotal;

            lvPedido.Items.Add(fila);

            ActualizarTotal();

            txtCantidad.Text = "1";

            lblEstado.Text = "Estado: Producto agregado al pedido.";
        }

        // Elimina la fila seleccionada y recalcula.
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count == 0)
            {
                lblEstado.Text =
                    "Estado: Seleccione un ítem del pedido para quitar.";
                return;
            }

            lvPedido.Items.Remove(lvPedido.SelectedItems[0]);

            btnQuitar.Enabled = lvPedido.SelectedItems.Count > 0;

            ActualizarTotal();

            lblEstado.Text = "Estado: Producto retirado del pedido.";
        }

        // Reinicia el pedido y sus opciones.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvPedido.Items.Clear();

            // Quitar la selección de las filas del catálogo.
            foreach (ListViewItem fila in lvCatalogo.Items)
            {
                fila.Selected = false;
            }

            precioSeleccionado = 0;

            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Text = "1";

            rbtnMostrador.Checked = true;
            rbtnEntrega.Checked = false;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            ActualizarTotal();

            lblEstado.Text = "Estado: Pedido reiniciado.";

            txtCliente.Focus();
        }

        // Métodos existentes asociados al diseñador.
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
        }
    }
}