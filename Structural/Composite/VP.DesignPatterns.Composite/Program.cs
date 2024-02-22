using VP.DesignPatterns.Composite.Example1;
using VP.DesignPatterns.Composite.Example2;

namespace VP.DesignPatterns.Composite;

internal class Program
{
    static void Main(string[] args)
    {
        var save = new LeafMenuItem("Save");
        var saveAs = new LeafMenuItem("Save as");
        var exportToPdf = new LeafMenuItem("Export to PDF");
        var exportToWord = new LeafMenuItem("Export to Word");

        var export = new MenuItem("Export to", new List<IMenuItem>() { exportToPdf, exportToWord });

        var menu = new MenuItem("File menu", new List<IMenuItem>() { save, saveAs, export });

        menu.Display();


        var node1 = new CanNetworkNode("Node 1");
        var node2 = new CanNetworkNode("Node 2");
        var node3 = new CanNetworkNode("Node 3");

        var subNetwork1 = new CanNetwork("Sub-Network 1", new List<ICanNetworkComponent>() { node1, node2 });
        var subNetwork2 = new CanNetwork("Sub-Network 2", new List<ICanNetworkComponent>() { node3 });
        var mainCANNetwork = new CanNetwork("Main CAN Network", new List<ICanNetworkComponent>() { subNetwork1, subNetwork2 });

        mainCANNetwork.Display();

        Console.ReadKey();
    }
}
