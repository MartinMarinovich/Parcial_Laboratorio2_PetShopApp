using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace PetShopForms
{
    public partial class FrmEmpleados : Form
    {
        Empleado empleado;
        FrmABM abm;
        int controlador = 0;
        public FrmEmpleados()
        {
            InitializeComponent();     
        }

        private void FrmEmpleados_Load(object sender, System.EventArgs e)
        {
            abm = new FrmABM(controlador);
            abm.MdiParent = this;
            abm.BackColor = Color.PowderBlue;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Red;
                }
            }
          
            foreach (Usuario item in Local.Nomina)
            {
                lstb_Nomina.Items.Add(item.Datos());  
            }

            btn_BajaEmpleado.ForeColor = Color.Red;
           
            ActualizarNominaLstbx();
        }


        private void btn_BajaEmpleado_Click(object sender, System.EventArgs e)
        {
            int aux = 0;
            int indice = -1;

            if (txtb_IdBaja.Text != null && int.TryParse(txtb_IdBaja.Text, out aux))
            {

                foreach (Usuario item in Local.Nomina)
                {
                    if (typeof(Empleado) == item.GetType())
                    {
                        empleado = (Empleado)item;

                        if (empleado.Id == aux)
                        {
                            if (MessageBox.Show($"Desea elimiar a {item.Nombre} {item.Apellido}?",
                                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                indice = Local.Nomina.IndexOf(item);
                            }
                            else
                            {
                                MessageBox.Show("Baja cancelada");
                            }
                        }

                    }
                }
                
                if (indice == -1)
                {

                    MessageBox.Show("No existe un empleado con esa ID");
                }
                else
                {
                    Local.Nomina.RemoveAt(indice);
                    txtb_IdBaja.Text = string.Empty;

                    ActualizarNominaLstbx();
                }

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error, valor invalido");
            }
        }

        public void ActualizarNominaLstbx()
        {
            if (lstb_Nomina.Items.Count != 0)
            {
                lstb_Nomina.Items.Clear();

                foreach (Usuario item in Local.Nomina)
                {
                    if (typeof(Empleado) == item.GetType())
                    {
                        lstb_Nomina.Items.Add(item.Datos());
                        
                    }
                }
                
            }
            
        }

        private void FrmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"Desea salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void LimpiarCampos()
        {
            /*
            txb_Usuario.Text = string.Empty;
            txtb_ApellidoALta.Text = string.Empty;
            txtb_ApellidoModif.Text = string.Empty;
            txtb_Contraseña.Text = string.Empty;
            txb_Usuario.Text = string.Empty;
            txtb_NombreAlta.Text = string.Empty;
            txtb_NombreModif.Text = string.Empty;
            txtb_DniAlta.Text = string.Empty;
            txtb_DniModif.Text = string.Empty;
            txtb_IdBaja.Text = string.Empty;
            txtb_SueldoAlta.Text = string.Empty;
            txtb_SueldoModif.Text = string.Empty;
            */
        }

        private void btn_AltaEmpleado_Click(object sender, System.EventArgs e)
        {
            controlador = 1;
            abm = new FrmABM(controlador);
            abm.Show();
        }

        private void btn_ModificarEmpleado_Click(object sender, System.EventArgs e)
        {
            controlador = 2;
            abm = new FrmABM(controlador);
            
            abm.Show();
        }
    }

}
