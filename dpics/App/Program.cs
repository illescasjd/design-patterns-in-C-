using Base.Indexers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary based indexer:");
            var empresa = new Empresa();
            var id1 = Guid.NewGuid();
            empresa.AgregarEmpleado(id1, "CURP010101HHHCCC00", "David Illescas");
            Console.WriteLine("ID: {0}, CURP: {1}", id1, empresa.Empleados[id1].CURP);
            Console.ReadKey();
        }
    }
}
