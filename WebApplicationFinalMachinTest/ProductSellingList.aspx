<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.Master" AutoEventWireup="true" CodeBehind="ProductSellingList.aspx.cs" Inherits="WebApplicationFinalMachinTest.ProductSellingList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:330px">      
    <div class="login-box">
     
         <div class="user-box">
             <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
             <label>Enter ID :-</label>
             <br />
         </div>
         

             <asp:DropDownList ID="DDLProduct" runat="server" CssClass="custom-dropdown" AutoPostBack="True" OnSelectedIndexChanged="DDLProduct_SelectedIndexChanged">
                 <asp:ListItem>Select Product</asp:ListItem>
                 
    </asp:DropDownList>

             <br />
<br />
<br />

         
              <div class="user-box">
    <asp:TextBox ID="txtMax" runat="server"></asp:TextBox>
                  <br />
    <label>Max Purchese Cost :-</label>
    
</div>  

         <div class="user-box">
    <asp:TextBox ID="txtSell" runat="server"></asp:TextBox>
             <br />
    <label>Enter Sell Cost :-</label>
    
</div>  

                      <div class="user-box">
    <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                          <br />
    <label>Current Stock :-</label>
    
</div>  

         <div class="user-box">
    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
             <br />
    <label>Enter Date :-</label>
    
             <br />
    
</div>  
              
                    <asp:Button class="button" ID="btnSubmit" runat="server"  Text=" Submit" CssClass="custom-btn" OnClick="btnSubmit_Click"/>
               <br />
<br />
                       
           
            <asp:Button class="button" ID="btnShow" runat="server"  Text="Show" CssClass="custom-btn" OnClick="btnShow_Click"/>
            
         <br />
         <div style="width : 200px">
             <asp:DropDownList Visible="false" ID="DDLPro" runat="server" CssClass="custom-dropdown" >
             </asp:DropDownList>
                      &nbsp;&nbsp;&nbsp;
                      <asp:Button ID="btnFind" Visible="false" runat="server" Text="Find" CssClass="custom-btn" OnClick="btnFind_Click"/>
         </div>
         <br />
         <br />
         <asp:GridView ID="GVSell" runat="server" AutoGenerateColumns="False" >
             <HeaderStyle ForeColor="SkyBlue"/>
             <Columns>
                 <asp:TemplateField HeaderText="Id" ItemStyle-BackColor="SkyBlue">
                     <ItemTemplate>
                         <asp:Label runat="server" ID="lblid" Text='<%#Eval("id") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Product" ItemStyle-BackColor="SkyBlue">
                     <ItemTemplate>
                         <asp:Label runat="server" ID="lblProduct" Text='<%#Eval("product") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Max Cost" ItemStyle-BackColor="SkyBlue">
                     <ItemTemplate>
                         <asp:Label runat="server" ID="lblMax" Text='<%#Eval("max") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Sell Cost" ItemStyle-BackColor="SkyBlue">
                     <ItemTemplate>
                         <asp:TextBox ID="txtSell2" Text='<%#Eval("sell") %>' runat="server"></asp:TextBox>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Stock" ItemStyle-BackColor="SkyBlue">
                     <ItemTemplate>
                         <asp:Label runat="server" ID="lblStock" Text='<%#Eval("stock") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Action" ItemStyle-BackColor="SkyBlue">
                     <ItemTemplate>
                         <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
         </asp:GridView>
         <br />
            
        </div>
    </div>
</asp:Content>
