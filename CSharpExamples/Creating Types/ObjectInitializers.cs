using System;

public class Bunny
{
    // These fields are accessible:
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;

    public Bunny() {}
    public Bunny(string Name) {this.Name = Name; }

    public static void Main()
    {
        // Use object initialzers to set fields and properties directly after construction:
        // Constructors with no paramaters do not need parentheses
        Bunny b1 = new Bunny { Name = "Shelly", LikesCarrots=false, LikesHumans=false };

        Bunny b2 = new Bunny("Fred") { LikesCarrots=true, LikesHumans=true };

        Bunny[] bunnies = {b1, b2};
        foreach (var b in bunnies)
        {
            Console.WriteLine("{0} {1} humans and {2} carrots", b.Name, b.LikesHumans ? "likes" : "doesn't like", b.LikesCarrots ? "likes" : "doesn't like");
        }
    }
}