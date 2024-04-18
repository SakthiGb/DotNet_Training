<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="font-size:x-large;text-align:center">Employee Details Info Form</div>
        <table class="nav-justified">
            <tr>
                <td style="width: 236px">&nbsp;</td>
                <td style="width: 408px">Id</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 236px; height: 22px"></td>
                <td style="width: 408px; height: 22px;">Name</td>
                <td style="height: 22px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 236px">&nbsp;</td>
                <td style="width: 408px">Address</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="295px">
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>Australia</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 236px">&nbsp;</td>
                <td style="width: 408px">Contact</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 47px; width: 236px"></td>
                <td style="width: 408px; height: 47px;"></td>
                <td style="height: 47px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td style="height: 47px; width: 236px">&nbsp;</td>
                <td style="width: 408px; height: 47px;">&nbsp;</td>
                <td style="height: 47px">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-left: 0px" Width="512px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
        
</asp:Content>
