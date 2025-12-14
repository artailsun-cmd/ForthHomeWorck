//First part
Console.Write("Enter rows: ");
if (!int.TryParse(Console.ReadLine(), out int rows) || rows <= 0)
{
    Console.WriteLine("Error, enter rigyt number");
    return;
}

for (int i = 1; i <= rows; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Second part, первые чяасы по 100 грн, следующие три по 120 грн, остальные по 150 грн
Console.Write("Write worck hours: ");

if (!int.TryParse(Console.ReadLine(), out int hours) || hours < 0)
{
    Console.WriteLine("Error, enter right number");
    return;
}

int salary = 0;

int firstHours = Math.Min(hours, 3);
salary += firstHours * 100;

if (hours > 3)
{
    int secondHours = Math.Min(hours - 3, 3);
    salary += secondHours * 120;
}

if (hours > 6)
{
    int lastHours = Math.Min(hours - 6, 6);
    salary += lastHours * 150;
}

Console.WriteLine($"Day salary: {salary} грн");

//Third part

Console.Write("Enter number: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("Prime numbers:");

    for (int i = 2; i <= n; i++)
    {
        if (IsPrime(i))
        {
            Console.Write(i + " ");
        }
    }
}
else
{
    Console.WriteLine("Error. Try again.");
}

static bool IsPrime(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
    //Fourth part

    Console.WriteLine("Enter N number: ");

    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
    {
        Console.WriteLine($"First {n} Fibanachi numbers:");

        int a = 0;
        int b = 1;

        Console.WriteLine(a + " "); // 0
        if (n > 1)
            Console.WriteLine(b + " "); // 1

        int next = a + b;

        while (next == 1)
        {

            a = b;
            b = next;
            next = a + b;
        }

        for (int i = 3; i <= n; i++)
        {
            Console.Write(next + " ");

            a = b;
            b = next;
            next = a + b;
        }
    }
    else

        Console.WriteLine("Enter number.");
}


//Fifth part

Console.Write("Write quantity of worckes: ");

if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
{
    double sum = 0;

    for (int i = 1; i <= count; i++)
    {
        Console.Write($"Enter worckers salary #{i}: ");

        double salary;
        while (!double.TryParse(Console.ReadLine(), out salary) || salary < 0)
        {
            Console.Write("Error. Enter right salary!");
        }

        sum += salary;
    }

    double average = sum / count;

    Console.WriteLine($"Average earnings: {average}");
}
else
{
    Console.WriteLine("Wrong number.");
}

//Sixth part

Console.Write("Enter number: ");

if (int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine($"Multiplication table for {number}:");

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
    }
}
else
{
    Console.WriteLine("Error.");

    //Seventh part

    Console.Write("Enter your number, please: ");

    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is prime.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime.");
        }
    }
    else
    {
        Console.WriteLine("Error.");
    }

    static bool IsPrime(int number)
  
    {
        if (number < 2)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }