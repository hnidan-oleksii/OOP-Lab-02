// Max Sequence of Equal Elements

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

int maxLen = 0;
int maxLenArrIndex = 0;
int tempMaxLen = 0;

for (int i = 1; i < arr.Length; i++)
{

    if (arr[i] == arr[i - 1]) { tempMaxLen += 1; }
    else {  tempMaxLen = 0; }

    if (tempMaxLen > maxLen)
    {
        maxLen = tempMaxLen;
        maxLenArrIndex = i - tempMaxLen;
    }
}

Console.WriteLine(string.Join(' ', arr[maxLenArrIndex..(maxLenArrIndex + maxLen + 1)]));