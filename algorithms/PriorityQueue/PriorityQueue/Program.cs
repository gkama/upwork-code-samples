using PriorityQueue.Core;

// Priority queue with int comparer
var priorityQueue = new PriorityQueue<Order, int>();

priorityQueue.Enqueue(new Order { Id = 1, Name = "test-1" }, 0);
priorityQueue.Enqueue(new Order { Id = 2, Name = "test-2" }, 1);
priorityQueue.Enqueue(new Order { Id = 3, Name = "test-3" }, 3);
priorityQueue.Enqueue(new Order { Id = 4, Name = "test-4" }, 2);

Console.WriteLine("-----Int Priority Queue-----");
while (priorityQueue.TryDequeue(out Order? item, out int priority))
{
    Console.WriteLine($"Popped Item : {item.Name}. Priority Was : {priority}");
}

// Priority queue with customer comparer
var priorityQueueWithCustomComparer = new PriorityQueue<Order, string>(new OrderComparer());

var order1 = new Order { Id = 1, Name = "test-1" };
var order2 = new Order { Id = 2, Name = "test-2", Importance = OrderImportances.Important };
var order3 = new Order { Id = 3, Name = "test-3" };
var order4 = new Order { Id = 4, Name = "test-4", Importance = OrderImportances.Important };

priorityQueueWithCustomComparer.Enqueue(order1, order1.Importance);
priorityQueueWithCustomComparer.Enqueue(order2, order2.Importance);
priorityQueueWithCustomComparer.Enqueue(order3, order3.Importance);
priorityQueueWithCustomComparer.Enqueue(order4, order4.Importance);

Console.WriteLine("-----Customer comparer Priority Queue-----");
while (priorityQueueWithCustomComparer.TryDequeue(out Order? item, out string priority))
{
    Console.WriteLine($"Popped Item : {item.Name}. Priority Was : {priority}");
}