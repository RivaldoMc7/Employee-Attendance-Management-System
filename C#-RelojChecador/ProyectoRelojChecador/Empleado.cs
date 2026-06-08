using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string puesto { get; set; }

        //CONTRUCTORES

        public Empleado() { }

        public Empleado(int id, string nombre, string apellidoPaterno,
                        string apellidoMaterno, int edad, string sexo,
                        string puesto)
        { 
            this.id = id;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.edad = edad;
            this.sexo = sexo;
            this.puesto = puesto;
        }


    }
}
