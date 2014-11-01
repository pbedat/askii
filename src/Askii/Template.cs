using System;
using System.Windows.Forms;

namespace Askii
{
	public class Template
	{
		public string 				Title 	{ get; set; }
		public string 				Message { get; set; }
		public MessageBoxIcon		Icon 	{ get; set; }
		public MessageBoxButtons	Buttons { get; set; }
	}
}

