using System.Text;
using PROSEGUR.Negocio;
using PROSEGUR.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PROSEGUR.UI
{
    public partial class RegistroCalificacion : System.Web.UI.Page
    {
        CNCalificacionEvaluacion objCNCalificacionEvaluacion = new CNCalificacionEvaluacion();
        CNEvaluacionServicio objCNEvaluacionServicio = new CNEvaluacionServicio();
        CNDetalleEvaluacionServicio objCNDetalleEvaluacionServicio = new CNDetalleEvaluacionServicio();
        CEEvaluacionServicio objCEEvaluacionServicio;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalificar_Click(object sender, EventArgs e)
        {
            Calificar();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
            txtEmail.Focus();
        }

        private void LimpiarObjetos()
        {
            txtEmail.Text = "";
            txtNombres.Text = "";
            rdbCalificacion.ClearSelection();
        }

        private bool Calificar()
        {
            StringBuilder sb = new System.Text.StringBuilder();
            CERepuesta objCERepuesta = new CERepuesta();
            string mensaje = "";
            DataTable dt;
            try
            {
                mensaje = ValidaIngresoDatos();

                if(string.IsNullOrWhiteSpace(mensaje))
                {
                    lblMensaje.Text = mensaje;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                dt = new DataTable();
                objCEEvaluacionServicio = new CEEvaluacionServicio();
                objCEEvaluacionServicio.Correo = txtEmail.Text;
                objCEEvaluacionServicio.Nombres = txtNombres.Text;
                objCEEvaluacionServicio.Detalle.Fecha = DateTime.Now;
                objCEEvaluacionServicio.Detalle.Calificacion = int.Parse( rdbCalificacion.SelectedValue);
                dt = objCNDetalleEvaluacionServicio.Consultar(objCEEvaluacionServicio);

                if (dt.Rows.Count > 0)
                {
                    lblMensaje.Text = "Ya registró la calificación de hoy.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                objCERepuesta = objCNEvaluacionServicio.Agregar(objCEEvaluacionServicio);

                if(!objCERepuesta.Resultado)
                {
                    lblMensaje.Text = objCERepuesta.Descripcion;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                objCERepuesta = objCNDetalleEvaluacionServicio.Agregar(objCEEvaluacionServicio);

                if (!objCERepuesta.Resultado)
                {
                    lblMensaje.Text = objCERepuesta.Descripcion;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblMensaje.Text = "Se registró la calificación con éxito.";
                lblMensaje.ForeColor = System.Drawing.Color.Blue;
            }
            catch(Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }

            return true;
        }

        private string ValidaIngresoDatos()
        {
            string rpta = "";
            if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                rpta += "su E-mail";
            }
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                rpta += "sus nombres";
            }
            if((string.IsNullOrWhiteSpace(rdbCalificacion.SelectedValue)) || (int.Parse(rdbCalificacion.SelectedValue)<=0))
            {
                rpta += "su calificación del servicio recibido";
            }

            if (!string.IsNullOrWhiteSpace(rpta))
            {
                rpta = "Debe ingresar/seleccionar " + rpta + ".";
            }

            return rpta;
        }

        protected void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}