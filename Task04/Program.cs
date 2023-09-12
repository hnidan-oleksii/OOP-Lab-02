// Sieve of Eratothenes

int n = int.Parse(Console.ReadLine());
bool[] primes = Enumerable.Repeat(true, n).ToArray();
primes[0] = false;

for (int i = 0; i < primes.Length; i++)
{
    if (primes[i])
    {
        Console.Write($"{i + 1} ");
        for (int j = 2; j * (i + 1) <= n; j++)
        {
            primes[j * (i + 1) - 1] = false;
        }
    }
}
