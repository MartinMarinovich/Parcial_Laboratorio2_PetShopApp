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
    public partial class FrmABM : Form
    {
        Empleado empleado;
        List<Empleado> listaux;
        int controlador = 0;
        public FrmABM(int aux)
        {
            InitializeComponent();
            //empleado = aux;
            controlador = aux;
        }

        public void btn_AltaEmpleado_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtb_NombreAlta.Text) && !string.IsNullOrEmpty(txtb_ApellidoALta.Text)
            && !string.IsNullOrEmpty(txb_Usuario.Text) && !string.IsNullOrEmpty(txtb_Contraseña.Text)
            && !string.IsNullOrEmpty(txtb_DniAlta.Text) && !string.IsNullOrEmpty(txtb_SueldoAlta.Text))
            {
                listaux = new List<Empleado>();
                empleado = new(txtb_NombreAlta.Text, txtb_ApellidoALta.Text, double.Parse(txtb_DniAlta.Text), float.Parse(txtb_SueldoAlta.Text)
                    , txb_Usuario.Text, txtb_Contraseña.Text);

                listaux.Add(empleado);
                Local.Nomina.AddRange(listaux);
                //ActualizarNominaLstbx();
            
              
                this.Close();

            }
            else
            {
                MessageBox.Show("Error, debe completar los campos para cargar un empleado");
            }

            //LimpiarCampos();

        }

        private void FrmABM_Load(object sender, EventArgs e)
        {
            if (controlador == 2)
            {
                LblUsuario.Visible = false;
                lblContraseña.Visible = false;
                btn_AltaEmpleado.Visible = false;

            }else
            {
                btn_ModificarEmpleado.Visible = false;
            }
        }
    }
}
     /*   private void btn_ModifcarEmp_Click(object sender, System.EventArgs e)
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
            LimpiarCampos();
        }*/
