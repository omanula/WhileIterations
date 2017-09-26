using System;
using System.IO;

namespace WhileIterations
{
    class MainClass
    {
        // Tell Visual Studios to copy the Values.txt file into the project bin
        public static void Main(string[] args)
        {
            // StreamReader doesn't live in the default name spaces (in system.io)
            // Sucks in data little by little from Values.txt file
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";

            // Null value = unknown/indeterminate value
            // While - inside determines whether to continue to cancel out
            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            // failure to close the file can leave a reference to the file open
            // and prevent other users/applications from accessing the file
            Console.ReadLine();
        }
    }
    // Important Concepts

    // While Iteration statement when there is an indeterminate times to iterate
    // Stream Reader class - suck in data line by line from text using ReadLine
    // Close connection/hold of text file
    // Provide using statement for other classes
}
