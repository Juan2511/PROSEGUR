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
    public partial class ReporteCalificaciones : System.Web.UI.Page
    {
        CNCalificacionEvaluacion objCNCalificacionEvaluacion = new CNCalificacionEvaluacion();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCalificaciones();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarCalificaciones();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            //LimpiarObjetos();
            //txtEmail.Focus();
        }

        //private void LimpiarObjetos()
        //{
        //    txtEmail.Text = "";
        //    txtNombres.Text = "";
        //}

        private void CargarCalificaciones()
        {
            DataTable dt;
            try
            {
                dt = new DataTable();
                dt = objCNCalificacionEvaluacion.Listar();

                if (dt.Rows.Count == 0)
                {
                    lblMensaje.Text = "No se encontraron registros.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;                    
                }
                else
                {
                    dgvCalificaciones.DataSource = dt;
                    dgvCalificaciones.DataBind();
                }                
            }
            catch(Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}