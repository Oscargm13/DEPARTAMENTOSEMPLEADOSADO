using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPARTAMENTOSEMPLEADOSADO.Models
{
    public class Departamentos
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public List<string> Empleados {  get; set; }
    }
}
