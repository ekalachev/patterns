using System;

namespace Patterns.AbstractFactory
{
    class MacCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("Render Mac checkbox");
        }
    }
}
