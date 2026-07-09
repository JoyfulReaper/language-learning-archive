namespace ReimplementInterface
{
    public interface IUndoable { void Undo(); }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class ExTextBox : IUndoable
    {
        void IUndoable.Undo() => System.Console.WriteLine("TextBox.Undo"); // Explict definition
    }

    public class ExRichTextBox : ExTextBox, IUndoable // Inherit and use interface
    {
        public void Undo() => System.Console.WriteLine("RichTextBox.Undo");
    }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class ImTextBox : IUndoable
    {
        public void Undo() => System.Console.WriteLine("TextBox.Undo"); // Implicit definition
    }

    public class ImRichTextBox : ImTextBox, IUndoable // Inherit and use interface
    {
        public void Undo() => System.Console.WriteLine("RichTextBox.Undo");
    }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class Program
    {
        public static void Main()
        {
            ExRichTextBox xr = new ExRichTextBox();
            xr.Undo();
            ((IUndoable)xr).Undo();
            //((ExTextBox)xr).Undo(); // Now I think it makes sense?

            System.Console.WriteLine();

            ImRichTextBox ir = new ImRichTextBox();
            ir.Undo();
            ((IUndoable)ir).Undo();
            ((ImTextBox)ir).Undo(); // Re-Implementation only works when a member is called through the interface, and not through the base class.
        }
    }
}