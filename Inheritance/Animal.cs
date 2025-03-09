using System;

namespace Inheritance;

public class Animal
{
    public int Age { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string GenderPronouns { get; set; }
    public bool HasOffspring { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"I'd like to introduce you to {Name}. {(GenderPronouns == "she/her"? "She" : "He")} is a/n {Type}. " +
                          $"{(GenderPronouns == "she/her"? "She" : "He")} is {Age} years old and had {(HasOffspring? "":"no ")}offspring. ");
    }
}
