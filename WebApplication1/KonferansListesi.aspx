<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KonferansListesi.aspx.cs" Inherits="WebApplication1.KonferansListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>ÖDÜLLER</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("ID")%></td>
                            <td><%#Eval("ODUL")%></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%#"KonferansSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%#"KonferansGuncelle.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Guncelle</asp:HyperLink>

                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/KonferensEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">YETENEK EKLE</asp:HyperLink>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="CV İndir" OnClick="Button1_Click" BackColor="#5BC0DE" ForeColor="White" />
    </form>

</asp:Content>
