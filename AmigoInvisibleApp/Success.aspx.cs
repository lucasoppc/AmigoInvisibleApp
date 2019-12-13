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
            try
            { 
                if ((bool)Database.verificarganado() == true)
                {
                    Response.Redirect("Ganaste.aspx");
                }
                gvPistas.DataSource = Database.listarPistas();
                gvPistas.DataBind();
            }
            catch(Exception ex)
            {
                lblDialogo.Text = ex.Message;
            }
            
        }

        protected void btnEnviarNombre_Click(object sender, EventArgs e)
        {
            lblDialogo.Text = "";
            string nombre = txtNombre.Text.Trim().ToUpper();

            if (txtNombre.Text != "")
            {
                try
                {
                    Database.obtenerUltimoIntento();
                    if ((bool)Database.enviarNombre(nombre) == true)
                    {
                        Database.ganado();
                        Response.Redirect("Ganaste.aspx");
                    }
                }
                catch(Exception ex)
                {
                    lblDialogo.Text = ex.Message;
                }
                try
                {
                    Database.agregarIntento();
                }
                catch(Exception ex)
                {
                    lblDialogo.Text = ex.Message;
                }

            }
            else
            {
                lblDialogo.Text = "Ponele un nombree";
            }
            
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