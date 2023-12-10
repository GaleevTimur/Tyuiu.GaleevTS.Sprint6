using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint6.Task6.V28.Lib
{
    public class DataService : ISprint6Task6V28
    {
        public string CollectTextFromFile(string path)
        {
            try
            {
                
                string[] lines = File.ReadAllLines(path);

                
                string result = "";

                
                foreach (string line in lines)
                {
                    
                    string[] words = line.Split(' ');

                    
                    if (words.Length >= 2)
                    {
                        
                        result += words[words.Length - 2] + " ";
                    }
                }

                
                return result.Trim();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
