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
    public partial class FrmMenuPrincipal : Form
    {

        FrmEmpleados formEmpleados;
        FrmStock formStock;
        FrmVentas formVentas;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void btn_Empleados_Click_1(object sender, EventArgs e)
        {
            formEmpleados = new FrmEmpleados();
            formEmpleados.BackColor = Color.PowderBlue;
            formEmpleados.Show();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            formStock = new FrmStock();
            formStock.BackColor = Color.PowderBlue;
            formStock.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            formVentas = new FrmVentas();
            formVentas.BackColor = Color.PowderBlue;
            formVentas.Show();
            
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}