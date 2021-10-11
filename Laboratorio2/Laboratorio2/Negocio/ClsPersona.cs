using Laboratorio2.Data;
using Laboratorio2.Reposity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2.Negocio
{
    class ClsPersona : ClsRPersona
    {
        public void Create(persona per)
        {
            if (per.edadPersona >= 18)
            {
                Guardar(per);
            }
            else
            {
                MessageBox.Show("No es mayor de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public List<persona> ListMostrar()
        {
            List<persona> list = listOfDataOfTablePersona();
            return list;
        }


    }
}
