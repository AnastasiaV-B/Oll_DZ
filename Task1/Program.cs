// Напишите программу, которая на
//вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

int a = 5;
int b = 7;

int max = 0;
int min = 0;

if(a < b)
{
    max = b;
    min = a;
}
else 
{
    max = a;
    min = b;
}
Console.WriteLine(max);
Console.WriteLine(min);
