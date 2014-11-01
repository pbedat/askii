using System;

namespace Askii
{
	public static class StringExtensions
	{
		public static RendererResult Render(this string str)
		{
			return new Renderer ().Render (str);
		}
	}
}

