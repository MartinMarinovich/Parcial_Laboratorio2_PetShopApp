using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace PetShopForms
{
    public partial class FrmVentas : Form
    {
        Cliente cliente = null;
        Compra compra;
        List<Producto> listaAux = new List<Producto>();

        bool pedidoTerminado = false;
        bool clienteseleccionado = false;
        float auxMonto = 0;
        public FrmVentas()
        {

            InitializeComponent();


        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            lbl_Errores.Visible = false;
            foreach (Producto item in Local.Stock)
            {
                lstb_Productos.Items.Add(item.DatosProducto());

            }
            foreach (Cliente item in Local.Clientela)
            {
                lstb_Clientes.Items.Add(item.Datos());

            }


        }

        private void btn_AltaCliente_Click(object sender, EventArgs e)
        {
            if (Local.ValidarString(txtb_Nombre.Text) && Local.ValidarString(txtb_Apellido.Text) && Local.ValidarStringNumerico(txtb_Dni.Text))
            {
                cliente = new Cliente(txtb_Nombre.Text, txtb_Apellido.Text, double.Parse(txtb_Dni.Text));
                Local.Clientela.Add(cliente);
                ActualizarCampos();
            }
            else
            {
                lbl_Errores.Visible = true;
            }
            LimpiarCampos();
        }

        private void btn_RealizarVenta_Click(object sender, EventArgs e)
        {
            int auxCant = 0;
            

            if (pedidoTerminado == true)
            {
                listaAux = new List<Producto>();
                pedidoTerminado = false;
            }

            if (Local.ValidarStringNumerico(txt_CantidadDeProducto.Text) && lstb_Productos.SelectedItem != null)
            {
                lstb_Clientes.Enabled = false;
                auxCant = int.Parse(txt_CantidadDeProducto.Text);

                if (clienteseleccionado == false)
                {
                    foreach (Cliente item in Local.Clientela)
                    {
                        if (item.Datos() == lstb_Clientes.SelectedItem.ToString())
                        {
                            cliente = item;
                            clienteseleccionado = true;
                        }

                    }
                }

                if (clienteseleccionado == true)
                {

                    for (int i = 0; i < auxCant; i++)
                    {
                        foreach (Producto item in Local.Stock)
                        {
                            if (item.DatosProducto() == lstb_Productos.SelectedItem.ToString())
                            {
                                listaAux.Add(item);
                                auxMonto = auxMonto + item.Precio;
                            }
                        }
                    }

                    if (listaAux != null)
                    {
                        foreach (Producto item in listaAux)
                        {
                            lstb_HistorialVentas.Items.Add(item.DatosProducto());
                        }
                    }
                    ActualizarCampos();
                }
                else
                {
                    lbl_Errores.Text = "Error, seleccione un cliente para realizar la venta";
                }

            }
            else
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Debe seleccionar un producto, la cantidad del mismo y un cliente para realizar la venta";
            }
            LimpiarCampos();
        }
        private void btn_FinalizarVenta_Click(object sender, EventArgs e)
        {
            pedidoTerminado = true;

            compra = new Compra(cliente, auxMonto, listaAux);
            Local.Ventas.Add(compra);
            lstb_Clientes.Enabled = true;
            MessageBox.Show("Pedido finalizado");
            LimpiarCampos();
        }



        protected void ActualizarCampos()
        {
            if (lstb_Clientes.Items.Count != 0)
            {
                lstb_Clientes.Items.Clear();

                foreach (Cliente item in Local.Clientela)
                {
                    lstb_Clientes.Items.Add(item.Datos());

                }
            }

            if (lstb_Productos.Items.Count != 0)
            {
                lstb_Productos.Items.Clear();

                foreach (Producto item in Local.Stock)
                {
                    lstb_Productos.Items.Add(item.DatosProducto());

                }
            }



            lstb_HistorialVentas.Items.Clear();
            lstb_HistorialVentas.Items.Add("*** PEDIDO EN CURSO ***");
            lstb_HistorialVentas.Items.Add("");
            lstb_HistorialVentas.Items.Add("Nombre        Apellido        DNI          Dinero");
            lstb_HistorialVentas.Items.Add(cliente.Datos());
            lstb_HistorialVentas.Items.Add("");
            lstb_HistorialVentas.Items.Add("Producto        Descripcion        Precio          Dinero");
            foreach (Producto item in listaAux)
            {
                lstb_HistorialVentas.Items.Add(item.DatosProducto());

            }

        }

        private void FrmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LimpiarCampos()
        {
            txtb_Apellido.Text = string.Empty;
            txtb_Dni.Text = string.Empty;
            txtb_Nombre.Text = string.Empty;
            txt_CantidadDeProducto.Text = string.Empty;

        }
    }
}
