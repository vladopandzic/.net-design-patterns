using VP.DesignPatterns.AbstractMethodFactory.Example2.Buttons;
using VP.DesignPatterns.AbstractMethodFactory.Example2.Checkboxes;

namespace VP.DesignPatterns.AbstractMethodFactory.Example2;

public interface GUIFactory
{
    IButton CreateButton();

    ICheckbox CreateCheckbox();
}
