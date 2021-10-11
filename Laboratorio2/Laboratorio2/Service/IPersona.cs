using Laboratorio2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.Service
{
    interface IPersona
    {
        //CRUD
        //Es un metodo para guardar
        //c
        void Guardar(persona persona);

        List<persona> listOfDataOfTablePersona();
    }
}
