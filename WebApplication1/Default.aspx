
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 ><asp:Label ID="lblTituloApp" runat="server"></asp:Label></h1>
        
    </div>

    <div class="row">
        <div class="col-md-4">
            <input type="text" id="checkNumberEven" name="checkNumberEven" runat="server" />
            
        </div>
        <div class="col-md-4">
           <asp:Button id="Button1" Text="Click here for check if the number is even..."   
           runat="server" OnClick="Button1_Click"/>
        </div>
        <div class="col-md-4">
            <p>Result Section</p>
            <p>The number is :</p> <asp:Label ID="Label1" runat="server">  </asp:Label>
        </div>

        
    </div>

 



</asp:Content>

