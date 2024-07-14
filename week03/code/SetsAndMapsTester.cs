using System;
using System.Net.Http;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;


public static class SetsAndMapsTester {

    /// <summary>
    /// Sets up the maze dictionary for problem 4
    /// </summary>
    private static Dictionary<(int, int), bool[]> SetupMazeMap() {


        /// Defines a maze using a dictionary. The dictionary is provided by the
        /// user when the Maze object is created. The dictionary will contain the
        /// following mapping:
        ///
        /// (x,y) : [left, right, up, down]
        ///
        /// 'x' and 'y' are integers and represents locations in the maze.
        /// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
        ///
        /// If a direction is false, then we can assume there is a wall in that direction.
        /// If a direction is true, then we can proceed.  
        ///

        var map = new Dictionary<(int, int), bool[]>();

        // Initialize all Maze cells
        for (int x = 1; x <= 6; x++) {
            for (int y = 1; y <= 6; y++) {
                map[(x, y)] = new bool[] { true, true, true, true };
            }
        }

        // Set up Maze internal walls
        var internalWalls = new List<(int, int)>
        {
            (3, 1), (3, 2), (3, 3), (4, 2), (6, 2), (1, 3),
            (6, 4), (2, 5), (4, 5), (6, 5), (2, 6), (4, 6)
        };

        foreach (var wall in internalWalls) {
            int x = wall.Item1;
            int y = wall.Item2;

            if (x > 1) map[(x - 1, y)][1] = false; // Right wall for left cell
            if (x < 6) map[(x + 1, y)][0] = false; // Left wall for right cell
            if (y > 1) map[(x, y - 1)][3] = false; // Bottom wall for upper cell
            if (y < 6) map[(x, y + 1)][2] = false; // Top wall for lower cell
        }

        /// Set up outer walls & directions
        ///              Top direction
        ///                  [2]
        /// Left direction [0] [1] Right direction
        ///                  [3]
        ///             Bottom direction
        for (int x = 1; x <= 6; x++) {
            map[(x, 1)][2] = false; // Top row
            map[(x, 6)][3] = false; // Bottom row
        }
        for (int y = 1; y <= 6; y++) {
            map[(1, y)][0] = false; // Left column
            map[(6, y)][1] = false; // Right column
        }

        return map;
    }


