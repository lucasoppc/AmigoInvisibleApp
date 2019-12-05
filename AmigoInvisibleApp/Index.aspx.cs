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

        }

        protected void btnProbar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text != "")
            {
                string codigo = txtCodigo.Text;
                if(codigo == "123")
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
            else
            {
                lblDialogo.CssClass = "text-primary";
                lblDialogo.Text = "Debes ingresar el codigo secreto para empezar :D";
            }
        }
    }
}