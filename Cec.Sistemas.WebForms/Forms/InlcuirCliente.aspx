<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InlcuirCliente.aspx.cs" Inherits="Cecam.Sistemas.WebForms.Forms.InlcuirCliente" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<style>
input[type=text], select {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}

input[type=checkbox] {
  margin: 8px 0;
  display: inline-block;
}

input[type=radio] {
  margin: 8px 0;
  display: inline-block;
}

input[type=submit] {
  width: 100%;
  background-color: #4CAF50;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}

input[type=submit]:hover
{
  background-color: #45a049;
}
</style>
    
<asp:ScriptManager ID="ScriptManager2" runat="server">
</asp:ScriptManager>

    <h3>Incluir Cliente</h3>

     <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        CPF ou CNPJ:
                        <asp:TextBox ID="txtDocumento" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Tipo Pessoa:
                        <asp:RadioButtonList ID="rdbTipoPessoa" RepeatDirection="Horizontal" runat="server">
                            <asp:ListItem Text="Física" Value="F" />
                            <asp:ListItem Text="Jurídica" Value="J" />
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Nome:
                        <asp:TextBox ID="txtNomeCliente" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Ativo:
                        <asp:CheckBox ID="cbxAtivo" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Departamento:
                        <asp:DropDownList ID="dpdDepartamento" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnIncluir" runat="server" Text="Incluir" OnClick="BtnIncluir_Click" />
                        <asp:CustomValidator id="CustomValidatorCliente" runat="server" Display="None" EnableClientScript="False"></asp:CustomValidator>
                        <asp:ValidationSummary ID="Validacoes" runat="server" />
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>





