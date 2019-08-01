<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grupos.aspx.cs" Inherits="Cecam.Sistemas.WebForms.Forms.Grupos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Grupos</h3>
    
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Forms/IncluirGrupo.aspx" runat="server">Incluir Grupo</asp:HyperLink>

    <asp:GridView ID="gvDados" runat="server" CssClass="table" OnRowDeleting="gvDados_RowDeleting" DataKeyNames="Id">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
        </Columns>
    </asp:GridView>

</asp:Content>
