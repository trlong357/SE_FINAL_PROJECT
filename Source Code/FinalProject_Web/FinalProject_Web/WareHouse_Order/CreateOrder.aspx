<%@ Page Title="Order Status" Language="C#" MasterPageFile="~/WareHouse_Order/Site.Master" AutoEventWireup="true" CodeBehind="CreateOrder.aspx.cs" Inherits="FinalProject_Web.Create_Order" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        h2{
            text-align:center;
            color:red;
         
        }
        #container{
            background-color:aqua;
            border:2px solid #3333;
            width:800px;
            max-width:800px;
            min-width:800px;
            height:600px;
            margin-top:20px;
            margin-left:auto;
            margin-right:auto;
            position:relative;
        }
        #itemDiv{
            margin:0 auto 0 auto;
            width:90%;
            max-height:400px;
            padding:5px;
            overflow-y:scroll;
            border:3px solid #3333;
        }
        .gridHeaderShort{
            background-color:yellow;
            vertical-align:central;
            text-align:center;
            padding:5px;
            font-size:14px;
        }
        .gridItemShort{
             background-color:yellow;
            vertical-align:central;
            text-align:center;
            padding:5px;
            font-size:12px;
        }
        .gridHeaderLong{
             background-color:yellow;
            vertical-align:central;
            text-align:left;
            padding:5px;
            font-size:14px;

        }
        .gridItemLong{
             background-color:yellow;
            vertical-align:central;
            text-align:left;
            padding:5px;
            font-size:12px;
        }

        #payment{
            width:100%;
            height:100px;
            position:absolute;
            left:0;
            bottom:10px;
        }
        #method{
            width:150px;
            height:50px;
            font-size:16px;

            position:absolute;
            right:100px;
            top:20px;
        }

        .btnOrder{
            width:100px;
            height:50px;
            font-size:16px;
            position:absolute;
            right:39px;
            top:20px;
            background-color: #0d6efd;
            border: 1px solid #0d6efd;
        }
         p{
            text-align:center;
        }
    </style>
    <div id="container">
        <h2>New Order</h2>

        <div id="itemDiv">
            <asp:GridView ID="itemList" runat="server" AutoGenerateColumns="false" BackColor="White">
                <Columns>
                    <asp:BoundField DataField="Product's ID" HeaderText="Product's ID" HeaderStyle-Width="125" HeaderStyle-CssClass="gridHeaderShort" ItemStyle-CssClass="gridItemShort" ReadOnly="true"/>
                    <asp:BoundField DataField="Product's Name" HeaderText="Product's Name"  HeaderStyle-Width="250"  HeaderStyle-CssClass="gridHeaderLong" ItemStyle-CssClass="gridItemLong" ReadOnly="true"/>
                    <asp:BoundField DataField="Unit Type" HeaderText="Unit Type"  HeaderStyle-Width="125"  HeaderStyle-CssClass="gridHeaderShort" ItemStyle-CssClass="gridItemShort" ReadOnly="true"/>
                    <asp:BoundField DataField="Price" HeaderText="Price"  HeaderStyle-Width="150"  HeaderStyle-CssClass="gridHeaderShort" ItemStyle-CssClass="gridItemShort" ReadOnly="true"/>
                    <asp:TemplateField HeaderText = "Quantity" HeaderStyle-Width="100"  HeaderStyle-CssClass="gridHeaderShort" ItemStyle-CssClass="gridItemShort">
                        <ItemTemplate>
                            <asp:TextBox ID="quantity" runat="server" Width="100" TextMode="Number" min="0" max="100" step="0" Text="0">
                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div id="payment">
            <div id="method">
                <asp:RadioButtonList runat="server">
                    <asp:ListItem Selected="true" ID="btnBank">Banking</asp:ListItem>
                    <asp:ListItem>Momo</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div>
                <asp:Button ID="btnOdrer" Text="Place Order" runat="server" CssClass="btnOrder" OnClick="btnOrder_Click"/>
            </div>
        </div>
        
    </div>
     
    <asp:Label ID="loadError" runat="server"></asp:Label>
    <br />
    <asp:Label ID="orderError" runat="server"></asp:Label>

</asp:Content>
