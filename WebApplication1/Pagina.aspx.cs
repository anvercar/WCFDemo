using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class Pagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Consultar()
        {
            using (PersonaClient cliente = new PersonaClient())
            {
                Grilla.DataSource = cliente.Consultar();
                Grilla.DataBind();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}