<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Esercizio_finaleS3M4.Carrello" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-3">
        <h2>Carrello</h2>
        <asp:Repeater ID="CarrelloRepeater" runat="server" OnItemCommand="EliminaProdotto">
            <ItemTemplate>
                <div class="d-flex align-items-center mt-4" runat="server" id="productItem">
                    <asp:Image ID="ImgUrl" src='<%# Eval("ImgUrl") %>' runat="server" CssClass="img-fluid rounded-circle" Height="70" Width="70" />
                    <div class="d-flex flex-column justify-content-center mx-3">
                        <asp:Label ID="NomeProdotto" class="card-title" runat="server" Text='<%# Eval("Nome") %>'></asp:Label>
                        <asp:Label ID="Prezzo" runat="server" Text='<%# Eval("Prezzo") + "€" %>'></asp:Label>
                    </div>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" class="btn btn-danger" CommandArgument='<%# Eval("IdProdotto") %>' Text="Rimuovi" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <p class="mt-5">Totale:
            <asp:Label ID="TotaleLabel" runat="server" Text="0.00"></asp:Label>
            €</p>
        <asp:Button ID="SvuotaCarrello" runat="server" Text="Svuota Carrello" class="btn btn-danger" OnClick="SvuotaCarrello_Click" />
    </div>
</asp:Content>

