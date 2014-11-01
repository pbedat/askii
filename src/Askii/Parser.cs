using System;
using System.Collections.Generic;

namespace Askii
{
	public class Parser
	{
		public Template Parse(Dictionary<string, string> tokens){
			return new Template{
				Title = tokens["Title"],
				Icon = new IconParser().Parse(tokens["Icon"]),
				Message = tokens["Message"],
				Buttons = new ButtonParser().Parse(tokens["Buttons"])
			};
		}
	}
}

