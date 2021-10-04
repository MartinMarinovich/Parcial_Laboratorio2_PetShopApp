using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace PetShopForms
{
    public partial class FrmEmpleados : Form
    {
        Empleado empleado;
        public FrmEmpleados()
        {
            InitializeComponent();



        }

        private void FrmEmpleados_Load(object sender, System.EventArgs e)
        {
            foreach (Usuario item in Local.Nomina)
            {
                if (typeof(Empleado) == item.GetType())
                {
                    lstb_Nomina.Items.Add(item.Datos());
                }
            }

            ActualizarNominaLstbx();
        }

        private void btn_AltaEmpleado_Click(object sender, System.EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtb_NombreAlta.Text) && !string.IsNullOrEmpty(txtb_ApellidoALta.Text)
             && !string.IsNullOrEmpty(txb_Usuario.Text) && !string.IsNullOrEmpty(txtb_Contraseña.Text)
             && !string.IsNullOrEmpty(txtb_DniAlta.Text) && !string.IsNullOrEmpty(txtb_SueldoAlta.Text))
            {
                empleado = new(txtb_NombreAlta.Text, txtb_ApellidoALta.Text, double.Parse(txtb_DniAlta.Text), float.Parse(txtb_SueldoAlta.Text)
                    , txb_Usuario.Text, txtb_Contraseña.Text);

                Local.Nomina.Add(empleado);
                ActualizarNominaLstbx();

            }
            else
            {
                MessageBox.Show("Error, debe completar los campos para cargar un empleado");
            }



        }


        private void btn_ModifcarEmp_Click(object sender, System.EventArgs e)
        {
            Empleado auxEmp = null;
            int indice = 0;
            if (!string.IsNullOrEmpty(txtb_NombreModif.Text) && !string.IsNullOrEmpty(txtb_ApellidoModif.Text)
                && !string.IsNullOrEmpty(txtb_SueldoModif.Text) && !string.IsNullOrEmpty(txtb_DniModif.Text) && lstb_Nomina.SelectedItem != null)
            {

                foreach (Usuario item in Local.Nomina)
                {
                    if (typeof(Empleado) == item.GetType())
                    {
                        if (item.Datos() == lstb_Nomina.SelectedItem.ToString())
                        {
                            auxEmp = (Empleado)item;
                            indice = Local.Nomina.IndexOf(item);

                        }
                    }

                }
                Local.Nomina.RemoveAt(indice);
                Empleado.MoficarEmpleado(auxEmp, txtb_NombreModif.Text, txtb_ApellidoModif.Text, double.Parse(txtb_DniModif.Text), float.Parse(txtb_SueldoModif.Text));
                Local.Nomina.Insert(indice, auxEmp);
                ActualizarNominaLstbx();
            }
            else
            {
                MessageBox.Show("Error, debe completar los campos para modificar un empleado");
            }

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


            }
            else
            {
                MessageBox.Show("Error, valor invalido");
            }
        }

        protected void ActualizarNominaLstbx()
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
    }
}
