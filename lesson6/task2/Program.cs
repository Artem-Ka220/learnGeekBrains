// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

System.Console.WriteLine("Введите строчку");
string str = Console.ReadLine();

char[] array = new char[str.Length];

for (int i = 0; i < array.Length; i++)
{
  array[i] = str[i];

  Console.Write(array[i]);
}
