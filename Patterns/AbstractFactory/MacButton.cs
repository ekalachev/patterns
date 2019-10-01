using System;

namespace Patterns.AbstractFactory
{
    class MacButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("Render Mac button");
        }
    }
}
