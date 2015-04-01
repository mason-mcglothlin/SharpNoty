# SharpNoty
SharpNoty is a set of helper classes to generate [noty](http://ned.im/noty/) notification messages from C# code in an ASP.NET web application. It is intended as the replacement for this:


    ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "alert('Failed to save data.');", true);

A beautiful noty notification can be created with this simple C# code in the code behind.

    Page.AddNoty(new Noty("Failed to save data.", NotyType.alert));

# Currently supported features
- Can create a basic noty with one of the noty message types in any supported noty location on the screen
- Can add buttons to notys and have them trigger other notys
- Can modify the class of the buttons

# Future Plans for this project

- Support for all [noty](http://ned.im/noty/) features.
- NuGet package
- Examples with pictures
- Helpers for MVC to be used in Razor