using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class Checada
    {
        public int id { get; set; }
        public string hora { get; set; }
        public string fecha { get; set; }
        public int h { get; set; }

        //CONTRUCTORES

        public Checada() { }

        public Checada(int id, string hora, string fechan, int h) 
        {

            this.id = id;
            this.hora = hora;
            this.fecha = fecha;
            this.h = h;
        
        }





    }//FIN DE MI CLASE
}
