using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Indexers
{
    public class Empresa
    {
        public Empresa()
        {
            Empleados = new ColecciónEmpleados();
        }

        public string RazónSocial { get; set; }

        public ColecciónEmpleados Empleados { get; }

        public void AgregarEmpleado(Guid id, string curp, string nombre)
        {
            // TODO Validar CURP válido
            this.Empleados[id] = new Empleado() { CURP = curp, Nombre = nombre };
        }
    }
}
