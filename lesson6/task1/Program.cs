// // Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 

char[] array = new char[] { 'ц', 'r', '7', '%', 'w'};

string str = "";

foreach (char item in array)
{
  str = str + item;
}

Console.WriteLine(str);
