public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Check if enqueue adds item to the back of the queue
        // Expected Result: 1, 3, 6, 2 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("1", 1);
        priorityQueue.Enqueue("3", 3);
        priorityQueue.Enqueue("6", 6);
        priorityQueue.Enqueue("2", 2);
        Console.WriteLine(priorityQueue);
        

        // Defect(s) Found: 
        // None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Check if dequeue removes item with highest priority then displays item value
        // Expected Result: 1, 3, 2
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("1", 1);
        priorityQueue.Enqueue("3", 3);
        priorityQueue.Enqueue("6", 6);
        priorityQueue.Enqueue("2", 2);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 
        // Dequeue did not remove item

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: If multiple items of highest value exist, dequeue removes item at earliest index
        // Expected Result: 1, 3, 2, 6, 3
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("1", 1);
        priorityQueue.Enqueue("3", 3);
        priorityQueue.Enqueue("6", 6);
        priorityQueue.Enqueue("2", 2);
        priorityQueue.Enqueue("6", 6);
        priorityQueue.Enqueue("3", 3);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 
        // Item removed out of order

        Console.WriteLine("---------");

        // Test 4
        // Scenario: If queue is empty, dequeue returns error message
        // Expected Result: 1, 3, 2, 6, 3
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 
        // None

        Console.WriteLine("---------");
    }
}