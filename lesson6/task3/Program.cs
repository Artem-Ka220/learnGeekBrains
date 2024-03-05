System.Console.WriteLine("Введите строку");
string userInput = Console.ReadLine();

string vowels= "aeioyu";

int countVowels=0;

foreach (char item in userInput)
{
  if(vowels.Contains(item))
  {
    countVowels++;
  }
}

System.Console.WriteLine(countVowels);
