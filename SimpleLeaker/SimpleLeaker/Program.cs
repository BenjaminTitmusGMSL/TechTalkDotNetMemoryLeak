List<char[]> allocations;

void MakeAllocations()
{
    allocations = new List<char[]>();
    Console.ReadKey();

    // Small allocations 1
    Console.WriteLine("Small allocations 1");
    for (int i = 0; i < 1000; i++)
    {
        allocations.Add(new char[10000]);
    }

    Console.ReadKey();

    // Small allocations 2
    Console.WriteLine("Small allocations 2");
    for (int i = 0; i < 1000; i++)
    {
        allocations.Add(new char[10000]);
    }

    Console.ReadKey();

    // Large allocation
    Console.WriteLine("Large allocation");
    allocations.Add(new char[10000000]);
    Console.ReadKey();
    
    // Clear all allocations
    Console.WriteLine("Clear allocations");
    allocations.Clear();
    Console.ReadKey();
}

MakeAllocations();

// Clear all allocations
Console.WriteLine("Outside of MakeAllocations");
Console.ReadKey();