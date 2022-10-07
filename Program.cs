// Задача 64 и 66

Console.Write("Задачи 64 и 66 сделаны в одном блоке кода, итак начнем...");
Console.Write("\nEnter M: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter N: ");
int M = Convert.ToInt32(Console.ReadLine());

int temp = M;

Console.WriteLine($"M={M}, N={N}");

if (N>M)
for (int i = M; i <= N; i++)
    Console.Write($" {i}");
else
    for (int i = N; i <= M; i++)
        Console.Write($" {i}");

// Тут начинается Задача 66...

if (M > N) 
{
  M = N; 
  N = temp;
}

PrintSumm(M, N, temp=0);

void PrintSumm(int M, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"\nSum of elements = {summ} ");
    return;
  }
  PrintSumm(M, N - 1, summ);
}

{
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

// Задача 68

Console.Write("Задача 68");
Console.Write("\nВведите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(M,N);

void AkkermanFunction(int M, int N)
{
    Console.Write(Akkerman(M, N)); 
}

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}