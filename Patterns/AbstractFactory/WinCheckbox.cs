using System;

namespace Patterns.AbstractFactory
{
    class WinCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("Render Windows checkbox");
        }
    }
}
