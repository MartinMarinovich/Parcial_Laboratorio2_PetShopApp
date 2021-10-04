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
        Cliente cliente;
        Compra compra;
        Producto producto;
        List<Producto> listaAux = new List<Producto>();
        bool pedidoTerminado = false;
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
                ActualizarListaCliente();
            }
            else
            {
                lbl_Errores.Visible = true;
            }
        }

        private void btn_RealizarVenta_Click(object sender, EventArgs e)
        {
            int auxCant = 0;
            float auxMonto = 0;
            
            if (pedidoTerminado == true)
            {
                listaAux = new List<Producto>();
                pedidoTerminado = false;
            }

            if (lstb_Clientes.SelectedItem != null && Local.ValidarStringNumerico(txt_CantidadDeProducto.Text) && lstb_Productos.SelectedItem != null)
            {
                lstb_Clientes.Enabled = false;
                auxCant = int.Parse(txt_CantidadDeProducto.Text);
                foreach (Cliente item in Local.Clientela)
                {
                    if (item.Datos() == lstb_Clientes.SelectedItem.ToString())
                    {
                        cliente = item;
                    }

                }

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

                if (listaAux != null && cliente != null)
                {
                    compra = new Compra(cliente, auxMonto, listaAux);
                    Local.Ventas.Add(compra);
                    ActualizarListaVentas();
                }
            }
            else
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Debe seleccionar un producto, la cantidad del mismo y un cliente para realizar la compra";
            }
        }
        private void btn_FinalizarVenta_Click(object sender, EventArgs e)
        {
            pedidoTerminado = true;
            lstb_Clientes.Enabled = true;
            MessageBox.Show("Pedido finalizado");
        }
        protected void ActualizarListaVentas()
        {
            lstb_HistorialVentas.Items.Clear();

            foreach (Compra item in Local.Ventas)
            {
              lstb_HistorialVentas.Items.Add(item.Datos());
 
            }
        }

        protected void ActualizarListaProducto()
        {
            if (lstb_Productos.Items.Count != 0)
            {
                lstb_Productos.Items.Clear();

                foreach (Producto item in Local.Stock)
                {
                    lstb_Productos.Items.Add(item.DatosProducto());

                }
            }
        }


        protected void ActualizarListaCliente()
        {
            if (lstb_Clientes.Items.Count != 0)
            {
                lstb_Clientes.Items.Clear();

                foreach (Cliente item in Local.Clientela)
                {
                    lstb_Clientes.Items.Add(item.Datos());

                }
            }
        }

        private void FrmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
