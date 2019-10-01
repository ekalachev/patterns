namespace Patterns.AbstractFactory
{
    interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckBox();
    }
}
