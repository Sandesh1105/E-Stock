<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.Master" AutoEventWireup="true" CodeBehind="VenderReg.aspx.cs" Inherits="WebApplicationFinalMachinTest.VenderReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<style>
input[type=text], select {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
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
        </style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    ID :<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <br />
    <br />
    Vendor Name :
    <asp:TextBox ID="txtVender" runat="server"></asp:TextBox>
    <br />
    <br />
    City :
    <asp:DropDownList ID="ddlCity" runat="server">
        <asp:ListItem>Select</asp:ListItem>
    <asp:ListItem>Nagpur</asp:ListItem>
    <asp:ListItem>Pune</asp:ListItem>
    <asp:ListItem>Mumbai</asp:ListItem>
    <asp:ListItem>Indore</asp:ListItem>
</asp:DropDownList>
    <br />
    <br />
    Address :
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    <br />
    <br />
    Mobile :
    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
&nbsp;<br />
    <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
    <br />
    <br />
    Enter Vendor Mobile No. :
    <%--<asp:TextBox ID="txtVMN" runat="server" Visible="false"></asp:TextBox>--%>
    <asp:DropDownList ID="ddlVMN" runat="server" Visible="false"></asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnFind" runat="server" Text="Find" Visible="false" OnClick="btnFind_Click" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <%#Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:TextBox ID="txtN" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City">
                <ItemTemplate>
                    <asp:TextBox ID="txtC" runat="server" Text='<%# Eval("City") %>'></asp:TextBox>
                </ItemTemplate>            </asp:TemplateField>

            <asp:TemplateField HeaderText="Address">
                <ItemTemplate>
                    <asp:TextBox ID="txtA" runat="server" Text='<%# Eval("Address") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mobile">
                <ItemTemplate>
                    <asp:TextBox ID="txtM" runat="server" Text='<%# Eval("Mobile") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:DropDownList ID="ddlS" runat="server" Text='<%# Eval("Status") %>'>
                        <asp:ListItem>BLOCK</asp:ListItem>
                        <asp:ListItem>UNBLOCK</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="btnE" runat="server" Text="Edit" onclick="btnE_Click"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="btnD" runat="server" Text="Delete" onclick="btnD_Click"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
&nbsp; 

</asp:Content>
