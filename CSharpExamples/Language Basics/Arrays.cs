using System;

class ArrayTest{
    public static void Main()
    {
        char [] vowels = new char[5]; // Creating an array preinitiliazes all elements with default values (bitwize or with zero).

        vowels[0] = 'a';
        vowels[1] = 'e';
        vowels[2] = 'i';
        vowels[3] = 'o';
        vowels[4] = 'u';
        Console.WriteLine("vowels[1]: {0}\n", vowels[1]);


        char[] vowelsAgain = new char[] { 'a', 'e', 'i', 'o', 'u'}; // array initialization expression. char[] vowels = { 'a', 'e', 'i', 'o', 'u'}; is also valid.

        for(int i = 0; i < vowelsAgain.Length; i ++) // Length Property is the number of elements in an array. Can not be changed after creation.
            Console.WriteLine("vowelsAgain[{0}]: {1}", i, vowelsAgain[i]);
    }
}