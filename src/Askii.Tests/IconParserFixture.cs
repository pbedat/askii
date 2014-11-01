using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace Askii.Tests
{
	[TestFixture ()]
	public class IconParserFixture
	{
		[TestCase ("(i)", MessageBoxIcon.Information)]
		[TestCase ("(!) ", MessageBoxIcon.Exclamation)]
		[TestCase (" (x)", MessageBoxIcon.Stop)]
		[TestCase (" (-) ", MessageBoxIcon.Stop)]
		[TestCase (" (?) ", MessageBoxIcon.Question)]
		public void TestCase (string str, MessageBoxIcon icon)
		{
			Assert.That (new IconParser ().Parse (str), Is.EqualTo (icon));
		}
	}
}

