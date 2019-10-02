using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Prototype;
using DesignPatterns.SOLID.LiskovSubstitution;
using DesignPatterns.SOLID.OpenClosed;
using DesignPatterns.TemplateMethod;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SOLIDLiskovSubstitutuion();

            Console.ReadLine();
        }

        static void SOLIDLiskovSubstitutuion()
        {
            RectangleWithViolatingLiskovSubstitutionPrinciple rcWithViolatingLiskovSubstitutionPrinciple = new RectangleWithViolatingLiskovSubstitutionPrinciple(2, 3);
            Console.WriteLine($"{rcWithViolatingLiskovSubstitutionPrinciple} has area {AreaWithViolatingLiskovSubstitutionPrinciple(rcWithViolatingLiskovSubstitutionPrinciple)}");

            // should be able to substitute a base type for a subtype
            /*Square*/
            RectangleWithViolatingLiskovSubstitutionPrinciple sqWithViolatingLiskovSubstitutionPrinciple = new RectangleWithViolatingLiskovSubstitutionPrinciple();
            sqWithViolatingLiskovSubstitutionPrinciple.Width = 4;
            Console.WriteLine($"{sqWithViolatingLiskovSubstitutionPrinciple } has area {AreaWithViolatingLiskovSubstitutionPrinciple(sqWithViolatingLiskovSubstitutionPrinciple)}");

            // Without violating Liskov Substitutuion Principle

            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            // should be able to substitute a base type for a subtype
            /*Square*/
            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");
        }

        static public int Area(Rectangle r) => r.Width * r.Height;
        static public int AreaWithViolatingLiskovSubstitutionPrinciple(RectangleWithViolatingLiskovSubstitutionPrinciple r) => r.Width * r.Height;

        static void SOLIDOpenClosed()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, Color.Green))
                Console.WriteLine($" - {p.Name} is green");

            // ^^ BEFORE

            // vv AFTER
            var bf = new BetterFilter();
            Console.WriteLine("Green products (new):");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {p.Name} is green");

            Console.WriteLine("Large products");
            foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
                Console.WriteLine($" - {p.Name} is large");

            Console.WriteLine("Large blue items");
            foreach (var p in bf.Filter(products,
              new BanchOfSpecifications<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)))
            )
            {
                Console.WriteLine($" - {p.Name} is big and blue");
            }
        }

        static void Singleton()
        {
            var singleton = DesignPatterns.Singleton.Singleton.Instance;
            var singleton2 = DesignPatterns.Singleton.Singleton.Instance;

            Console.WriteLine(singleton == singleton2);

            var singletonLazy = DesignPatterns.Singleton.SingletonLazy.Instance;
            var singletonLazy2 = DesignPatterns.Singleton.SingletonLazy.Instance;

            Console.WriteLine(singletonLazy == singletonLazy2);

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
