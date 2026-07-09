import java.util.Scanner;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.charset.StandardCharsets;
import java.nio.file.Path;

public class FileIO {
    public static void main(String[] args) throws IOException
    {   
        String dir = System.getProperty("user.dir");
        PrintWriter out = new PrintWriter("testFile.txt", StandardCharsets.UTF_8);
        Scanner sysIn = new Scanner(System.in);

        System.out.println("You are in " + dir);
        System.out.println("Enter text to save to the file: ");
        String input = "";
        while(!(input = sysIn.nextLine()).isEmpty())
            out.println(input);

        out.flush();

        Scanner in = new Scanner(Path.of("testFile.txt"), StandardCharsets.UTF_8);
        System.out.println("File Contents: ");
        while(in.hasNextLine())
            System.out.println(in.nextLine());

        in.close();
        out.close();
    }
}