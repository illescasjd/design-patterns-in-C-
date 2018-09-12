using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Indexers
{
    public class ColecciónEmpleados
    {
        internal ColecciónEmpleados()
        {
            e = new Dictionary<Guid, Empleado>();
        }

        private Dictionary<Guid, Empleado> e = new Dictionary<Guid, Empleado>();

        public Empleado this[Guid idEmpleado]
        {
            get
            {
                // validar acción
                if (e.ContainsKey(idEmpleado))
                    return e[idEmpleado];
                else
                    return null;
            }
            internal set
            {
                //business rule
                if (idEmpleado == Guid.Empty)
                    throw new Exception("El id de empleado no puede ser nulo o vacío.");

                //business rule
                if (value == null)
                    throw new Exception("El empleado no puede ser nulo.");

                // validar acción
                if (e.ContainsKey(idEmpleado))
                    // update
                    e[idEmpleado] = value;
                else
                    // add
                    e.Add(idEmpleado, value);
            }
        }
    }
}
