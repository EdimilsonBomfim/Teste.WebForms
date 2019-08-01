<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Cecam.Sistemas.WebForms.Forms.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Clientes</h3>    

    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Forms/InlcuirCliente.aspx" runat="server">Incluir Cliente</asp:HyperLink>

    <asp:GridView ID="gvClientes" runat="server" CssClass="table" OnRowDeleting="gvClientes_RowDeleting" DataKeyNames="Id">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:BoundField DataField="Ativo" HeaderText="Ativo" />
            <asp:BoundField DataField="TipoPessoa" HeaderText="Tipo Pesso" />
            <asp:BoundField DataField="Documento" HeaderText="Documento" />

        </Columns>
    </asp:GridView>

</asp:Content>
