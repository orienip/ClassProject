using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {

        string individualName;
        int siteKey;
        string website;
        // char IsLetter;

        Dictionary<string, int> individuals =
            new Dictionary<string, int>(){
                                {"Jane Doe", 1},
                                {"John Doe", 2 }};

        Dictionary<int, string> socialMediaSites =
            new Dictionary<int, string>(){
                {1, "Facebook" },
                {2, "Twitter" },
                {3, "Instgram" },
                {4, "LinkedIn" }             
            };

            Regex letterAndSpaceCheck = new Regex("^[a-zA-Z ]+$");

            Console.WriteLine("Input a individual's name to find out their favorite social media site: ");
            do
            {
                individualName = Console.ReadLine();

                if (letterAndSpaceCheck.IsMatch(individualName) && individuals.ContainsKey(individualName)) // Here we need to also validate that the name exists in the dictionary
                {
                    individuals.TryGetValue(individualName, out siteKey);
                    socialMediaSites.TryGetValue(siteKey, out website);
                    Console.WriteLine(individualName + "'s favorite social media website is " + website);
                    Console.WriteLine("Input another individuals name or press ESC to quit: ");
                }
                else if (letterAndSpaceCheck.IsMatch(individualName) && individuals.ContainsKey(individualName) == false)
                {
                    Console.WriteLine("Invalide individual name. Please double check your spelling or enter a valid individual: ");
                }                   
                else
                {
                    Console.WriteLine("Invalid characters. Please enter a new name using only letters and spaces or press ESC to quit: ");
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);            
        }
    }
}

