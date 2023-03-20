Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[x];
for (int i = 0; i < x; i++)
{
  Console.WriteLine("Напишите элемент массива");
  string y = Console.ReadLine();
  array1[i] = y;
}
string[] array2 = new string[array1.Length];
