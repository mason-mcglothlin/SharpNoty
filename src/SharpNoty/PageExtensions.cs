using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace SharpNoty
	{
	public static class PageExtensions
		{
		/// <summary>
		/// Registers a noty to run on the page.
		/// </summary>
		/// <param name="p">Page to add the noty to</param>
		/// <param name="noty">noty to display</param>
		public static void AddNoty(this Page p, Noty noty)
			{
			p.ClientScript.RegisterStartupScript(p.GetType(), Guid.NewGuid().ToString(), noty.GenerateNotyJs(), true);
			}
		}
	}