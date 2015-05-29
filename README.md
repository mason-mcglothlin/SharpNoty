# SharpNoty
SharpNoty is a set of helper classes to generate [noty](http://ned.im/noty/) notification messages from C# code in an ASP.NET web application. It is intended as the replacement for this:


    ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "alert('Failed to save data.');", true);

A beautiful noty notification can be created with this simple C# code in the code behind.

    Page.AddNoty(new Noty("Failed to save data.", NotyType.alert));
    
# Getting Started
Your page will need a reference to the noty library. Although it's available as a [NuGet package](https://www.nuget.org/packages/jquery.noty/), I reccomend you use the `jquery.noty.packaged.min.js` file [hosted on Cloud Flare](http://cdnjs.com/libraries/jquery-noty).

The extension methods for SharpNoty are in the `SharpNoty.PageExtensions` namespace.

# Currently supported features
- Can create a basic noty with one of the noty message types in any supported noty location on the screen
- Can add buttons to notys and have them trigger other notys
- Can modify the class of the buttons

# Future Plans for this project

- Support for all [noty](http://ned.im/noty/) features.
- NuGet package
- Examples with pictures
- Helpers for MVC to be used in Razor
