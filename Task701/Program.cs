using static Library;
//*Сделать вывод только нечетных коэффициентов у треугольника распечатайте хотя бы 120 строк


int[,] tr = CreateTriangle(120);
PrintTriangle(tr);
int[] koeff = GetKoeff(tr, 5);
Console.WriteLine();

for (int i = 0; i < koeff.Length; i++)
{
  Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b^{i} + ");
}

