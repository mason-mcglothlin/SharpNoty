<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>SharpNoty</h1>
        <p class="lead">SharpNoty is a library for generating <a href="http://ned.im/noty/">noty</a> notifications via C#.</p>
        <p>
            <asp:Button runat="server" OnClick="CreateNoty_Click" class="btn btn-primary btn-lg" Text="Create a noty" /></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Nested Notys</h2>
            <p>
                Nested noty's are supported.
            </p>
            <p>
                <asp:Button runat="server" OnClick="CreateNestedNoty_Click" class="btn btn-default" Text="Create nested noty" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>TODO</h2>
            <p>
                Describe feature here.           
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>TODO</h2>
            <p>
                Describe feature here           
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
