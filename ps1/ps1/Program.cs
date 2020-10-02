using System;

namespace ps1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Quan Tran";
            string greet1 = $"hello {name}!";
            string greet2 = "Hello " + name + "!";
            string greet3 = String.Format("Hello {0}! {1} {2}", name, greet1, greet2);
            string greetTemplate = "Hello **NAME**";
            Console.WriteLine(name);
            Console.WriteLine(greet3);
            Console.WriteLine(greetTemplate.Replace("**NAME**", name));
        }
    } 
}
