using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROSEGUR.Entidades
{
    public class CERepuesta
    {
        public bool Resultado { get; set; }
        public string Descripcion { get; set; }

        public CERepuesta()
        {
            Resultado = false;
            Descripcion = "";
        }
    }
}