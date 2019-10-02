namespace DesignPatterns.AbstractFactory
{
    interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckBox();
    }
}
