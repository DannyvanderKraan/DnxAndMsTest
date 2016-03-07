using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeDnxProject;

namespace SomeDnxProject.MSTest
{
	[TestClass]
	public class MessageMakerTests
	{
		public MessageMakerTests()
		{
		}

		[TestMethod]
		public void GetMessage_GivenNone_ExpectedDefault()
		{
			var expectedMessage = "Hello from DNX!";
			var messageMaker = new MessageMaker();
			var message = messageMaker.GetMessage();
			Assert.AreEqual(expectedMessage, message);
		}
	
	}
}
