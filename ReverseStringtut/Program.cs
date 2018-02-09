using System;
using System.Linq;

namespace ReverseStringtut
{
    class Program
    {
        static void Main(string[] args)
        {
			string inputString = "iyosiyas meseret simret helina jerusalem abush nahom caleb amukaw mestawot amanuel semayat";
			string resultString = string.Join(" ", inputString.Split(' ')
				.Select(x => new string(x.Reverse().ToArray())));

			Console.WriteLine(resultString);
			Console.ReadLine();
        }
    }
}
