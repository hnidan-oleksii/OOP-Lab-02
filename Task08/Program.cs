// Most Frequent Number 

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

// might use arr.Distinct().Count(), but then another counter required
int[] seen = new int[arr.Length];
int maxFrequent = arr[0];
int frequence = 0;

for (int i = 0; i < arr.Length; i++)
{
    int currNum = arr[i];

    if (seen.Contains(currNum))
    {
        continue;
    }

    int counter = 0;
    seen[i] = currNum;

    for (int j = i; j < arr.Length; j++)
    {
        if (arr[j] == currNum)
        {
            counter++;
        }

        if (counter > frequence)
        {
            frequence = counter;
            maxFrequent = currNum;
        }
    }
}

Console.WriteLine(maxFrequent);
