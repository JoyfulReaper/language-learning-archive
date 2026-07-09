using System;

public class Sentence
{
    public int Words {get => words.Length;}
    private string[] words;
     Sentence(string sentence)
     {
         words = sentence.Split();
     }

     public override string ToString()
     {
         string output = String.Empty;
         foreach (string word in words)
         {
             output += word + " ";
         }
         return output.TrimEnd();
     }

     public string this [int wordNum] 
     {
         get { return words[wordNum - 1]; }
         set { words [wordNum - 1 ] = value; }
     }

     public static void Main()
     {
         Console.Write("Enter a sentence: ");
         string input = Console.ReadLine();

         Sentence sentence = new Sentence(input);

         Console.Write($"Enter an index: (1-{sentence.Words}): ");
         int index = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"At index {index}: {sentence[index]}");
         Console.Write("Enter the replacement: ");
         string replacement = Console.ReadLine();
         sentence[index] = replacement;
         Console.WriteLine(sentence);
     }
}