public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: [Task 1 (Pri:2), Task 2 (Pri:5), Task 3 (Pri:3), Task 2 (Pri:7)]
        // Expected Result: 
        // value: Task 2
        // High priority: 7
        Console.WriteLine("Test 1, Values:");

        priorityQueue.Enqueue("Task 1", 2);
        priorityQueue.Enqueue("Task 2", 5);
        priorityQueue.Enqueue("Task 3", 3);
        priorityQueue.Enqueue("Task 2", 7);
        Console.WriteLine(priorityQueue.ToString());
        Console.WriteLine("=========");
        var result = priorityQueue.Dequeue();


        // Defect(s) Found: Defects were found, fixed and documented 
        // in the Dequeue() method.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: [] empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 2, Values:");

        Console.WriteLine(priorityQueue.ToString());
        Console.WriteLine("=========");

        result = priorityQueue.Dequeue();

  

        Console.WriteLine("---------");

        // Defect(s) Found: Defects were found, fixed and documented 
        // in the Dequeue() method.
    }
}