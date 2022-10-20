//Домашнее задание.
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number:  ");
int n2 = Convert.ToInt32(Console.ReadLine());


if(n1 > n2)
{
    Console.WriteLine("Max n1");
}
else 
{
    Console.WriteLine(" Min n2");
}




//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number:  ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number:  ");
int num3 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2 && num1 > num3)
{
 Console.Write(num1 + " max");
}
if (num2 > num1 && num2 > num3)
{
     Console.Write(num2 + "max");

}
if (num3 > num2 && num3 > num1)
{
    Console.Write(num3 + "max");
}




//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num % 2 == 0 )
{
    Console.WriteLine(num + " Чётные");

}
    else {  
          Console.WriteLine(num + " нечётные");

    }




//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 2;


while( current <= n)

{
    Console.Write( current + " ");
    current += 2;
}

