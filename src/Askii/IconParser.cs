using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Askii
{
	public class IconParser
	{
		private static readonly Dictionary<string, MessageBoxIcon> ICON_MAP = new Dictionary<string, MessageBoxIcon>
		{
			{ "(i)", MessageBoxIcon.Information },
			{ "(!)", MessageBoxIcon.Exclamation },
			{ "(?)", MessageBoxIcon.Question },
			{ "(x)", MessageBoxIcon.Stop }
		};


		public MessageBoxIcon Parse(string str)
		{
			return ICON_MAP [str.Trim ()];
		}
	}
}

