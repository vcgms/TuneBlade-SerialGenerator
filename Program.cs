using System;

namespace BreakFreeAudioKeyMaker
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Input a email address as License ID: ");
			Console.WriteLine("TuneBlade License Key: " + TuneBlade.Generate(Console.ReadLine()));
			Console.Write("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
