using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListOfUSAPresidents
{
    abstract class Call
    {
        public abstract void CallWH();
    }
    class Program : Call
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("Enter Parties for list of political parties, enter Presidents for list of U.S. Presidents, enter each party by party name for a party description:");
                string input;
                input = Console.ReadLine();

                if (input == "Whigs" || input == "Republicans" || input == "Democrats" || input == "Democratic-Republicans" || input == "Federalists" || input == "Unaffiliated" || input == "Bull Moose Party" || input == "Progressive Party" || input == "Socialist Party" || input == "National Union Party" || input == "Green Party of the United States")
                {
                    Console.WriteLine(string.Join("", readRecord(input, "C:/Users/PC33425/Desktop/ListOfUSAPresidents/PoliticalPartySynopses.txt", 1)));
                }
                if (input == "Parties")
                {
                    Console.WriteLine(string.Join("", readFile("C:/Users/PC33425/Desktop/ListOfUSAPresidents/PoliticalParties.txt")));
                }
                if (input == "Presidents")
                {
                    Program p = new Program();
                    p.CallWH();
                }
            } while (1 < 2);
        }

        public override void CallWH()
        {
            Console.WriteLine(string.Join("", readFile("C:/Users/PC33425/Desktop/ListOfUSAPresidents/ListOfPresidents.txt")));
        }

        public static string[] readRecord(string searchTerm, string filepath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = { "Record not found" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine("Record found");
                        return fields;
                    }
                }

                return recordNotFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Search term not found.");
                return recordNotFound;
                throw new ApplicationException("Search term not found :", ex);
            }
        }

        public static string[] readFile(string filepath)
        {
            string[] recordNotFound = { "Record not found" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                return lines;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Search term not found.");
                return recordNotFound;
                throw new ApplicationException("Search term not found :", ex);
            }
        }

        public static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }
    }
}