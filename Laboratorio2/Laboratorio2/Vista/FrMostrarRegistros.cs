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
    public partial class FrMostrarRegistros : Form
    {
        public FrMostrarRegistros()
        {
            InitializeComponent();
        }

        private void FrMostrarRegistros_Load(object sender, EventArgs e)
        {
            ClsPersona clsPersona = new ClsPersona();
            var ok = clsPersona.ListMostrar();

            foreach(var iterrar in ok)
            {
                DGVMostrar.Rows.Add(iterrar.nombrePersona, iterrar.edadPersona, iterrar.descripcionPersona);
            }
        }

        FrmRegistroPersona FrmRegistroPersona = new FrmRegistroPersona();
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("¿Desea abandonar la ventana?", "Salir del Programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opc == DialogResult.OK)
            {
               Dispose();
            }
            
        }
    }
}
