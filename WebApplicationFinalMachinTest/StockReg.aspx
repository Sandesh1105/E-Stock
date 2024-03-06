<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.Master" AutoEventWireup="true" CodeBehind="StockReg.aspx.cs" Inherits="WebApplicationFinalMachinTest.StockReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br style="margin-left: 40px" />
        <br />
</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    ID :
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    Select Vender Name :&nbsp;
    <asp:DropDownList ID="ddlVName" runat="server" OnSelectedIndexChanged="ddlVName_SelectedIndexChanged">
    </asp:DropDownList>
</p>
<p>
    &nbsp;</p>
<p>
    Vender Mobile :
    <asp:TextBox ID="txtVMobile" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    Select Product :
    <asp:DropDownList ID="ddlProduct" runat="server">
    </asp:DropDownList>
</p>
<p>
    &nbsp;</p>
<p>
    Cost :
    <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    Quantity :
    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" />
</p>
<p>
    &nbsp;</p>
<p>
    Total Account :
    <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    Stock Count :
    <asp:TextBox ID="txtCount" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnShow" runat="server" Text="Show" />
</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <%# Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:TextBox ID="tProduct" runat="server" Text='<%# Eval("Product") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stock">
                    <ItemTemplate>
                        <asp:TextBox ID="tStock" runat="server" Text='<%# Eval("Stock") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total">
                    <ItemTemplate>
                        <asp:TextBox ID="tTStock" runat="server" Text='<%# Eval("Total_Stock") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="btnV" runat="server" Text="View History" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Product Name :
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;
</p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="ID"></asp:TemplateField>
                <asp:TemplateField HeaderText="Vendor Name"></asp:TemplateField>
                <asp:TemplateField HeaderText="Cost"></asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity"></asp:TemplateField>
                <asp:TemplateField HeaderText="Total"></asp:TemplateField>
                <asp:TemplateField HeaderText="Add New Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="tNewQlty" runat="server" Text='<%# Eval("Quantity") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="bUpdate" runat="server" Text="Update" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
</asp:Content>
