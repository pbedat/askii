using System;
using System.Windows.Forms;

namespace Askii
{
	public class Renderer
	{
		public RendererResult Render(string str)
		{
			var tokens = new Lexer ().Tokenize (str);
			var template = new Parser ().Parse (tokens);

			var result = MessageBox.Show (template.Message, template.Title, template.Buttons, template.Icon);
		
			return new RendererResult (result);
		}
	}

	public class RendererResult
	{
		DialogResult result;

		public RendererResult (DialogResult result)
		{
			this.result = result;
		}

		public RendererResult When(DialogResult result, Action action)
		{
			if (this.result == result)
				action ();

			return this;
		}
	}
}

