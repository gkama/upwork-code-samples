public static class Solutions
{
    #region Simple
    public static void Simple(int[] arr1, int[] arr2, int[] arr3)
    {
        var totalArr = arr1.Union(arr2)
            .ToArray()
            .Union(arr3)
            .ToArray();

        // First sort each one
        Array.Sort(totalArr);

        // Print
        PrintArray(totalArr);
    }
    #endregion

    #region Enhanced
    public static void Enhanced(int[] arr1, int[] arr2, int[] arr3)
    {
        // Create an array with 
        var arr = arr1.Union(arr2)
            .ToArray()
            .Union(arr3)
            .ToArray();
        var n = arr.Length;

        // Build heap (rearrange array)
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // One by one extract an element from heap
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            // call max heapify on the reduced heap
            Heapify(arr, i, 0);
        }

        // Print
        PrintArray(arr);
    }

    // To heapify a subtree rooted with node i which is
    // an index in arr[]. n is size of heap
    private static void Heapify(int[] arr, int n, int i)
    {
        int largest = i; // Initialize largest as root
        int l = 2 * i + 1; // left = 2*i + 1
        int r = 2 * i + 2; // right = 2*i + 2

        // If left child is larger than root
        if (l < n && arr[l] > arr[largest])
            largest = l;

        // If right child is larger than largest so far
        if (r < n && arr[r] > arr[largest])
            largest = r;

        // If largest is not root
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            // Recursively heapify the affected sub-tree
            Heapify(arr, n, largest);
        }
    }
    #endregion

    private static void PrintArray(int[] arr)
    {
        for (int j = 0; j < arr.Length; j++) 
            Console.WriteLine(arr[j]);
    }
}