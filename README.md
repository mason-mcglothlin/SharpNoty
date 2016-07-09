# SharpNoty
SharpNoty is a set of helper classes to generate [noty](http://ned.im/noty/) notification messages from C# code in an ASP.NET web application. It is intended as the replacement for this:


    ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "alert('Failed to save data.');", true);

A beautiful noty notification can be created with this simple C# code in the code behind.

    Page.AddNoty(new Noty("Failed to save data.", MessageType.alert));
    
# Getting Started
Your page will need a reference to the noty library. Although it's available as a [NuGet package](https://www.nuget.org/packages/jquery.noty/), I reccomend you use the `jquery.noty.packaged.min.js` file [hosted on Cloud Flare](http://cdnjs.com/libraries/jquery-noty).

The extension methods for SharpNoty are in the `SharpNoty.PageExtensions` namespace.

# Init for ASP.Net 4.5 WebForms using NuGet

In `App_Start/BundleConfig.cs` add the following lines

    bundles.Add(new ScriptBundle("~/bundles/noty").Include(
                            "~/Scripts/noty/jquery.noty.js",
                            "~/Scripts/noty/themes/default.js",
                            "~/Scripts/noty/layouts/bottom.js",
                            "~/Scripts/noty/layouts/bottomCenter.js",
                            "~/Scripts/noty/layouts/bottomLeft.js",
                            "~/Scripts/noty/layouts/bottomRight.js",
                            "~/Scripts/noty/layouts/center.js",
                            "~/Scripts/noty/layouts/centerLeft.js",
                            "~/Scripts/noty/layouts/centerRight.js",
                            "~/Scripts/noty/layouts/inline.js",
                            "~/Scripts/noty/layouts/top.js",
                            "~/Scripts/noty/layouts/topCenter.js",
                            "~/Scripts/noty/layouts/topLeft.js",
                            "~/Scripts/noty/layouts/topRight.js"));

Next in the file `Site.Master` append `<asp:ScriptReference Path="~/bundles/noty" />` to ScriptManager like the following.

    <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="respond" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <asp:ScriptReference Path="~/bundles/noty" /> <%-- noty bundle --%>
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

Don't forget to add `using SharpNoty;` in the header of the cs file before using it.

# Currently supported features
- Can create a basic noty with one of the noty message types in any supported noty location on the screen
- Can add buttons to notys and have them trigger other notys
- Can modify the class of the buttons

# Future Plans for this project

- Support for all [noty](http://ned.im/noty/) features.
- NuGet package
- Examples with pictures
- Helpers for MVC to be used in Razor
