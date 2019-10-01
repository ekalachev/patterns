namespace Patterns.AbstractFactory
{
    class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new WinCheckbox();
        }
    }
}
