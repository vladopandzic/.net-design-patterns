using VP.DesignPatterns.AbstractMethodFactory.Example2.Buttons;
using VP.DesignPatterns.AbstractMethodFactory.Example2.Checkboxes;

namespace VP.DesignPatterns.AbstractMethodFactory.Example2;

public class MacGUIFactory : GUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}
