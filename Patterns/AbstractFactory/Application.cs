using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractFactory
{
    class Application
    {
        private IGUIFactory factory;
        private IButton button;
        private ICheckbox checkbox;

        public Application(IGUIFactory factory)
        {
            this.factory = factory;
        }

        public void CreateUI()
        {
            this.button = this.factory.CreateButton();
            this.checkbox = this.factory.CreateCheckBox();
        }

        public void Paint()
        {
            this.button.paint();
            this.checkbox.paint();
        }
    }
}
