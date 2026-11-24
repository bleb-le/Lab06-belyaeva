// Пример 
// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }

// Задание 1.1
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }

// Задание 1.2
// for (int i = 2; i <= 50; i += 2)
// {
//     Console.WriteLine(i);
// }

// Задание 2
// int sum3 = 0;
// int count7 = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum3 += i;
//     }
//     if (i % 7 == 0)
//     {
//         count7++;
//     }
// }
// Console.WriteLine($"сумма чисел, кратных 3: {sum3}");
// Console.WriteLine($"количество чисел, кратных 7: {count7}");

// Задание 3
// Console.WriteLine("вводите числа, 0 - стоп:");
// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;
// int positive = 0;
// int negative = 0;

// while (number != 0)
// {
//     total += number;
//     if (number > 0)
//     {
//         positive++;
//     }
//     else
//     {
//         negative++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"сумма: {total}");
// Console.WriteLine($"положительных чисел: {positive}");
// Console.WriteLine($"отрицательных чисел: {negative}");

// Задание 4
// bool access = false;

// for (int attempt = 1; attempt <= 3; attempt++)
// {
//     Console.Write($"введите пароль (попытка {attempt} из 3): ");
//     string? password = Console.ReadLine();

//     if (password == "qwerty")
//     {
//         access = true;
//         break;
//     }
// }

// if (access)
// {
//     Console.WriteLine("доступ разрешён");
// }
// else
// {
//     Console.WriteLine("доступ заблокирован!!!!!!!!");
// }

// Задание 5. Таблица умножения
// Console.Write("введите число n (от 1 до 9): ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }

// Задание 6. Числа без троек
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 10 == 0 && i > 20)
//     {
//         break;
//     }
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }

// Угадай число
int secretik = 42;
bool win = false;

for (int a = 1; a <= 5; a++)
{
    Console.Write($"попытка {a} из 5... ваше число: ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess == secretik)
    {
        Console.WriteLine($"ПОБЕДА!!!! попыток: {a}");
        win = true;
        break;
    }
    else if (guess < secretik)
    {
        Console.WriteLine("больше!!");
    }
    else
    {
        Console.WriteLine("меньше..");
    }
}

if (!win)
{
    Console.WriteLine($"вы ПРОИГРАЛИ, число было: {secretik}");
}