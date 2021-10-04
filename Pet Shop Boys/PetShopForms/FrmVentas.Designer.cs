
namespace PetShopForms
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lstb_HistorialVentas = new System.Windows.Forms.ListBox();
            this.txtb_Nombre = new System.Windows.Forms.TextBox();
            this.txt_CantidadDeProducto = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_Apellido = new System.Windows.Forms.TextBox();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstb_Productos = new System.Windows.Forms.ListBox();
            this.lstb_Clientes = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_Dni = new System.Windows.Forms.TextBox();
            this.btn_AltaCliente = new System.Windows.Forms.Button();
            this.lbl_Errores = new System.Windows.Forms.Label();
            this.btn_FinalizarVenta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVentas.Location = new System.Drawing.Point(536, 159);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(231, 41);
            this.lblVentas.TabIndex = 2;
            this.lblVentas.Text = "Historico de Ventas";
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.Location = new System.Drawing.Point(-2, 347);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(231, 23);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Listado de Productos";
            // 
            // lstb_HistorialVentas
            // 
            this.lstb_HistorialVentas.FormattingEnabled = true;
            this.lstb_HistorialVentas.ItemHeight = 15;
            this.lstb_HistorialVentas.Location = new System.Drawing.Point(536, 211);
            this.lstb_HistorialVentas.Name = "lstb_HistorialVentas";
            this.lstb_HistorialVentas.Size = new System.Drawing.Size(546, 409);
            this.lstb_HistorialVentas.TabIndex = 4;
            // 
            // txtb_Nombre
            // 
            this.txtb_Nombre.Location = new System.Drawing.Point(333, 75);
            this.txtb_Nombre.Name = "txtb_Nombre";
            this.txtb_Nombre.PlaceholderText = "Ingrese nombre del cliente";
            this.txtb_Nombre.Size = new System.Drawing.Size(164, 23);
            this.txtb_Nombre.TabIndex = 5;
            // 
            // txt_CantidadDeProducto
            // 
            this.txt_CantidadDeProducto.Location = new System.Drawing.Point(12, 197);
            this.txt_CantidadDeProducto.Name = "txt_CantidadDeProducto";
            this.txt_CantidadDeProducto.PlaceholderText = "Ingrese cantidad de producto";
            this.txt_CantidadDeProducto.Size = new System.Drawing.Size(164, 23);
            this.txt_CantidadDeProducto.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(-2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 23);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Centro de Ventas";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(333, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(333, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido";
            // 
            // txtb_Apellido
            // 
            this.txtb_Apellido.Location = new System.Drawing.Point(333, 159);
            this.txtb_Apellido.Name = "txtb_Apellido";
            this.txtb_Apellido.PlaceholderText = "Ingrese apellido del cliente";
            this.txtb_Apellido.Size = new System.Drawing.Size(164, 23);
            this.txtb_Apellido.TabIndex = 10;
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(12, 240);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(164, 38);
            this.btn_AgregarProducto.TabIndex = 12;
            this.btn_AgregarProducto.Text = "Agregar Producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_RealizarVenta_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(235, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleccione el producto";
            // 
            // lstb_Productos
            // 
            this.lstb_Productos.FormattingEnabled = true;
            this.lstb_Productos.ItemHeight = 15;
            this.lstb_Productos.Location = new System.Drawing.Point(-2, 411);
            this.lstb_Productos.Name = "lstb_Productos";
            this.lstb_Productos.Size = new System.Drawing.Size(515, 214);
            this.lstb_Productos.TabIndex = 14;
            // 
            // lstb_Clientes
            // 
            this.lstb_Clientes.FormattingEnabled = true;
            this.lstb_Clientes.ItemHeight = 15;
            this.lstb_Clientes.Location = new System.Drawing.Point(536, 38);
            this.lstb_Clientes.Name = "lstb_Clientes";
            this.lstb_Clientes.Size = new System.Drawing.Size(307, 109);
            this.lstb_Clientes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(333, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "DNI Cliente";
            // 
            // txtb_Dni
            // 
            this.txtb_Dni.Location = new System.Drawing.Point(333, 229);
            this.txtb_Dni.Name = "txtb_Dni";
            this.txtb_Dni.PlaceholderText = "Ingrese cantidad de producto";
            this.txtb_Dni.Size = new System.Drawing.Size(164, 23);
            this.txtb_Dni.TabIndex = 16;
            // 
            // btn_AltaCliente
            // 
            this.btn_AltaCliente.Location = new System.Drawing.Point(333, 291);
            this.btn_AltaCliente.Name = "btn_AltaCliente";
            this.btn_AltaCliente.Size = new System.Drawing.Size(164, 38);
            this.btn_AltaCliente.TabIndex = 18;
            this.btn_AltaCliente.Text = "Nuevo Cliente";
            this.btn_AltaCliente.UseVisualStyleBackColor = true;
            this.btn_AltaCliente.Click += new System.EventHandler(this.btn_AltaCliente_Click);
            // 
            // lbl_Errores
            // 
            this.lbl_Errores.BackColor = System.Drawing.Color.Red;
            this.lbl_Errores.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Errores.Location = new System.Drawing.Point(12, 39);
            this.lbl_Errores.Name = "lbl_Errores";
            this.lbl_Errores.Size = new System.Drawing.Size(187, 79);
            this.lbl_Errores.TabIndex = 19;
            this.lbl_Errores.Text = "Complete los campos correctamente para dar de alta un cliente";
            // 
            // btn_FinalizarVenta
            // 
            this.btn_FinalizarVenta.Location = new System.Drawing.Point(12, 291);
            this.btn_FinalizarVenta.Name = "btn_FinalizarVenta";
            this.btn_FinalizarVenta.Size = new System.Drawing.Size(164, 38);
            this.btn_FinalizarVenta.TabIndex = 20;
            this.btn_FinalizarVenta.Text = "Finalizar Pedido";
            this.btn_FinalizarVenta.UseVisualStyleBackColor = true;
            this.btn_FinalizarVenta.Click += new System.EventHandler(this.btn_FinalizarVenta_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-2, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(170, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(411, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(87, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tipo";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(310, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Precio";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1086, 623);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_FinalizarVenta);
            this.Controls.Add(this.lbl_Errores);
            this.Controls.Add(this.btn_AltaCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_Dni);
            this.Controls.Add(this.lstb_Clientes);
            this.Controls.Add(this.lstb_Productos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txt_CantidadDeProducto);
            this.Controls.Add(this.txtb_Nombre);
            this.Controls.Add(this.lstb_HistorialVentas);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblVentas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ListBox lstb_HistorialVentas;
        private System.Windows.Forms.TextBox txtb_Nombre;
        private System.Windows.Forms.TextBox txt_CantidadDeProducto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_Apellido;
        private System.Windows.Forms.Button btn_RealizarVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstb_Productos;
        private System.Windows.Forms.ListBox lstb_Clientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_Dni;
        private System.Windows.Forms.Button btn_AltaCliente;
        private System.Windows.Forms.Label lbl_Errores;
        private System.Windows.Forms.Button btn_FinalizarVenta;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}