using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, масиви та рядки");

//Console.WriteLine("завдання 1");

//int[] A = new int[5]; // A - одновимірний масив
//double[,] B = new double[3, 4]; // B - двовимірний масив

//Random rnd = new Random();
//Console.WriteLine("введіть 5 цілих чиснл: ");

//for (int i = 0; i < A.Length; i++)
//{
//    Console.Write($"A[{i}] = ");
//    A[i] = int.Parse(Console.ReadLine()!);
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        B[i, j] = rnd.NextDouble();
//    }
//}

//Console.WriteLine("\nМасив A:");
//foreach (int item in A)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

//Console.WriteLine("\nМасив B:");
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Console.Write($"{B[i, j]}\t");
//    }
//    Console.WriteLine();
//}

//double max = A[0];
//double min = A[0];
//double sum = 0;
//double product = 1;

//foreach (int item in A)
//{
//    if (item > max) max = item;
//    if (item < min) min = item;

//    sum += item;
//    product *= item;
//}

//foreach (double item in B)
//{
//    if (item > max) max = item;
//    if (item < min) min = item;

//    sum += item;
//    product *= item;
//}

//int sumEvenA = 0;
//foreach (int item in A)
//{
//    if (item % 2 == 0)
//    {
//        sumEvenA += item;
//    }
//}

//double sumOddColumnsB = 0;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        if ((j + 1) % 2 != 0)
//        {
//            sumOddColumnsB += B[i, j];
//        }
//    }
//}
//Console.WriteLine("\nРезультати:");
//Console.WriteLine($"Загальний максимальний елемент: {max}");
//Console.WriteLine($"Загальний мінімальний елемент: {min}");
//Console.WriteLine($"Загальна сума всіх елементів: {sum}");
//Console.WriteLine($"Загальний добуток усіх елементів: {product}");
//Console.WriteLine($"Сума парних елементів масиву A: {sumEvenA}");
//Console.WriteLine($"Сума елементів непарних стовпців масиву B: {sumOddColumnsB}");

//Console.WriteLine("завдання 2");

//const int N = 5;
//int[,] matrix = new int[N, N];
//Random rnd = new Random();
//for (int i = 0; i < N; i++) 
//{
//    for (int j = 0; j < N; j++) 
//    {
//        matrix[i, j] = rnd.Next(-100, 100);
//    }
//}
//Console.WriteLine("Матриця 5x5: ");
//for (int i = 0; i < N; i++)
//{
//    for (int j = 0; j < N; j++)
//    {
//        Console.Write($"{matrix[i, j]\t}");
//    }
//    Console.WriteLine();
//}

//int min = matrix[0, 0];
//int max = matrix[0, 0];

//int minRow = 0, minCol = 0;
//int maxRow = 0, maxCol = 0;

//for (int i = 0; i < N; i++)
//{
//    for (int j = 0; j < N; j++)
//    {
//        if (matrix[i, j] < min)
//        {
//            min = matrix[i, j];
//            minRow = i;
//            minCol = j;
//        }

//        if (matrix[i, j] > max)
//        {
//            max = matrix[i, j];
//            maxRow = i;
//            maxCol = j;
//        }
//    }
//}

//int minPos = minRow * N + minCol;
//int maxPos = maxRow * N + maxCol;

//int start = Math.Min(minPos, maxPos);
//int end = Math.Max(minPos, maxPos);

//int sumBetween = 0;

//for (int pos = start + 1; pos < end; pos++)
//{
//    int i = pos / N;
//    int j = pos % N;
//    sumBetween += matrix[i, j];
//}

//Console.WriteLine();
//Console.WriteLine($"Мінімальний елемент: {min} (рядок {minRow + 1}, стовпець {minCol + 1})");
//Console.WriteLine($"Максимальний елемент: {max} (рядок {maxRow + 1}, стовпець {maxCol + 1})");
//Console.WriteLine($"Сума елементів між мінімальним і максимальним: {sumBetween}");

//Console.WriteLine("завдання 3");

//Console.WriteLine("завдання 4");

//const int N = 5;
//Random rnd = new Random();
//static int[,] GenerateRandomMatrix(int size, int min, int max, Random r)
//{
//    int[,] m = new int[size, size];
//    for (int i = 0; i < size; i++)
//        for (int j = 0; j < size; j++)
//            m[i, j] = r.Next(min, max + 1);
//    return m;
//}
//static void PrintMatrix(int[,] m, string title)
//{
//    Console.WriteLine($"\n{title}:");
//    int rows = m.GetLength(0);
//    int cols = m.GetLength(1);
//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < cols; j++)
//        {
//            Console.Write($"{m[i, j]}\t");
//        }
//        Console.WriteLine();
//    }
//}

//static int[,] MultiplyByScalar(int[,] a, int k)
//{
//    int rows = a.GetLength(0);
//    int cols = a.GetLength(1);
//    int[,] result = new int[rows, cols];

//    for (int i = 0; i < rows; i++)
//        for (int j = 0; j < cols; j++)
//            result[i, j] = a[i, j] * k;

//    return result;
//}

//static int[,] AddMatrices(int[,] a, int[,] b)
//{
//    int rows = a.GetLength(0);
//    int cols = a.GetLength(1);
//    int[,] result = new int[rows, cols];

