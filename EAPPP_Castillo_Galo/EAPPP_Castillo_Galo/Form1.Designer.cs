namespace EAPPP_Castillo_Galo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvCatalogo = new System.Windows.Forms.ListView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.rbtnMostrador = new System.Windows.Forms.RadioButton();
            this.rbtnEntrega = new System.Windows.Forms.RadioButton();
            this.chkPostre = new System.Windows.Forms.CheckBox();
            this.chkServilletas = new System.Windows.Forms.CheckBox();
            this.lvPedido = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.grpEntrega.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCatalogo
            // 
            this.lvCatalogo.HideSelection = false;
            this.lvCatalogo.Location = new System.Drawing.Point(16, 75);
            this.lvCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvCatalogo.Name = "lvCatalogo";
            this.lvCatalogo.Size = new System.Drawing.Size(260, 381);
            this.lvCatalogo.TabIndex = 0;
            this.lvCatalogo.UseCompatibleStateImageBehavior = false;
            this.lvCatalogo.SelectedIndexChanged += new System.EventHandler(this.lvCatalogo_SelectedIndexChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(380, 75);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(132, 22);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(380, 124);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(132, 22);
            this.txtProducto.TabIndex = 2;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(599, 129);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 22);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // rbtnMostrador
            // 
            this.rbtnMostrador.AutoSize = true;
            this.rbtnMostrador.Location = new System.Drawing.Point(16, 41);
            this.rbtnMostrador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMostrador.Name = "rbtnMostrador";
            this.rbtnMostrador.Size = new System.Drawing.Size(146, 20);
            this.rbtnMostrador.TabIndex = 4;
            this.rbtnMostrador.TabStop = true;
            this.rbtnMostrador.Text = "Retiro en mostrador";
            this.rbtnMostrador.UseVisualStyleBackColor = true;
            this.rbtnMostrador.CheckedChanged += new System.EventHandler(this.rbtnMostrador_CheckedChanged);
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.Location = new System.Drawing.Point(201, 41);
            this.rbtnEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(171, 20);
            this.rbtnEntrega.TabIndex = 5;
            this.rbtnEntrega.TabStop = true;
            this.rbtnEntrega.Text = "Entrega en aula (+$0,50)";
            this.rbtnEntrega.UseVisualStyleBackColor = true;
            this.rbtnEntrega.CheckedChanged += new System.EventHandler(this.rbtnEntrega_CheckedChanged);
            // 
            // chkPostre
            // 
            this.chkPostre.AutoSize = true;
            this.chkPostre.Location = new System.Drawing.Point(8, 39);
            this.chkPostre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPostre.Name = "chkPostre";
            this.chkPostre.Size = new System.Drawing.Size(154, 20);
            this.chkPostre.TabIndex = 6;
            this.chkPostre.Text = "Postre del día (+1.00)";
            this.chkPostre.UseVisualStyleBackColor = true;
            this.chkPostre.CheckedChanged += new System.EventHandler(this.chkPostre_CheckedChanged);
            // 
            // chkServilletas
            // 
            this.chkServilletas.AutoSize = true;
            this.chkServilletas.Location = new System.Drawing.Point(205, 39);
            this.chkServilletas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkServilletas.Name = "chkServilletas";
            this.chkServilletas.Size = new System.Drawing.Size(153, 20);
            this.chkServilletas.TabIndex = 7;
            this.chkServilletas.Text = "Servilletas/Cubiertos";
            this.chkServilletas.UseVisualStyleBackColor = true;
            this.chkServilletas.CheckedChanged += new System.EventHandler(this.chkServilletas_CheckedChanged);
            // 
            // lvPedido
            // 
            this.lvPedido.HideSelection = false;
            this.lvPedido.Location = new System.Drawing.Point(771, 47);
            this.lvPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPedido.Name = "lvPedido";
            this.lvPedido.Size = new System.Drawing.Size(279, 395);
            this.lvPedido.TabIndex = 8;
            this.lvPedido.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregar.Location = new System.Drawing.Point(293, 415);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar Ítem";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Brown;
            this.btnQuitar.Location = new System.Drawing.Point(429, 415);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(100, 28);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpiar.Location = new System.Drawing.Point(576, 415);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 527);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(44, 16);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "label1";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(767, 466);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Catálogo de Productos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(316, 84);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 16);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Producto:";
            // 
            // grpEntrega
            // 
            this.grpEntrega.Controls.Add(this.rbtnMostrador);
            this.grpEntrega.Controls.Add(this.rbtnEntrega);
            this.grpEntrega.Location = new System.Drawing.Point(285, 169);
            this.grpEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEntrega.Size = new System.Drawing.Size(477, 85);
            this.grpEntrega.TabIndex = 17;
            this.grpEntrega.TabStop = false;
            this.grpEntrega.Text = "Modalidad de Atención";
            // 
            // grpExtras
            // 
            this.grpExtras.Controls.Add(this.chkPostre);
            this.grpExtras.Controls.Add(this.chkServilletas);
            this.grpExtras.Location = new System.Drawing.Point(285, 289);
            this.grpExtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExtras.Size = new System.Drawing.Size(477, 79);
            this.grpExtras.TabIndex = 18;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Extras del Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(767, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Detalles del Pedido:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(521, 133);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.grpEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvPedido);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lvCatalogo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCatalogo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.RadioButton rbtnMostrador;
        private System.Windows.Forms.RadioButton rbtnEntrega;
        private System.Windows.Forms.CheckBox chkPostre;
        private System.Windows.Forms.CheckBox chkServilletas;
        private System.Windows.Forms.ListView lvPedido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidad;
    }
}