    public static void Run() {   
        // Problem 1: Find Pairs with Sets
        Console.WriteLine("\n=========== Finding Pairs TESTS ===========");
        DisplaySymmetricPairs.DisplayPairs(new[] { "am", "at", "ma", "if", "fi" });
        // ma & am
        // fi & if
       Console.WriteLine("---------");
        DisplaySymmetricPairs.DisplayPairs(new[] { "ab", "bc", "cd", "de", "ba" });
        // ba & ab
        Console.WriteLine("---------");
        DisplaySymmetricPairs.DisplayPairs(new[] { "ab", "ba", "ac", "ad", "da", "ca" });
        // ba & ab
        // da & ad
        // ca & ac
        Console.WriteLine("---------");
        DisplaySymmetricPairs.DisplayPairs(new[] { "ab", "ac" }); // No pairs displayed
        Console.WriteLine("---------");
        DisplaySymmetricPairs.DisplayPairs(new[] { "ab", "aa", "ba" });
        // ba & ab
        Console.WriteLine("---------");
        DisplaySymmetricPairs.DisplayPairs(new[] { "23", "84", "49", "13", "32", "46", "91", "99", "94", "31", "57", "14" });
        // 32 & 23
        // 94 & 49
        // 31 & 13
 
        // Problem 2: Degree Summary
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== Census TESTS ===========");
        Degrees.Run();
        // Console.WriteLine(string.Join(", ", SummarizeDegrees("census.txt")));
        // Results may be in a different order:
        // <Dictionary>{[Bachelors, 5355], [HS-grad, 10501], [11th, 1175],
        // [Masters, 1723], [9th, 514], [Some-college, 7291], [Assoc-acdm, 1067],
        // [Assoc-voc, 1382], [7th-8th, 646], [Doctorate, 413], [Prof-school, 576],
        // [5th-6th, 333], [10th, 933], [1st-4th, 168], [Preschool, 51], [12th, 433]}

        // Problem 3: Anagrams
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== Anagram TESTS ===========");
        Console.WriteLine(AnagramTester.IsAnagram("CAT", "ACT")); // true
        Console.WriteLine(AnagramTester.IsAnagram("DOG", "GOOD")); // false
        Console.WriteLine(AnagramTester.IsAnagram("AABBCCDD", "ABCD")); // false
        Console.WriteLine(AnagramTester.IsAnagram("ABCCD", "ABBCD")); // false
        Console.WriteLine(AnagramTester.IsAnagram("BC", "AD")); // false
        Console.WriteLine(AnagramTester.IsAnagram("Ab", "Ba")); // true
        Console.WriteLine(AnagramTester.IsAnagram("A Decimal Point", "Im a Dot in Place")); // true
        Console.WriteLine(AnagramTester.IsAnagram("tom marvolo riddle", "i am lord voldemort")); // true
        Console.WriteLine(AnagramTester.IsAnagram("Eleven plus Two", "Twelve Plus One")); // true
        Console.WriteLine(AnagramTester.IsAnagram("Eleven plus One", "Twelve Plus One")); // false

        // Problem 4: Maze
        Console.WriteLine("\n=========== Maze TESTS ===========");
        Dictionary<ValueTuple<int, int>, bool[]> map = SetupMazeMap();
        var maze = new Maze(map);
        maze.ShowStatus(); // Should be at (1,1)
        maze.MoveUp(); // Error
        maze.MoveLeft(); // Error
        maze.MoveRight();
        maze.MoveRight(); // Error
        maze.MoveDown();
        maze.MoveDown();    
        maze.MoveDown();
        maze.MoveRight();
        maze.MoveRight();
        maze.MoveUp();
        maze.MoveRight();
        maze.MoveDown();
        maze.MoveLeft();
        maze.MoveDown(); // Error
        maze.MoveRight();
        maze.MoveDown();
        maze.MoveDown();
        maze.MoveRight();
        maze.ShowStatus(); // Should be at (6,6)

        // Problem 5: Earthquake
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== Earthquake TESTS ===========");
        EarthquakeDailySummary();

        // Sample output from the function.  Number of earthquakes, places, and magnitudes will vary.
        // 1km NE of Pahala, Hawaii - Mag 2.36
        // 58km NW of Kandrian, Papua New Guinea - Mag 4.5
        // 16km NNW of Truckee, California - Mag 0.7
        // 9km S of Idyllwild, CA - Mag 0.25
        // 14km SW of Searles Valley, CA - Mag 0.36
        // 4km SW of Volcano, Hawaii - Mag 1.99
    }

    /// <summary>
    /// This function will read JSON (Javascript Object Notation) data from the 
    /// United States Geological Service (USGS) consisting of earthquake data.
    /// The data will include all earthquakes in the current day.
    /// 
    /// JSON data is organized into a dictionary. After reading the data using
    /// the built-in HTTP client library, this function will print out a list of all
    /// earthquake locations ('place' attribute) and magnitudes ('mag' attribute).
    /// Additional information about the format of the JSON data can be found 
    /// at this website:  
    /// 
    /// https://earthquake.usgs.gov/earthquakes/feed/v1.0/geojson.php
    /// 
    /// </summary>


    private static void EarthquakeDailySummary() {
        const string uri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        using var client = new HttpClient();
        using var getRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
        using var jsonStream = client.Send(getRequestMessage).Content.ReadAsStream();
        using var reader = new StreamReader(jsonStream);
        var json = reader.ReadToEnd();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json, options);

        // Add code below to print out each place a earthquake has happened today and its magitude.
        
        if (featureCollection?.Features != null)
        {
            Console.WriteLine("Daily Earthquake Summary:");
            Console.WriteLine("-------------------------");

            foreach (var feature in featureCollection.Features)
            {
                if (feature.Properties != null)
                {
                    Console.WriteLine($"Location: {feature.Properties.Place}");
                    Console.WriteLine($"Magnitude: {feature.Properties.Mag}");
                    Console.WriteLine("-------------------------");
                }
            }
        }
        else
        {
            Console.WriteLine("No earthquake data available.");
        }
    
    }
}