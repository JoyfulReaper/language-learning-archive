/**
 * This program displays a gretting for the reader.
 * @version 1.0.0 2020-06-20
 * @author Kyle Givler
 * Based on program in Core Java Volume 1 by Cay Horstmann
 */

 public class Welcome
 {
     public static void main(String[] args)
     {
         String greeting = "Of course this says Hello World!";
         System.out.println(greeting);
         for(int i = 0; i < greeting.length(); i++)
            System.out.print('=');
        System.out.println();
     }
 }