using System;

namespace Cebolinha
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			Console.WriteLine("Digite o que quiser, o Cebolinha irá repetir...:");
			string Frase = Console.ReadLine();
			Console.Clear();
			string Cebolinha = Frase
			    .Replace("r" , "l")
			    .Replace("R" , "L");
			Console.WriteLine(Cebolinha);
        }
    }
}