// Fold and Sum

int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
int arrLen = arr.Length;
int k = arrLen / 4;

int[] firstRow = arr[0..k].Reverse().Concat(arr[(arrLen - k)..^0].Reverse()).ToArray();
int[] secondRow = arr[(k)..(arrLen - k)];

var result = Enumerable.Zip(firstRow, secondRow, (num1, num2) => num1 + num2);
Console.WriteLine(string.Join(' ', result));
