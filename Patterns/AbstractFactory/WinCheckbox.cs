using System;

namespace DesignPatterns.AbstractFactory
{
    class WinCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("Render Windows checkbox");
        }
    }
}
