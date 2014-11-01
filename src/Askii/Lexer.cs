using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Askii
{
	public class Lexer
	{
		public Dictionary<string,string> Tokenize(string str)
		{
			const string DELIMITER = "|";

			var lines = str
				.Trim('=')
				.Split ('|')
				.Where (s => !string.IsNullOrEmpty(s));

			var tokens = new Dictionary<string, string> ();

			tokens.Add ("Title", lines.First ().Trim ());

			lines = lines.Skip (2);

			var body = lines.TakeWhile(line => !line.StartsWith("-"));

			tokens.Add ("Icon", body.First ().Substring (1, 3)); 

			tokens.Add ("Message", body.Select (line => line.Substring (5).Trim()).Aggregate ((l1, l2) => String.Format ("{0}{1}{2}", l1, Environment.NewLine, l2)));

			var footer = lines.SkipWhile (line => !line.StartsWith ("-")).Skip (1).First();

			tokens.Add ("Buttons", "");

			var regex = new Regex ( @"\[([\sa-zA-Z]+)\]");

			foreach (var match in regex.Matches(footer)) {

				tokens ["Buttons"] += (match as Match).Groups[1].Value.Trim() + ",";
			}

			tokens ["Buttons"] = tokens ["Buttons"].Trim (',');

			return tokens;
		}
	}
}

