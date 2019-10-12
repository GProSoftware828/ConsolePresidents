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

                try
                {
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
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter valid option. Enter 'Parties' to see party name formatting.");
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
            string[] lines = System.IO.File.ReadAllLines(@filepath);
            string[] breaker = { "Search completed" };

            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (recordMatches(searchTerm, fields, positionOfSearchTerm))
                {
                    Console.WriteLine("Record found");
                    return fields;
                }
            }
            return breaker;
        }

        public static string[] readFile(string filepath)
        {
            string[] breaker = { "Search completed" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                return lines;
                throw new FileNotFoundException();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File is not currently in our database. " + $"{ex.Message}");
            }
            catch (Exception)
            {
                Console.WriteLine("Error in running search from input.");
            }
            return breaker;
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