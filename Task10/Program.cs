// Pairs by Difference

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
int difference = int.Parse(Console.ReadLine());
int counter = 0;

for (int i = 0; i < arr.Length; i++)
{
    int currNum = arr[i];
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (Math.Abs(arr[i] - arr[j]) == difference) { counter++; }
    }
}

Console.WriteLine(counter);