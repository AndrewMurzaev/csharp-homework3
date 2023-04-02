// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Input a five-digit number:");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} is a palindrome");
//     }
//     else
//     {
//         Console.WriteLine($"{number} isn't a palindrome");
//     }
// }
// else
// {
//     Console.WriteLine("it's not a five-digit number");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//  Console.WriteLine("Input x1");
// int x1 = int.Parse(Console.ReadLine());
//  Console.WriteLine("Input y1");
// int y1 = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Input z1");
// int z1 = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Input x2");
// int x2 = int.Parse(Console.ReadLine());
//  Console.WriteLine("Input y2");
// int y2 = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Input z2");
// int z2 = int.Parse(Console.ReadLine());

// double answer = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2 - z1)*(z2 - z1));
//  Console.WriteLine(answer);

// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

 Console.WriteLine("Input a number");
int Number = int.Parse(Console.ReadLine());

for (int i = 1; i <= Number; i++)
{
    Console.Write(i*i*i + " ");
}