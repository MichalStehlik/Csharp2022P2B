int[] data1 = { 1, 2, 3, 4, 8, 5, 9, 1, 2, 5, 6, 9 };

int CountValue(int[] arr, int num)
{
    int c = 0;
    foreach(int x in arr)
    {
        if (x == num) { c++; };
    }
    return c;
}

void RemoveIndex(ref int[] arr, int index)
{
    for(int i = index; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    if (index < arr.Length) Array.Resize(ref arr, arr.Length - 1);
}

int[] AbsoluteDeviations(int[] arr, int value)
{
    int[] dev = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        dev[i] = Math.Abs(arr[i] - value);
    }
    return dev;
}

int[] DuplicateElements(int[] arr, bool inverseSign) 
{
    int[] res = new int[arr.Length * 2];
    for (int i = 0; i < arr.Length; i++)
    {
        res[i * 2] = arr[i];
        if (inverseSign) 
            res[i * 2 + 1] = - arr[i];
        else
            res[i * 2 + 1] = arr[i];
    }
    return res;
}

int AbsValues(ref int[] arr)
{
    int c = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Abs(arr[i]);
        c++;
    }
    return c;
}