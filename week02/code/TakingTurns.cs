public static class TakingTurns {
    public static void Test() {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1, Person, Turns");
        var players = new TakingTurnsQueue();
        players.queueResult.Clear();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        // To see the initial order in the queue.
        Console.WriteLine(players.ToString());
        Console.WriteLine("=========");
        while (players.Length > 0)
            players.GetNextPerson();

        // just to format the output.
        Console.WriteLine($"{{{string.Join(',', players.queueResult.Select(p => p.Name))}}}"); 

        // Defect(s) Found: Defects were found, fixed and documented 
        // in the GetNextPerson() and the Enqueue() methods.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2, Person, Turns");
        players = new TakingTurnsQueue();
        players.queueResult.Clear();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);

        for (int i = 0; i < 5; i++)
            players.GetNextPerson();
 

        players.AddPerson("George", 3);
        // To see the initial order in the queue.
        Console.WriteLine(players.ToString());
        Console.WriteLine("=========");

        while (players.Length > 0)
            players.GetNextPerson();
        // just to format the output.
        Console.WriteLine($"{{{string.Join(',', players.queueResult.Select(p => p.Name))}}}");

        // Defect(s) Found: Defects were found, fixed and documented 
        // in the GetNextPerson() and the Enqueue() methods.

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3, Person, Turns");
        players = new TakingTurnsQueue();
        players.queueResult.Clear();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        // To see the initial order in the queue.
        Console.WriteLine(players.ToString());
        Console.WriteLine("=========");

        for (int i = 0; i < 10; i++)
            players.GetNextPerson();

        // just to format the output.
        Console.WriteLine($"{{{string.Join(',', players.queueResult.Select(p => p.Name))}}}");

        // Defect(s) Found: Defects were found, fixed and documented 
        // in the GetNextPerson() and the Enqueue() methods.

        Console.WriteLine("---------");

         // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4, Person, Turns");
        players = new TakingTurnsQueue();
        players.queueResult.Clear();
        players.AddPerson("Tim", -3);
        players.AddPerson("Sue", 3);
        // To see the initial order in the queue.
        Console.WriteLine(players.ToString());
        Console.WriteLine("=========");

        for (int i = 0; i < 10; i++) 
            players.GetNextPerson();

        // just to format the output.
        Console.WriteLine($"{{{string.Join(',', players.queueResult.Select(p => p.Name))}}}");

        // Defect(s) Found: Defects were found, fixed and documented 
        // in the GetNextPerson() and the Enqueue() methods. 

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5, Person, Turns");
        players = new TakingTurnsQueue();
        players.queueResult.Clear();
        // To see the initial order in the queue.
        Console.WriteLine(players.ToString());
        Console.WriteLine("=========");

        players.GetNextPerson();
        // just to format the output.
        Console.WriteLine($"{{{string.Join(',', players.queueResult.Select(p => p.Name))}}}");

        // Defect(s) Found: Defects were found, fixed and documented 
        // in the GetNextPerson() and the Enqueue() methods.
    }
}