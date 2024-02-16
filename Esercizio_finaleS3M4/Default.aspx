<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Esercizio_finaleS3M4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row">
            <asp:Repeater ID="productRepeater" runat="server">
                <ItemTemplate>
                    <div class="col-md-3 mb-3">
                        <div class="card" style="height: 32em">
                            <div class="card-img-top d-flex justify-content-center" style="height: 300px; overflow: hidden;">
                                <img src='<%# Eval("ImgUrl") %>' class="img-fluid rounded" style="height: inherit" alt='<%# Eval("Nome") %>' />
                            </div>
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Nome") %></h5>
                                <p class="card-text"><%# Eval("Descrizione") %></p>
                                <p class="card-text"><%# Eval("Prezzo") %>€</p>
                                <div class="position-absolute bottom-0 start-0 p-2">
                                    <a href='<%# "Dettaglio.aspx?id=" + Eval("IdProdotto") %>' class="btn btn-danger">Dettagli</a>
                                    <asp:Button ID="AddCarrello" runat="server" Text="Aggiungi al Carrello" CssClass="btn btn-danger" OnClick="AddCarrello_Click" CommandArgument='<%# Eval("IdProdotto") %>' />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Literal ID="PopupLiteral" runat="server"></asp:Literal>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
