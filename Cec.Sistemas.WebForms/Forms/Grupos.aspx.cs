using Cec.Sistemas.Entities;
using Cec.Sistemas.Facade;
using Cec.Sistemas.Facade.Interfaces;
using System;

namespace Cecam.Sistemas.WebForms.Forms
{
    public partial class Grupos : System.Web.UI.Page
    {
        
        private void CarregarDados()
        {
            var fac = Cec.Sistemas.Facade.FacadeFactory.Main.GetGrupo();
            gvDados.AutoGenerateColumns = false;
            gvDados.DataSource = fac.List();
            gvDados.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }        

        protected void gvDados_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int.TryParse(gvDados.DataKeys[e.RowIndex].Value.ToString(), out int id);

            if (id > 0)
            {
                var fac = Cec.Sistemas.Facade.FacadeFactory.Main.GetGrupo();
                fac.Delete(id);
                CarregarDados();
            }                        
        }
    }
}