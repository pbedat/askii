using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Askii.Tests
{
	[TestFixture ()]
	public class LexerFixture
	{
		Dictionary<string, string> tokens;

		[SetUp]
		public void Setup()
		{
			var lexer = new Lexer ();

			this.tokens =  lexer.Tokenize("" +
				"==============================" +
				"| Titel                      |" +
				"|============================|" +
				"| (i) Check this out!        |" +
				"|     This is a Message =)   |" +
				"|----------------------------|" +
				"|     [ Ok ] [ Cancel ]      |" +
				"=============================="
			);
		}

		[Test ()]
		public void Titel ()
		{
			Assert.That (tokens["Title"], Is.EqualTo ("Titel"));
		}

		[Test()]
		public void Icon()
		{
			Assert.That (tokens ["Icon"], Is.EqualTo ("(i)"));
		}

		[Test()]
		public void Message()
		{
			Assert.That(tokens["Message"], Is.EqualTo("Check this out!" + Environment.NewLine + "This is a Message =)"));
		}

				[Test]
		public void Buttons()
		{
			Assert.That (tokens ["Buttons"], Is.EqualTo ("Ok,Cancel"));
		}
	}
}

