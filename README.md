askii
=====

Render strings to message boxes!

	public static void Main (string[] args)
	{
		var box = "" +
		          "==========================================================" +
		          "| Look Ma'                                               |" +
		          "==========================================================" +
		          "| (i) Hi,                                                |" +
		          "|     this is a nice message, isn't it?                  |" +
		          "|--------------------------------------------------------|" +
		          "|                   [ Yes ] [ No ]                       |" +
		          "==========================================================";

		box.Render ()
			.When (DialogResult.Yes, ThankYou)
			.When (DialogResult.No, () => System.Console.WriteLine ("How dare you??"));
	}

	static void ThankYou ()
	{
		System.Console.WriteLine ("Thank you!");
	}
