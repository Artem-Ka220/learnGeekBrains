// Напишите программу, которая будет
// выдавать название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница

Console.WriteLine("Введите число: ");
int yourNum = Convert.ToInt32((Console.ReadLine()));
if(yourNum == 1){
    Console.WriteLine("Понедельник.");
}else if(yourNum == 2){
    Console.WriteLine("Вторник.");
}else if(yourNum == 3){
    Console.WriteLine("Среда.");
}else if(yourNum == 4){
    Console.WriteLine("Четверг.");
}else if(yourNum == 5){
    Console.WriteLine("Пятница.");
}else if(yourNum == 6){
    Console.WriteLine("Суббота.");
}else if(yourNum == 7){
    Console.WriteLine("Воскресенье.");
}else{
    Console.WriteLine("Такого дня недели нет.");
}