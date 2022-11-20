// Написать код, на входе которого 2-а целых числа. Вывести максимальное этих чисел.

int A = 5;
int B = 7;
int max = A;

if(A > max) max = A;
if(B > max) max = B;

Console.Write("Max = ");
Console.WriteLine(max);
