using Cec.Sistemas.Business;
using Cec.Sistemas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Cecam.Sistemas.WebForms.Forms
{
    public partial class InlcuirCliente : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarDepartamentos();
        }

        private void CarregarDepartamentos()
        {
            var fac = Cec.Sistemas.Facade.FacadeFactory.Main.GetGrupo();
            dpdDepartamento.DataSource = fac.List();
            dpdDepartamento.DataTextField = "Nome";
            dpdDepartamento.DataValueField = "Id";
            dpdDepartamento.DataBind();
        }

        protected void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeCliente.Text;
                string documento = txtDocumento.Text;
                bool ativo = cbxAtivo.Checked;
                string tipoPessoa = rdbTipoPessoa.SelectedValue;
                int.TryParse(dpdDepartamento.SelectedValue, out int departamento);

                Cliente cliente = new Cliente()
                {
                    Nome = nome,
                    Documento = documento,
                    Ativo = ativo,
                    TipoPessoa = tipoPessoa,
                    DataCadastro = DateTime.Now,
                    GrupoId = departamento
                };

                if (tipoPessoa == "F" && !ValidarCPF(documento))
                    throw new ArgumentException("CFP inválido!");

                if (tipoPessoa == "J" && !ValidarCNPJ(documento))
                    throw new ArgumentException("CNPJ inválido!");                

                var fac = Cec.Sistemas.Facade.FacadeFactory.Main.GetCliente();
                fac.Save(cliente);
                Response.Redirect("Clientes.aspx");
            }
            catch(Exception ex)
            {
                CustomValidatorCliente.IsValid = false;
                CustomValidatorCliente.ErrorMessage = ex.Message;
            }

            //var validar = true;
            //if (tipoPessoa == "J")
            //{
            //   validar = RegraClienteBusiness.ValidCnpj(documento);
            //}
            //else
            //{
            //   validar = RegraClienteBusiness.ValidCnpj(documento);
            //}

            //Console.WriteLine("valor validar = " + validar);
            //Console.ReadKey();

            //if (validar)
            //{
            //  var fac = Cec.Sistemas.Facade.FacadeFactory.Main.GetCliente();
            //  fac.Save(cliente);
            //  Response.Redirect("Clientes.aspx");
            //}
            //else
            //{
            //    MessageBox.Show("Erro no documento."); 
           
            //}
        }

        protected bool ValidarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return true;
        }

        protected bool ValidarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}