using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmigoInvisibleApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if ((bool)Database.verificarcodigo() == true)
                {
                    lblDialogo.Text = "true";
                    Response.Redirect("Success.aspx");
                }
            }
            catch(Exception ex)
            {
                lblDialogo.Text = ex.Message;
            }
            
        }

        protected void btnProbar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text != "")
            {
                string codigo = txtCodigo.Text;
                try
                {

                
                if((bool)Database.verificarNombre(codigo) == true)
                {
                    lblDialogo.CssClass = "text-success";
                    lblDialogo.Text = "Me descubriste!";
                    Response.Redirect("Success.aspx");
                }
                else
                {
                    lblDialogo.CssClass = "text-danger";
                    lblDialogo.Text = "Codigo invalido :c";
                }
                }
                catch(Exception ex)
                {
                    lblDialogo.Text = ex.Message;
                }
            }
            else
            {
                lblDialogo.CssClass = "text-primary";
                lblDialogo.Text = "Debes ingresar el codigo secreto para empezar :D";
            }
        }
    }
}