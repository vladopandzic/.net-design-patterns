using VP.DesignPatterns.AbstractMethodFactory.Example2.Buttons;
using VP.DesignPatterns.AbstractMethodFactory.Example2.Checkboxes;

namespace VP.DesignPatterns.AbstractMethodFactory.Example2;

public class WindowsGUIFactory : GUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}
