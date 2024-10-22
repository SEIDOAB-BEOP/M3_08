using System;

namespace BOOPM3_08_05a
{
    class Program
    {
        static void Main(string[] args)
        {
            //NON singleton pattern
            System.Console.WriteLine("NON Singleton pattern");
            System.Console.WriteLine(new csPasswordManager().Password1);
            System.Console.WriteLine(new csPasswordManager().Password2);

            //some other part of your code
            System.Console.WriteLine(new csPasswordManager().Password1);
            System.Console.WriteLine(new csPasswordManager().Password2);

            //yet some other part of your code
            System.Console.WriteLine(new csPasswordManager().Password1);
            System.Console.WriteLine(new csPasswordManager().Password2);

            //WITH singleton pattern
            System.Console.WriteLine("\nWITH Singleton pattern");

            System.Console.WriteLine(csPasswordManager.Instance.Password1);
            System.Console.WriteLine(csPasswordManager.Instance.Password2);

            System.Console.WriteLine(csPasswordManager.Instance.Password1);
            System.Console.WriteLine(csPasswordManager.Instance.Password2);

            //some other part of your code
            System.Console.WriteLine(csPasswordManager.Instance.Password1);
            System.Console.WriteLine(csPasswordManager.Instance.Password2);

            //some other part of your code
            System.Console.WriteLine(csPasswordManager.Instance.Password1);
            System.Console.WriteLine(csPasswordManager.Instance.Password2);

            //some other part of your code
            System.Console.WriteLine(csPasswordManager.Instance.Password1);
            System.Console.WriteLine(csPasswordManager.Instance.Password2);

            //some other part of your code
            System.Console.WriteLine(csPasswordManager.Instance.Password1);
            System.Console.WriteLine(csPasswordManager.Instance.Password2);

            //some other part of your code
            System.Console.WriteLine(csPasswordManager.Instance.Password1);
            System.Console.WriteLine(csPasswordManager.Instance.Password2);
            //Maybe your code needs the passwords 100 times
        }
    }
}
