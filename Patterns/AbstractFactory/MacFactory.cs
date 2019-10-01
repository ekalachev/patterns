namespace Patterns.AbstractFactory
{
    class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
