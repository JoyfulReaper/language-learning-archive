// Interfaces and callbacks

package timer;

import java.awt.*;
import java.awt.event.*;
import java.time.*;
import javax.swing.*;

public class TimerTest 
{
    public static void main(String[] args)
    {
        var listener = new TimePrinter();

        // Construct a timer that calls the listener
        // once every second.
        var timer = new Timer(1000, listener);
        timer.start();

        // Keep program running untile the user selects OK
        JOptionPane.showMessageDialog(null, "Quit Program?");
        System.exit(0);
    }
}

class TimePrinter implements ActionListener
{
    public void actionPerformed(ActionEvent e)
    {
        System.out.println("At the tone, the time is " + 
            Instant.ofEpochMilli(e.getWhen()));
        Toolkit.getDefaultToolkit().beep();
    }
}