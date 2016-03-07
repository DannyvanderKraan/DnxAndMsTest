using System;

namespace SomeDnxProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var messageMaker = new MessageMaker();
			Console.WriteLine(messageMaker.GetMessage());
        }
    }
}