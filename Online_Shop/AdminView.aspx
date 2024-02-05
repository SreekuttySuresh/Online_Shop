<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="Online_Shop.AdminView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .auto-style2 {
            width: 182px;
        }
        .auto-style3 {
            height: 27px;
            width: 182px;
        }
        .auto-style4 {
            width: 193px;
        }
        .auto-style5 {
            height: 27px;
            width: 193px;
        }
        .auto-style6 {
            width: 42px;
        }
        .auto-style7 {
            height: 27px;
            width: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="#000066" NavigateUrl="~/Add_Category.aspx">Add Category</asp:HyperLink>
            </td>
            <td class="auto-style4">
                <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" ForeColor="#000066" NavigateUrl="~/AddProduct.aspx">Add Product</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink5" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="#000066" NavigateUrl="~/BlockUser.aspx">Block User</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2">
                <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" ForeColor="#000066" NavigateUrl="~/Edit_Category.aspx">Edit Category</asp:HyperLink>
            </td>
            <td class="auto-style4">
                <asp:HyperLink ID="HyperLink4" runat="server" Font-Bold="True" ForeColor="#000066" NavigateUrl="~/EditProduct.aspx">Edit Product</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style3"></td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5"></td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style3"></td>
            <td class="auto-style5"></td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
