<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/WareHouse_InOutControl/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalProject_Web._Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="LoginContent" runat="server">


   <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-black my-4">Login</h3></div>
                                    <div class="card-body">
                                        <form>
                                            <div class="form-floating mb-3">
                                                <div>Username: </div>
                                                <br />
                                                <asp:TextBox class="form-control" ID="txtUsername" runat="server" />
                                            </div>
                                            <div class="form-floating mb-3">
                                                <div>Password: </div>
                                                <br />
                                                 <asp:TextBox placeholder="name@example.com" class="form-control" ID="txtPassword" runat="server" TextMode="Password" />
                                            </div>
                          
                                            <div class="d-flex align-items-center justify-content-between mt-4 mb-0">
                                                 <asp:Button class="btn btn-primary" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"></asp:Button> 
                                            </div>
                                             <div class ="inputRow">
                                         <asp:Label ID="errorLabel" runat="server" CssClass="errorRow" Height="40px" Visible="true"></asp:Label> 
                                        </div>
                                        </form>
                                        <div id ="demoAcc" class="col-lg-5">
        <asp:Label  ID="accList" runat="server"></asp:Label>
    </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
    
</asp:Content>