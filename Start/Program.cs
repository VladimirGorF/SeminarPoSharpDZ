
/*Console.WriteLine("Введите имя");
string? loosername = Console.ReadLine();
Console.WriteLine($"Приветик {loosername}");
*/

/* 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8

    

Console.Write ("Введите целое трёхзначное число ");
string x = Console.ReadLine()  ;
Console.Write(x[2]);

Console.Write ("Введите целое трёхзначное число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x%10);


System.Console.WriteLine("Введите целое число");
int x = Convert.ToInt32( Console.ReadLine()  )   ;
int y = -x;
while (y <=  x)
{
    System.Console.WriteLine(y);
    y = y +1;
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Число: ");
for(int i = -N; i<=N; i++)
{
    Console.WriteLine(i);
} */
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Приветик это первое число {A}");

Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Приветик это второе число {B}");

if (A>B)
{
    Console.WriteLine($"первое число {A} больше второго чиласла {B}");
}
else 
    Console.WriteLine($"второе число {B} больше первого числа {A}"); */



   /* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/*
Console.WriteLine("Введите первое число");
int A  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Приветик это первое число {A}");

Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Приветик это второе число {B}");

Console.WriteLine("Введите третье число");
int С = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Приветик это второе число {B}");

 int max = A;
 if (B > A) max = B;
 if (С > B) max = С;

Console.WriteLine($"Максимальное число {max}"); */

/* Задача 6
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

/* 
Console.WriteLine("Введите число для проверки на четность");
int A  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число {A}");

if(A%2 == 0) 
{
Console.WriteLine($"Число {A} является четным]");
}

else Console.WriteLine($"Число {A} является НЕчетным");*/

/* Задача 8: 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */


/*
Console.WriteLine ("Введите число  ");
int N = Convert.ToInt32( Console.ReadLine());
Console.WriteLine ("Получаем ряд четных чисел");
int i = 1;

while (i < N)
{
    if (i%2 == 0 )
    Console.WriteLine (i);
    i+=1;
} */


 
/*
void PrintDigit()
{

Console.WriteLine("x");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x/100;
int x2 = x%10;
Console.WriteLine(x1+""+x2);
}
PrintDigit();
*/


/* 
12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли наименьшее число кратным наибольшему. Если  наибоьшее не кратно наименьшему, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/


Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int x = 0;
int y = 0;
if (a > b)
{
    x = a;
    y = b;
}
else
{
    x = b;
    y = a;
}

if (x % y == 0) Console.WriteLine("кратно");

else Console.WriteLine("не кратно, остаток " + x % y);

/*
Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

string Multiplicity(int num1, int num2)
{
    string multiplicity = String.Empty;
    int max = num1;
    int min = num2;
    
    if (num2 > num1)
    {
        max = num2;
        min = num1;
    }

    if (max % min == 0)
    {
        multiplicity = $"Число {max} кратно {min}";
    }
    else
    {
        multiplicity = $"Число {max} не кратно {min}, остаток {max % min}";
    }

    return multiplicity;
}
Console.WriteLine(Multiplicity(number1, number2));


































