using Cec.Sistemas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cecam.Sistemas.WebForms.Forms
{
    public partial class IncluirGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                bool ativo = cbxAtivo.Checked;

                Grupo grupo = new Grupo
                {
                    Nome = nome,
                    Ativo = ativo
                };

                var fac = Cec.Sistemas.Facade.FacadeFactory.Main.GetGrupo();
                fac.Save(grupo);
                Response.Redirect("Grupos.aspx");
            }
            catch(Exception ex)
            {
                CustomValidatorGrupo.IsValid = false;
                CustomValidatorGrupo.ErrorMessage = ex.Message;
            }
        }
    }
}