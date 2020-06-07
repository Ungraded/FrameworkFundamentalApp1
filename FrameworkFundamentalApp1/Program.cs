using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkFundamentalApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // change char according to localization
            char mychar = 'i';
            char mychartoo = System.Char.ToUpper(mychar);
            //char mychartoo = Char.ToUpperInvariant(mychar);
            Console.WriteLine(mychartoo);
            Console.WriteLine(mychar);

            string mystring = "Hello World!";
            Console.Write(new string('A', 5)); // creates AAAAA
            char[] mychararray = mystring.ToCharArray();

            //string test = "Temp is " {0} " degrees in " {1} " and time is " {2} ".";

            // Globalization
            CultureInfo test = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            Console.WriteLine("\n" + CultureInfo.CurrentCulture);
            double result = default;
            string syöte = Console.ReadLine();
            bool correct = double.TryParse(syöte, out result);
            Console.WriteLine(result);
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI", false);
            Console.WriteLine(result);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Now + new TimeSpan(1, 30, 0));

            StringBuilder asia = new StringBuilder(DateTime.Now.ToString());
            asia.Append(": ");
            asia.Append(result);
            Console.WriteLine(asia);

            // Working with numbers
            
            BigInteger BI = (BigInteger)1E100;

            //---------------------------
            // Firstsaveexistingoutput writer:
            System.IO.TextWriter oldOut = Console.Out;
            // Redirecttheconsole'soutput to a file:
            using(System.IO.TextWriter w = System.IO.File.CreateText("output.txt")) {
                Console.SetOut(w);Console.WriteLine("HelloWorld!");
            }
            // Restores tandard console output
            Console.SetOut(oldOut);
            // Open theoutput.txt file in Notepad:
            System.Diagnostics.Process.Start("output.txt");
            //---------------------------

            Console.WriteLine(BI);


            Console.ReadLine();
        }
    }
}
