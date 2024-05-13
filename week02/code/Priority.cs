public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        
        
        // Test Cases

        // Test 1
        // Scenario: person 1 (bob) and person 2 (robert) are enqueued and dequeued with Bob at priority 2 (highest) and Robert at priority 1 (lowest)
        // Expected Result: Bob, Robert (followed by an empty queue being printed to the console)
        Console.WriteLine("Test 1");
       // Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Bob",2);
       // Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Robert",1);
        Console.WriteLine(priorityQueue);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Dequeue did not remove from the queue. Additional code was added to the Dequeue Method()

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Bob, Robert, and Susan are added to the priority queue with priorities 1, 2, and 3. (lowest to highest)
        // Expected Result: Susan, Robert, Bob
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Robert",2);
        priorityQueue.Enqueue("Susan",3);
        Console.WriteLine(priorityQueue);
         Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
         Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Queue Does not follow priority and dequeues in the order queued. 
        // Solution: an index error precluded the loop from ever reaching index 3 causing the highest it could see to be robert. It now can see the full range. 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}