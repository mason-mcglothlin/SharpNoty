# SharpNoty
SharpNoty is a set of helper classes to generate [noty](http://ned.im/noty/) notification messages from C# code in an ASP.NET web application. It is intended as the replacement for this:


    ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "alert('Failed to save data.');", true);

The goal is eventually to look something like this:

    Page.AddNoty(new Noty("Failed to save data.", NotyType.Error));

# Currently supported features
- Can create a basic noty with one of the noty message types in any support noty location on the screen
- Can add buttons to notys and have them trigger other notys
- Can modify the class of the buttons

# Future Plans for this project

- NuGet package
- Cleaner syntax
- Examples with pictures