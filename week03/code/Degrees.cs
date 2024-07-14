using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

    /// <summary>
    /// Read a census file and summarize the degrees (education)
    /// earned by those contained in the file.  The summary
    /// should be stored in a dictionary where the key is the
    /// degree earned and the value is the number of people that 
    /// have earned that degree.  The degree information is in
    /// the 4th column of the file.  There is no header row in the
    /// file.
    /// </summary>
    /// <param name="filename">The name of the file to read</param>
    /// <returns>fixed array of divisors</returns>
    /// #############
    /// # Problem 2 #
    /// #############

public class Degrees
{
    public static Dictionary<string, int> SummarizeDegrees(string filename)
    {
        var degrees = new Dictionary<string, int>();

        try
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines.Skip(1)) // Skip the header line if it exists
            {
                string[] columns = line.Split(',');
                if (columns.Length >= 4)
                {
                    string degree = columns[3].Trim();
                    if (!string.IsNullOrEmpty(degree))
                    {
                        if (degrees.ContainsKey(degree))
                        {
                            degrees[degree]++;
                        }
                        else
                        {
                            degrees[degree] = 1;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
        }

        return degrees;
    }

    public static void Run()
    {
        var result = SummarizeDegrees("census.txt");
        Console.WriteLine(string.Join(", ", result.Select(kv => $"{kv.Key}: {kv.Value}")));
    }
}