using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priority.
    // Expected Result: Dequeue returns the value with the highest priority ("B").
    // Defect(s) Found: Dequeue does not remove the item; loop fails to check last element.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result, "Should return highest priority item.");
    }

    [TestMethod]
    // Scenario: Enqueue items with equal priority.
    // Expected Result: The first item with the highest priority ("A") is removed first.
    // Defect(s) Found: Dequeue does not remove the item; loop fails to check last element.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 10);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 10);

        var result1 = priorityQueue.Dequeue();
        Assert.AreEqual("A", result1);

        var result2 = priorityQueue.Dequeue();
        Assert.AreEqual("B", result2);
    }

    [TestMethod] 
    // Scenario: Ensure Dequeue actually removes the item. 
    // Expected Result: After removing highest priority item, next highest is returned. 
    // Defect(s) Found: Dequeue does not remove the item.
    public void TestPriorityQueue_RemoveBehavior()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None (this part works).
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
        priorityQueue.Dequeue();
        Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException ex)
        {
        Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

}