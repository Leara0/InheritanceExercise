using System;

namespace Inheritance;

public class Reptile: Animal
{
    public int TailLength { get; set; }
    public bool LivesInWater { get; set; }
    public bool HasShell { get; set; }
    public int NumberOfTeeth { get; set; }

    public void IntroduceRept()
    {
        Console.WriteLine($"{Name} {(LivesInWater? "lives " : "does not live ")}in water. {(GenderPronouns == "she/her"? "Her" : "His")} " +
                          $"tail length is {TailLength} and they have {(NumberOfTeeth ==0? "no ": "")}teeth. " +
                          $"{(GenderPronouns == "she/her"? "She" : "He")} {(HasShell? "has ": "does not have ")}a shell.");
    }
}