//  Напишите программу, которая
// принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

int a = 2;
int b = 3;
int c = 7;

int max = a;
if(max > b)
{
    max = a;
}
else
{
    max = b;
}
if(max > c)
{
    max = b;
}
else
{
    max = c;
}
Console.WriteLine(max);