//    for (int i = 0; i < rows; i++)
//        for (int j = 0; j < cols; j++)
//            result[i, j] = a[i, j] + b[i, j];

//    return result;
//}

//static int[,] MultiplyMatrices(int[,] a, int[,] b)
//{
//    int n = a.GetLength(0);
//    int m = a.GetLength(1);
//    int k = b.GetLength(1);

//    int[,] result = new int[n, k];

//    for (int i = 0; i < n; i++)
//        for (int j = 0; j < k; j++)
//        {
//            int dob = 0;
//            for (int t = 0; t < m; t++)
//                dob += a[i, t] * b[t, j];
//            result[i, j] = dob;
//        }

//    return result;
//}

//while (true)
//{
//    Console.WriteLine("\n===== ОПЕРАЦІЇ НАД МАТРИЦЯМИ 5x5 =====");
//    Console.WriteLine("1 — Множення матриці на число");
//    Console.WriteLine("2 — Додавання матриць");
//    Console.WriteLine("3 — Добуток матриць");
//    Console.WriteLine("0 — Вихід");
//    Console.Write("Ваш вибір: ");
//    string choice = Console.ReadLine() ?? "";

//    if (choice == "0") break;

//    try
//    {
//        switch (choice)
//        {
//            case "1":
//                {
//                    int[,] a = GenerateRandomMatrix(N, -1, 101, rnd);
//                    PrintMatrix(a, "A");

//                    Console.Write("Введіть число k для множення: ");
//                    int k = int.Parse(Console.ReadLine()!);

//                    int[,] res = MultiplyByScalar(a, k);
//                    PrintMatrix(res, $"A * {k}");
//                    break;
//                }
//            case "2":
//                {
//                    int[,] a = GenerateRandomMatrix(N, -1, 101, rnd);
//                    int[,] b = GenerateRandomMatrix(N, -1, 101, rnd);

//                    PrintMatrix(a, "A");
//                    PrintMatrix(b, "B");

//                    int[,] res = AddMatrices(a, b);
//                    PrintMatrix(res, "A + B");
//                    break;
//                }
//            case "3":
//                {
//                    int[,] a = GenerateRandomMatrix(N, -1, 101, rnd);
//                    int[,] b = GenerateRandomMatrix(N, -1, 101, rnd);

//                    PrintMatrix(a, "A");
//                    PrintMatrix(b, "B");

//                    int[,] res = MultiplyMatrices(a, b);
//                    PrintMatrix(res, "A * B");
//                    break;
//                }
//            default:
//                Console.WriteLine("Невідома команда. Спробуйте ще раз.");
//                break;
//        }
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Помилка: введено не число.");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Помилка: {ex.Message}");
//    }
//}

// Console.WriteLine("завдання 5");

//Console.WriteLine("завдання 6");

//Console.WriteLine("Введіть текст:");
//string text = Console.ReadLine() ?? "";

//string result = CapitalizeSentences(text);

//Console.WriteLine("\nРезультат:");
//Console.WriteLine(result);
//static string CapitalizeSentences(string text)
//{
//    if (string.IsNullOrEmpty(text))
//        return text;

//    StringBuilder sb = new StringBuilder(text);
//    bool newSentence = true;

//    for (int i = 0; i < sb.Length; i++)
//    {
//        char c = sb[i];
//        if (char.IsWhiteSpace(c))
//            continue;
//        if (c == '.' || c == '!' || c == '?')
//        {
//            newSentence = true;
//            continue;
//        }

//        if (newSentence && char.IsLetter(c))
//        {
//            sb[i] = char.ToUpper(c);
//            newSentence = false;
//        }
//        else if (!newSentence && char.IsLetter(c)) { }
//        else { }
//    }

//    return sb.ToString();
//}

// Console.WriteLine("завдання 7");

// Console.WriteLine("завдання 8");

Console.WriteLine("завдання 9");

int rows, cols, multiplier;

if (args.Length >= 3 &&
    int.TryParse(args[0], out rows) &&
    int.TryParse(args[1], out cols) &&
    int.TryParse(args[2], out multiplier) &&
    rows > 0 && cols > 0)
{
    Console.WriteLine($">>> Параметри з командного рядка: {rows}x{cols}, множник = {multiplier}");
}
else
{
    Console.WriteLine("=== Меню ===");

    Console.Write("Кількість рядків: ");
    rows = int.Parse(Console.ReadLine()!);

    Console.Write("Кількість стовпців: ");
    cols = int.Parse(Console.ReadLine()!);

    Console.Write("Множник: ");
    multiplier = int.Parse(Console.ReadLine()!);
}

if (rows <= 0 || cols <= 0)
{
    Console.WriteLine("Помилка: розміри масиву мають бути додатними.");
    Console.WriteLine("Натисніть Enter для виходу...");
    Console.ReadLine();
    return;
}

int[,] array = new int[rows, cols];
Random r = new Random();

for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        array[i, j] = r.Next(0, 101);

Console.WriteLine("\n>>> Початковий двовимірний масив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
        Console.Write($"{array[i, j]}\t");
    Console.WriteLine();
}

for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        array[i, j] *= multiplier;

Console.WriteLine($"\n>>> Масив після множення на {multiplier}:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
        Console.Write($"{array[i, j]}\t");
    Console.WriteLine();
}

Console.WriteLine("\nНатисніть Enter для виходу...");
Console.ReadLine();