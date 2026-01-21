using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Queue three names with different priorities and perform two dequeues.
    // Expected Result: The first dequeue removes the highest priority, and the second removes the next highest priority in order to proff that it was removed.
    // Defect(s) Found: The code was retunring the correct value, but it was not removing the name. So before returning I add the _queue.RemoveAt(highPriorityIndex) line.
    public void TestPriorityQueue_1()
    {
        
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Robson", 1);
        priorityQueue.Enqueue("Eliza", 5);
        priorityQueue.Enqueue("Liz", 3);

        var removedNameOne = priorityQueue.Dequeue();
        Assert.AreEqual("Eliza", removedNameOne);

        var removedNameTwo = priorityQueue.Dequeue();
        Assert.AreEqual("Liz", removedNameTwo);

        var removedNameThree = priorityQueue.Dequeue();
        Assert.AreEqual("Robson", removedNameThree);
        
    }

    [TestMethod]
    // Scenario: Enqueue two names with the same highest priority and one lower priority.
    // Expected Result: Robson should be dequeued first as FIFO, then Eliza, then Liz.
    // Defect(s) Found: When names had the same highest priority, the Dequeue method returned the most recently added name instead of the first one. I just changed the >= to > on the if statement.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Robson", 5);
        priorityQueue.Enqueue("Eliza", 5);
        priorityQueue.Enqueue("Liz", 3);

        Assert.AreEqual("Robson", priorityQueue.Dequeue());
        Assert.AreEqual("Eliza", priorityQueue.Dequeue());
        Assert.AreEqual("Liz", priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: Enqueue names where the highest priority item is at the back of the queue.
    // Expected Result: Liz should be dequeued first, then Robson, then Eliza.
    // Defect(s) Found: The search loop in the Dequeue method did not check the last name in the queue, so a highest priority item at the back was ignored. I changed from index < _queue.Count - 1 to index < _queue.Count.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Robson", 5);
        priorityQueue.Enqueue("Eliza", 5);
        priorityQueue.Enqueue("Liz", 10);

        Assert.AreEqual("Liz", priorityQueue.Dequeue());
        Assert.AreEqual("Robson", priorityQueue.Dequeue());
        Assert.AreEqual("Eliza", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}