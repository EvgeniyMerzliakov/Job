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

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}