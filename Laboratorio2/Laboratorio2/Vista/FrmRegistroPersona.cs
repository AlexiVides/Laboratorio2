using Laboratorio2.Data;
using Laboratorio2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2.Vista
{
    public partial class FrmRegistroPersona : Form
    {
        public FrmRegistroPersona()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                persona persona = new persona();
                persona.nombrePersona = textNombre.Text;
                persona.edadPersona = Convert.ToInt32(textEdad.Text);
                persona.descripcionPersona = textDescripcion.Text;

                ClsPersona clsPersona = new ClsPersona();
                clsPersona.Create(persona);

                textNombre.Clear();
                textEdad.Clear();
                textDescripcion.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Llenar los campos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrMostrarRegistros fr = new FrMostrarRegistros();
            fr.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("¿Desea abandonar la ventana?", "Salir del Programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opc == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
