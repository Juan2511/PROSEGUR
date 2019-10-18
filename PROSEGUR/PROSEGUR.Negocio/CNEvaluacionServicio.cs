using PROSEGUR.Entidades;
using PROSEGUR.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROSEGUR.Negocio
{
    public class CNEvaluacionServicio
    {
        CDEvaluacionServicio objCDEvaluacionServicio = new CDEvaluacionServicio();
        public CERepuesta Agregar(CEEvaluacionServicio objCEEvaluacionServicio)
        {
            CERepuesta ObjCERepuesta = new CERepuesta();

            ObjCERepuesta.Descripcion = ValidaEntidadRegistro(objCEEvaluacionServicio);

            if(!string.IsNullOrWhiteSpace(ObjCERepuesta.Descripcion))
            {
                return ObjCERepuesta;
            }

            ObjCERepuesta = objCDEvaluacionServicio.Agregar(objCEEvaluacionServicio);

            return ObjCERepuesta;
        }

        private string ValidaEntidadRegistro(CEEvaluacionServicio objCEEvaluacionServicio)
        {
            string rpta = "";
            if (string.IsNullOrWhiteSpace(objCEEvaluacionServicio.Correo))
            {
                if (!string.IsNullOrWhiteSpace(rpta)) rpta += ",";
                rpta += "su E-mail";
            }
            if (string.IsNullOrWhiteSpace(objCEEvaluacionServicio.Nombres))
            {
                if (!string.IsNullOrWhiteSpace(rpta)) rpta += ",";
                rpta += "sus nombres";
            }

            if (!string.IsNullOrWhiteSpace(rpta))
            {
                rpta = "Debe ingresar/seleccionar " + rpta + ".";
            }

            return rpta;
        }
    }
}