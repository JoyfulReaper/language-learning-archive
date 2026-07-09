using System;

namespace EventExample
{
    public class TriggerWordEventArgs : EventArgs
    {
        public readonly string word;

        public TriggerWordEventArgs(string word)
        {
            this.word = word;
        }
    }

    public class TextScanner
    {
        public event EventHandler<TriggerWordEventArgs> wordFound;
        private string triggerWord;

        public TextScanner(string triggerWord)
        {
            this.triggerWord = triggerWord;
        }

        public bool Scan(string text)
        {
            if (text.Contains(triggerWord))
            {
                OnwordFound(new TriggerWordEventArgs(triggerWord));
                return true;
            }

            return false;
        }

        protected virtual void OnwordFound(TriggerWordEventArgs e)
        {
            wordFound?.Invoke(this, e);
        }
    }

    public class EventExample
    {
        public static void Main()
        {
            Console.Write("What is the trigger word? " );
            var triggerWord = Console.ReadLine();
            Console.WriteLine();

            TextScanner scanner = new TextScanner(triggerWord);
            scanner.wordFound += Wordfound;

            Console.WriteLine("Enter text to scan: ");
            var text = Console.ReadLine();

            scanner.Scan(text);
        }

        private static void Wordfound(object sender, TriggerWordEventArgs e)
        {
            Console.WriteLine($"Trigger word ({e.word}) found!");
        }
    }
}