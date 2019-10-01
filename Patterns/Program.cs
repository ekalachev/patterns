using Patterns.AbstractFactory;
using Patterns.Builder;
using Patterns.Prototype;
using Patterns.TemplateMethod;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder();

            Console.ReadLine();
        }

        static void Builder()
        {
            var director = new Director();

            var sportCar = director.ConstructSportCar(new CarBuilder());
            var manual = director.ConstructSportCar(new ManualBuilder());

            Console.WriteLine(sportCar);
            Console.WriteLine(manual);
            Console.ReadLine();
        }

        static void AbstractFactory()
        {
            var os = "";
            Console.WriteLine("Enter your OS (mac or win): ");

            do
            {
                os = Console.ReadLine();
            }
            while (os != "win" && os != "mac") ;

            IGUIFactory factory;

            if (os == "mac")
                factory = new MacFactory();
            else
                factory = new WinFactory();

            var app = new Application(factory);
            app.CreateUI();
            app.Paint();

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
