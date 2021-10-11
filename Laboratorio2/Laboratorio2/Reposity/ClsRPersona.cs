using Laboratorio2.Data;
using Laboratorio2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2.Reposity
{
    class ClsRPersona : IPersona
    {
        public void Guardar(persona persona)
        {
            using (almacendepersonasEntities ConexionBd = new almacendepersonasEntities())
            {
                try
                {
                    ConexionBd.persona.Add(persona);
                    ConexionBd.SaveChanges();

                    MessageBox.Show("Se ha registrado exitosamente");

                }catch(Exception ex)
                {
                    MessageBox.Show("Error de base de datos");
                }
            }
        }

        public List<persona> listOfDataOfTablePersona()
        {
            using (almacendepersonasEntities ConexionBd = new almacendepersonasEntities())
            {
                List<persona> ListPerson = ConexionBd.persona.ToList();
                return ListPerson;
            }
        }
                
    }
}
