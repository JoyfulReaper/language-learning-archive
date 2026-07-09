// Using delegate with an instance method requires the delegate object to maintain
// a reference to the target method AND the target object

namespace InstanceMethodTarget
{
    class Program
    {
        public delegate void InsanceMessage(string message);
        public static void Main()
        {
            TargetClass target = new TargetClass();
            InsanceMessage im = target.InstanceMethodMessage;

            im("Delegate message");

            System.Console.WriteLine("im.Target == target: {0}", im.Target == target);
            System.Console.WriteLine("im.Method: {0}", im.Method);
        }
    }

    class TargetClass
    {
        public void InstanceMethodMessage(string message)
        {
            System.Console.WriteLine($"This is an instance method: {this}");
            System.Console.WriteLine($"Message: {message}\n");
        }
    }
}