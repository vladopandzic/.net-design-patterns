using VP.DesignPatterns.AbstractMethodFactory.Example2.Buttons;
using VP.DesignPatterns.AbstractMethodFactory.Example2.Checkboxes;

namespace VP.DesignPatterns.AbstractMethodFactory.Example2;

public class GUIApplication
{
    readonly GUIFactory _guiFactory;

    public IButton Button { get; set; }

    public ICheckbox Checkbox { get; set; }

    public GUIApplication(GUIFactory guiFactory)
    {
        _guiFactory = guiFactory;
    }

    public void CreateUI()
    {
        Button = _guiFactory.CreateButton();
        Checkbox = _guiFactory.CreateCheckbox();
    }
}
