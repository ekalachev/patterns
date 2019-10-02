using System;

namespace DesignPatterns.AbstractFactory
{
    class MacButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("Render Mac button");
        }
    }
}
