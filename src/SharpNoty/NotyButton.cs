using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SharpNoty
	{
	public class NotyButton
		{
		/// <summary>
		/// CSS classes (separated with a space) for the buttons to use
		/// </summary>
		public string CssClass { get; set; }

		/// <summary>
		/// Text to display on the button
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// JavaScript to run with the button is clicked. The parent noty can be accessed via $noty, and can be closed by $noty.close().
		/// </summary>
		public string OnClickJs { get; set; }

		/// <summary>
		/// Generates the JavaScript for this button.
		/// </summary>
		/// <returns></returns>
		public string GenerateButtonJs()
			{
			StringBuilder sb = new StringBuilder();
			sb.Append("{");
			sb.Append("addClass: '" + CssClass + "', text: '" + HttpUtility.HtmlEncode(Text) + "', onClick: function($noty){");
			sb.Append(OnClickJs);
			sb.Append("}}");
			return sb.ToString();
			}

		/// <summary>
		/// Constructor for creating a button.
		/// </summary>
		public NotyButton()
			{
			}

		/// <summary>
		/// Constructor for creating a button.
		/// </summary>
		public NotyButton(string text, string onClickJs = "", string cssClass = "")
			{
			Text = text;
			OnClickJs = onClickJs;
			CssClass = cssClass;
			}
		}
	}
