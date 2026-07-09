using System;
class Sentence
{
    string[] words;

    public string this [int wordNum] // indexer
    {
        get => words[wordNum];
        set => words[wordNum] = value;
    }

    public int Length { 
        get => words.Length;
    }

    public Sentence(string input)
    {
        words = input.Split();
    }

    public static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string input = Console.ReadLine();

        Sentence sentence = new Sentence(input);
        while(true)
            {
            Console.Write("What index 0 to {0} should be displayed: ", sentence.Length -1);
            if(!Int32.TryParse(Console.ReadLine(), out int index) || index >= sentence.Length)
            {
                Console.WriteLine("Invalid Index");
                return;
            }
            Console.WriteLine("sentence[{0}]: {1}", index, sentence[index]);
            }
    }
}