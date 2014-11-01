using System;
using NUnit.Framework;
using System.Windows.Forms;

namespace Askii.Tests
{
	[TestFixture]
	public class ButtonParserFixture
	{
		[TestCase("Ok", MessageBoxButtons.OK)]
		[TestCase("OK", MessageBoxButtons.OK)]
		[TestCase("Ok,Cancel", MessageBoxButtons.OKCancel)]
		[TestCase("Yes,No,Cancel", MessageBoxButtons.YesNoCancel)]
		[TestCase("Yes,No", MessageBoxButtons.YesNo)]
		[TestCase("Abort,Retry,Ignore", MessageBoxButtons.AbortRetryIgnore)]
		[TestCase("Retry,Cancel", MessageBoxButtons.RetryCancel)]
		public void Test(string str, MessageBoxButtons buttons)
		{
			Assert.That (new ButtonParser ().Parse (str), Is.EqualTo (buttons));
		}
	}
}

