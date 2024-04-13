namespace VP.DesignPatterns.Builder;

public class Computer
{
    public string CPU { get; set; }

    public string GPU { get; set; }

    public int RAM { get; set; }

    public int Storage { get; set; }

    public void Display()
    {
        Console.WriteLine($"Computer with {CPU} CPU, {GPU} GPU, {RAM}GB RAM, and {Storage}GB storage.");
    }
}