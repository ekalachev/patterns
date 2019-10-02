using System;

namespace DesignPatterns.AbstractFactory
{
    class MacCheckbox : ICheckbox
    {
        public void paint()
        {
            Console.WriteLine("Render Mac checkbox");
        }
    }
}
