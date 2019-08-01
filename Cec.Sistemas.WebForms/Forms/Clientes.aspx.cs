using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cec.Sistemas.Entities;
using Cec.Sistemas.Facade;
using Cec.Sistemas.Facade.Interfaces;

namespace Cecam.Sistemas.WebForms.Forms
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }       

        private void CarregarDados()
        {
            var fac = Cec.Sistemas.Facade.FacadeFactory.Main.GetCliente();
            gvClientes.AutoGenerateColumns = false;
            gvClientes.DataSource = fac.List();
            gvClientes.DataBind();
        }

        protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int.TryParse(gvClientes.DataKeys[e.RowIndex].Value.ToString(), out int id);

            if (id > 0)
            {
                var fac = Cec.Sistemas.Facade.FacadeFactory.Main.GetCliente();
                fac.Delete(id);
                CarregarDados();
            }
        }
    }
}