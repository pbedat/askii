using System;
using Askii;
using System.Windows.Forms;
using System.Resources;

namespace Askii.Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var str = "" +
			          "==========================================================" +
			          "| Look Ma'                                               |" +
			          "==========================================================" +
			          "| (i) Hi,                                                |" +
			          "|     this is a nice message, isn't it?                  |" +
			          "|--------------------------------------------------------|" +
			          "|                   [ Yes ] [ No ]                       |" +
			          "==========================================================";

			str.Render ()
				.When (DialogResult.Yes, ThankYou)
				.When (DialogResult.No, () => System.Console.WriteLine ("How dare you??"));
		}

		static void ThankYou ()
		{
			System.Console.WriteLine ("Thank you!");
		}
	}
}
