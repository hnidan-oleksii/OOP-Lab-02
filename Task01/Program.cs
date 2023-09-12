// Largest Common End

string[] arr1 = Console.ReadLine().Split();
string[] arr2 = Console.ReadLine().Split();

int lenArr1 = arr1.Length;
int lenArr2 = arr2.Length;
int maxLength = 0;
bool left = true;
bool right = true;

for (int i = 0; i < lenArr1 / 2; i++)
{
    if (i >= lenArr2)
    {
        break;
    }

    if (left)
    {
        if (arr1[i] == arr2[i])
        {
            maxLength = Math.Max(maxLength, i + 1);
        }
        else { left = false; }
    }

    if (right)
    {
        if (arr1[lenArr1 - i - 1] == arr2[lenArr2 - i - 1])
        {
            maxLength = Math.Max(maxLength, i + 1);
        }
        else { right = false; }
    }
}

Console.WriteLine(maxLength);