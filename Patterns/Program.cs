using Patterns.Prototype;
using Patterns.TemplateMethod;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateMethod();

            Console.ReadLine();
        }

        static void TemplateMethod()
        {
            var chess = new Chess();
            chess.Run();
        }

        static void Prototype()
        {
            // this class will be prototype
            var client = new Client("John", "Smit");
            client.Address = new Address("Riga");

            // here prototype is being copied
            var client2 = client.DeepCopy();
            client2.Name = "Sara";

            Console.WriteLine(client);
            Console.WriteLine(client2);
        }
    }
}
