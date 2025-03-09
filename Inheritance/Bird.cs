using System;
using System.ComponentModel.DataAnnotations;

namespace Inheritance;

public class Bird : Animal
{
    public bool CanFly { get; set; }
    public string BeakColor { get; set; }
    public int WingSpan { get; set; }
    public string BirdSong { get; set; }

    public void IntroduceBird()
    {
        Console.WriteLine($"{Name} can {(CanFly? "not " : "")}fly. {(GenderPronouns == "she/her"? "Her" : "His")} " +
                          $"beak color is {BeakColor} and wingSpan is {WingSpan}. Their bird song is {BirdSong}.");
    }
}