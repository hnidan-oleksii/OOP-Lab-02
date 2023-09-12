// Compare Char Arrays

char[] arr1 = string.Concat(Console.ReadLine().Split()).ToCharArray();
char[] arr2 = string.Concat(Console.ReadLine().Split()).ToCharArray();

char[] shorterArr = arr1.Length >= arr2.Length ? arr2 : arr1;
bool arr1First = true;
bool equal = true;

for  (int i = 0; i < shorterArr.Length; i++)
{
    if (arr1[i] > arr2[i]) 
    { 
        arr1First = false;
        equal = false;
        break;
    }
    else if (arr1[i] < arr2[i]) 
    { 
        arr1First = true;
        equal = false;
        break;
    }
}


if (equal)
{
    Console.WriteLine(string.Join(' ', shorterArr));
    Console.WriteLine(string.Join(' ', shorterArr.Equals(arr1) ? arr2 : arr1));
}
else if (arr1First)
{
    Console.WriteLine(string.Join(' ', arr1));
    Console.WriteLine(string.Join(' ', arr2));
}
else
{
    Console.WriteLine(string.Join(' ', arr2));
    Console.WriteLine(string.Join(' ', arr1));
}