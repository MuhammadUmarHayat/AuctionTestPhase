<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Online_Auction_Website_TestPhase.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Online Auction website</title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="Container">
            <div class="Header">

                <h1 class="auto-style1"><strong>Online Auction Website 

            </strong></h1>

            </div>
            <div class="NavBar">

                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx" 
                    CssClass="auto-style5">Home</asp:HyperLink><span class="auto-style5">|  
                  </span>  <asp:HyperLink ID="HyperLink3" runat="server" 
                    NavigateUrl="~/AddProducts.aspx" CssClass="auto-style5">Add Products</asp:HyperLink>

                |<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/TestFile.aspx" 
                    CssClass="auto-style5">Search </asp:HyperLink>

</div>
           <div >
               
               Search   <asp:TextBox ID="TxtSearch" runat="server"></asp:TextBox> 
               <asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
               
               </div>
           <div style="background-color:burlywood">
           
           <div>

        <asp:DataList ID="DataList1" runat="server" BackColor="Gray" BorderColor="#666666"

            BorderStyle="None" BorderWidth="2px" CellPadding="3" CellSpacing="2"

            Font-Names="Verdana" Font-Size="Small" GridLines="Both" RepeatColumns="3" RepeatDirection="Horizontal"

            Width="600px">

            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />

            <HeaderStyle BackColor="#333333" Font-Bold="True" Font-Size="Large" ForeColor="White"

                HorizontalAlign="Center" VerticalAlign="Middle" />

            <HeaderTemplate>

                Product Details</HeaderTemplate>

            <ItemStyle BackColor="White" ForeColor="Black" BorderWidth="2px" />

            <ItemTemplate>

                <asp:Image ID="imgEmp" runat="server" Width="100px" Height="120px" ImageUrl='<%#DataBinder.Eval(Container.DataItem, "image") %>' style="padding-left:40px"/><br />

                <b>Employee Name:</b>

                <asp:Label ID="lblCName" runat="server" Text='<%# Bind("category") %>'></asp:Label>

                <br />

                <b>Designation:</b>

                <asp:Label ID="lblName" runat="server" Text='<%# Bind("item") %>'></asp:Label>

                <br />

               <b> City:</b>

                <asp:Label ID="lblCity" runat="server" Text=' <%# Bind("description") %>'></asp:Label>

                <br />

                <b>Country:</b>

                <asp:Label ID="lblCountry" runat="server" Text='<%# Bind("price") %>'></asp:Label>

                <br />

            </ItemTemplate>

        </asp:DataList>

    </div>  



           </div>


        </div>
         <div class="Footer">

            </div>

    </form>
</body>
</html>