using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AmigoInvisibleApp
{
    public partial class controlpanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                gvPistas.DataSource = Database.listarPreguntas();
                gvPistas.DataBind();

                lblEstado.Text ="Desbloqueo el codigo? " + Database.verificarcodigo().ToString() + " Gano el juego? " + Database.verificarganado().ToString();
            }
            catch(Exception ex)
            {
                lblDialogo.Text = ex.Message;
            }
        }

        protected void btnEnviarPista_Click(object sender, EventArgs e)
        {
            lblDialogo.Text = "";
            if (txtPista.Text.Trim() != "")
            {
                Pista unaPista = new Pista(DateTime.Now, txtPista.Text.Trim());
                try
                {
                    Database.enviarPista(unaPista);
                }
                catch (Exception ex)
                {
                    lblDialogo.Text = ex.Message;
                }
            }
            else
            {
                lblDialogo.Text = "introducir pista";
            }
        }
    }
}