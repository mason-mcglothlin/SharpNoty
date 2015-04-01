using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpNoty;

namespace DemoSite
	{
	public partial class _Default : Page
		{
		protected void Page_Load(object sender, EventArgs e)
			{
			}

		protected void CreateNoty_Click(object sender, EventArgs e)
			{
			var noty = new Noty("Hello, world!", MessageType.success);
			Page.AddNoty(noty);
			}

		protected void CreateNestedNoty_Click(object sender, EventArgs e)
			{
			var top = new Noty("Do you want to continue?", MessageType.information);
			var yesNoty = new Noty("You clicked yes!", MessageType.success);
			var noNoty = new Noty("You clicked no!", MessageType.error);
			var yesBtn = new NotyButton("Yes", "$noty.close();"+yesNoty.GenerateNotyJs(), "btn btn-primary");
			var noBtn = new NotyButton("No", "$noty.close();"+noNoty.GenerateNotyJs(), "btn btn-danger");
			top.Buttons.Add(yesBtn);
			top.Buttons.Add(noBtn);
			Page.AddNoty(top);
			}
		}
	}