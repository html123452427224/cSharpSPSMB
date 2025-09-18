using OopExamples.Interfaces;

namespace OopExamples.classes;

public class Computer : IComputer
{
    
    public IEntity Owner { get; init; }
    public IMotherBoard MotherBoard { get; init; }
    public ICPU Cpu { get; init; }
    public IGPU Gpu { get; init; }
    public IRAM Ram { get; init; }
    public IPowerSupply PowerSupply { get; init; }
    public ICase Case { get; init; }
    public IMonitor[]  Monitors { get; init; }
    
    public bool IsOn { get; init; }

    public bool IsPersonalPC { get; }

    public bool IsCompanyPC { get; }


    public void PowerUp()
    {
        if (IsOn == false)
        {
            Console.WriteLine("turning on the computer");
            
        }
        
    }

    public void ShutDown()
    {
        if (IsOn == true)
        {
            Console.WriteLine("shutting down the pc");
        }
        else
        {
          Console.WriteLine("the computer isnt on ");  
        }
    }


    public void PressPowerButton()
    {
        if (IsOn == true)
        {
            PowerUp();
        }
        else
        {
            ShutDown();
        }
    }


    public void Print(string text)
    {
        Console.WriteLine(text);
    }

    public float Compute(string equation)
    {
        
    }
}