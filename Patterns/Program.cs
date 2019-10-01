using Patterns.Prototype;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype();

            Console.ReadLine();
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
