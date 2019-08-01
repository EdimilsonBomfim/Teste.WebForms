<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IncluirGrupo.aspx.cs" Inherits="Cecam.Sistemas.WebForms.Forms.IncluirGrupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
input[type=text] {
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

input[type=submit]:hover {
  background-color: #45a049;
}
</style>

<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>

    <h3>Incluir Grupo</h3>

     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        Name:
                        <asp:TextBox ID="txtNome" runat="server"/>
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
                        <asp:Button ID="btnIncluir" runat="server" Text="Incluir" OnClick="btnIncluir_Click" />
                        <asp:CustomValidator id="CustomValidatorGrupo" runat="server" Display="None" EnableClientScript="False"></asp:CustomValidator>
                        <asp:ValidationSummary ID="ValidacoesGrupo" runat="server" />
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>