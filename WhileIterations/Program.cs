using System;
using System.IO;

namespace WhileIterations
{
    class MainClass
    {
        // Tell Visual Studios to copy the Values.txt file into the project bin
        public static void Main(string[] args)
        {

            try{
				// StreamReader doesn't live in the default name spaces (in system.io)
				// Sucks in data little by little from Values.txt file
				StreamReader myReader = new StreamReader("//boo//Values.txt");
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
			}
           
            // TRI CATCH BLOCK

            // Error messages can be lazy, only error message to let them fix it
            // special cases first, then more general
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Could not find the file. Are you sure the DIRECTORY exists?");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Could not find the file. Are you sure you're looking for the correct one?");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something didn't quite work correctly: {0}", e.Message);
            }
            finally
            {
                // Performs any cleanup to roll back the data or close connections
                // to files, databases, network, etc.
            }

            // Protect the user from the having to try to figure it out on their own
            // Try to identify the exact problem, ask for the right input


            Console.ReadLine();
        }
    }
    // Important Concepts

    // While Iteration statement when there is an indeterminate times to iterate
    // Stream Reader class - suck in data line by line from text using ReadLine
    // Close connection/hold of text file
    // Provide using statement for other classes
}
