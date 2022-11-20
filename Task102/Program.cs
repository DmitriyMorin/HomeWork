// Написать код, на входе которого 2-а целых числа. Вывести максимальное этих чисел.

int A = -9;
int B = -3;
int max = A;

if(A > max) max = A;
if(B > max) max = B;

Console.Write("Max = ");
Console.WriteLine(max);
