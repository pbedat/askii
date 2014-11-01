using System;
using System.Windows.Forms;

namespace Askii
{
	public class ButtonParser
	{
		public MessageBoxButtons Parse(string str)
		{
			str = str.Replace ("Ok", "OK").Replace(",", string.Empty);

			return (MessageBoxButtons)Enum.Parse (typeof(MessageBoxButtons), str);
		}
	}
}

