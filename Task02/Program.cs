// Rotate and Sum

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
int arrLen = arr.Length;
int k = int.Parse(Console.ReadLine());
int[] result = new int[arr.Length];

for (int i = 0; i < arrLen; i++)
{
    for (int j = 1; j <= k; j++)
    {
        result[i] += arr[(arrLen + i - j) % arrLen];
    }
}

Console.WriteLine(string.Join(' ', result));