using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string s1 = "Hello World";
        string s2 = (String)s1.Clone(); // Clone Function ------------------------------------------------------------------------------
        string s3 = "hello";
      
        Console.WriteLine (s1);
        Console.WriteLine (s2);

        Console.WriteLine(string.Compare(s1,s2)); // Compare Function -------------------------------------------------------------------
        Console.WriteLine (string.Concat(s1,s3)); // Concat Function --------------------------------------------------------------------
        Console.WriteLine(s1.Length); // Length of the string ---------------------------------------------------------------------------
        Console.WriteLine(s1.ToLower()); // ToLower Function-----------------------------------------------------------------------------
        Console.WriteLine(s1.ToUpper()); // ToUpper Function ----------------------------------------------------------------------------
        Console.WriteLine(s1.Contains("Hel")); // Contains Function ---------------------------------------------------------------------
        Console.WriteLine(s1.IndexOf("e")); // IndexOf Function -------------------------------------------------------------------------
    }
}
