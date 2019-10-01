using System;

namespace Patterns.AbstractFactory
{
    class WinButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("Render Windows button");
        }
    }
}
