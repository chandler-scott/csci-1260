static int BinarySearch(int[] arr, int low, int high, int key) 
{
    while (low <= high)
    {
        int mid = (low + high) / 2;

        if (arr[mid] == key)
        {
            return mid;
        }
        else if (arr[mid] < key)
        {
            low = mid + 1;
        }
        else
        {
            high = mid - 1;
        }
    }
    return low;
}

static void InsertionSort(int[] arr, int n) 
{
    for (int i = 1; i < n; i++)
    {
        int x = arr[i];
        int j = i - 1;
        int z = BinarySearch(arr, 0, j, x);

        for (int k = j; k >= z; k--)
        {
            arr[k + 1] = arr[k];
        }

        arr[z] = x;
        Console.WriteLine($"array:\t{string.Join(" ", arr)}");

    }
}

// initialize variables
Random random = new();
int arrSize = 10;
int[] unsortedArray = new int[arrSize];

// initialize arr values
for (int i = 0; i < arrSize; i++) 
{
    unsortedArray[i] = random.Next(100);
}

// print unsorted array
Console.WriteLine($"Unsorted array:\t{string.Join(" ", unsortedArray)}");

// sort array
InsertionSort(unsortedArray, unsortedArray.Length);

// print sorted array
Console.WriteLine($"Sorted array:\t{string.Join(" ", unsortedArray)}");