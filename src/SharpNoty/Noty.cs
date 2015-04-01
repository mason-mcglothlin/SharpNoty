using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SharpNoty
	{
	/// <summary>
	/// The type of message to display. Affects the colors of the notification.
	/// </summary>
	public enum MessageType
		{
		alert, success, error, warning, information, confirm
		}

	/// <summary>
	/// The location on the screen to display the notification.
	/// </summary>
	public enum MessageLocation { bottom, bottomCenter, bottomLeft, bottomRight, center, centerLeft, centerRight, inline, top, topCenter, topLeft, topRight }


	/// <summary>
	/// Message to be displayed on the client browser.
	/// </summary>
	public class Noty
		{
		/// <summary>
		/// The text of the message to be displayed. Do not directly set the field, it is only for serialization support.
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// The type of message.
		/// </summary>
		public MessageType MessageType { get; set; }

		/// <summary>

		/// The location on the screen to display the message. Accessed through the MessageLocation enum.

		/// </summary>
		public MessageLocation Location { get; set; }

		/// <summary>

		/// If modal is true, the rest of the page can't be interacted with until the notification is dismissed.

		/// </summary>
		public bool Modal { get; set; }

		/// <summary>

		/// Number of milliseconds to display the message. Set to 0 for no timeout.

		/// </summary>
		public int Timeout { get; set; }

		/// <summary>

		/// An set of buttons to display with the noty.

		/// </summary>
		public List<NotyButton> Buttons { get; set; }

		/// <summary>

		/// Empty constructor only to be used for serialization

		/// </summary>
		public Noty()
			{
			MessageType = MessageType.information;
			Location = MessageLocation.top;
			Modal = false;
			Timeout = 6000;
			Buttons = new List<NotyButton>();
			}

		/// <summary>

		/// Constructor for creating a message.

		/// </summary>

		/// <param name="messagetext">The text to appear on the notification.</param>

		/// <param name="messagetype">The type to use for the notification. Default is MessageType.information</param>

		/// <param name="messagelocation">The location to use for the notification. Default is MessageLocation.top</param>

		/// <param name="Modal">If true, the page can't be interacted with until the notification is dismissed. Default is false.</param>

		/// <param name="MessageTimeout">The number of milliseconds to display the notification. Default is 6000ms which is 6 seconds.</param>
		public Noty(string messagetext, MessageType messagetype = MessageType.information, MessageLocation messagelocation = MessageLocation.top, bool Modal = false, int MessageTimeout = 6000)
			{
			this.Text = messagetext;
			this.MessageType = messagetype;
			this.Location = messagelocation;
			this.Modal = Modal;
			this.Timeout = MessageTimeout;
			Buttons = new List<NotyButton>();
			}

		/// <summary>

		/// Generates the JavaScript string to display a noty

		/// </summary>

		/// <returns></returns>
		public string GenerateNotyJs()
			{
			var timeout_str = "";
			if (Timeout == 0)
				{
				timeout_str = "false";
				}
			else
				{
				timeout_str = "" + Timeout;
				}

			var modal_str = Modal ? "true" : "false";
			List<string> buttoncode = new List<string>();
			foreach (var button in Buttons)
				{
				buttoncode.Add(button.GenerateButtonJs());
				}

			string btn = "";
			if (Buttons.Count > 0)
				{
				btn = ", buttons: [" + String.Join(",", buttoncode) + "]";
				}

			string js = "noty({ text: '" + HttpUtility.HtmlEncode(Text) + "', type: '" + MessageType + "', layout: '" + Location + "', timeout: '" + timeout_str + "', modal: " + modal_str + "" + btn + "});";
			return js;
			}
		}
	}
