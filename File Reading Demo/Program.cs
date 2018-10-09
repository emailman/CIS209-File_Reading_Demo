using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Reading_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty list of accounts
            var accounts = new List<Account3>();

            // Read the records store in a file
            ReadFile(accounts);

            // Show the list
            foreach (var acct in accounts)
                Console.WriteLine(acct);
        }

        static void ReadFile(List<Account3> accts)
        {
            try
            {
                string dataFile = "../../../../File Writing Demo/File Writing Demo/bin/Debug/accounts.txt";
                StreamReader inputFile = File.OpenText(dataFile);

                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file
                    string record = inputFile.ReadLine();

                    // Split the record with comma delimiter 
                    string[] tokens = record.Split(',');

                    // Add the record to the list
                    accts.Add(new Account3(tokens[0], decimal.Parse(tokens[1])));
                }
                inputFile?.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
