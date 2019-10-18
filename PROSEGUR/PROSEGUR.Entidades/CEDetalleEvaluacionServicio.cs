using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROSEGUR.Entidades
{
    public class CEDetalleEvaluacionServicio
    {
        public DateTime Fecha { get; set; }
        private string prrr = "dd";
        public int Calificacion { get; set; }

        public CEDetalleEvaluacionServicio()
        {
            Fecha = new DateTime();
            Calificacion = 0;
        }
    }
}
