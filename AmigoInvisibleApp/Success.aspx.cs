using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmigoInvisibleApp
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvPistas.DataSource =Database.listarPistas();
            gvPistas.DataBind();
        }

        protected void btnEnviarNombre_Click(object sender, EventArgs e)
        {

        }

        protected void btnEnviarPregunta_Click(object sender, EventArgs e)
        {
            lblDialogo.Text = "";
            if(txtPregunta.Text != "")
            {
                try
                {
                    //se usa pista para lo que seria pregunta ya que tienen los mismos atributos
                    Pista pista = new Pista(DateTime.Now, txtPregunta.Text);
                    Database.enviarPregunta(pista);
                }
                catch(Exception ex)
                {
                    lblDialogo.Text = ex.Message;
                }
            }
            else
            {
                lblDialogo.Text = "Debes escribir la pregunta";
            }
        }
    }
}