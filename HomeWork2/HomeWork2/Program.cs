Console.WriteLine("1:");
int a = 0, b = 1;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(a);
    int temp = a + b;
    a = b;
    b = temp;
}

Console.WriteLine("\n2:");
for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n3:");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write($"{i} * {j} = {i * j}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n4:");
string password = "qwerty";
string userInput;
do
{
    Console.Write("Введите пароль: ");
    userInput = Console.ReadLine();
    if (userInput != password)
    {
        Console.WriteLine("Неверный пароль. Попробуйте снова.");
    }
} while (userInput != password);

Console.WriteLine("Пароль верный!");