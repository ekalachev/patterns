using System;

namespace DesignPatterns.AbstractFactory
{
    class WinButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("Render Windows button");
        }
    }
}
