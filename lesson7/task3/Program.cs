// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d


Console.WriteLine("Введите строку");
string userInput = Console.ReadLine();

string vowels= "aieuo";
string result ="";
int i=0;

void PrintUserInput(int countElement,string str)
{
    if(str.Length==countElement)
    {
        return;    
    }

    if(!vowels.Contains(str[countElement]))
    {
        result = result+str[countElement];
    }

    PrintUserInput(countElement+1,str);
}

PrintUserInput(i,userInput);

System.Console.WriteLine(result);
