// Index of Letters

using System.Text;

char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
char[] arr = string.Concat(Console.ReadLine().Split()).ToCharArray();

for (int i = 0; i < arr.Length; i++)
{
    char currChar = arr[i];
    Console.WriteLine($"{currChar} -> {Array.IndexOf(alphabet, currChar)}");
}