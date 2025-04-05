namespace prove_07;

public static class LinkedListTester {
    public static void Run() {
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        var ll = new LinkedList();
        ll.AddLast(1);
        ll.AddFirst(2);
        ll.AddFirst(2);
        ll.AddFirst(2);
        ll.AddFirst(3);
        ll.AddFirst(4);
        ll.AddFirst(5);

        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1};
        ll.AddLast(0);
        ll.AddLast(-1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0, -1};

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        ll.RemoveLast();
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0}
        ll.RemoveLast();
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1}

        Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
        ll.AddAfter(3, 35);
        ll.AddAfter(5, 6);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
        ll.Remove(-1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
        ll.Remove(3);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 35, 2, 2, 2, 1}
        ll.Remove(6);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2, 1}
        ll.Remove(1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
        ll.Remove(7);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
        ll.Remove(5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 2, 2, 2}
        ll.Remove(2);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 2, 2}

        Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");
        ll.Replace(2, 10);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 10, 10}
        ll.Replace(7, 5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 10, 10}
        ll.Replace(4, 100);
        Console.WriteLine(ll.ToString()); // <LinkedList>{100, 35, 10, 10}


        Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========");
        Console.WriteLine(ll.Reverse().AsString()); // <IEnumerable>[10, 10, 35, 100}
    }
}