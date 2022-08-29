Console.Write("Введите день недели: ");
string day = Console.ReadLine();
Console.Clear();
if(day=="6"||day=="7"|| day.ToLower() =="суббота"||day.ToLower() =="воскресенье")
{
   Console.WriteLine(day+" -> выходной день"); 
}
else
{
    if(day=="1"||day=="2"||day=="3"||day=="4"||day=="5"||day.ToLower()=="понедельник"||day.ToLower()=="вторник"||day.ToLower()=="среда"||day.ToLower()=="четверг"||day.ToLower()=="пятница")
{
    Console.WriteLine(day+" -> рабочий день");
}
else
{
    Console.WriteLine(day+" -> пожалуйста, введите цифру от 1 до 7 или корректное название дня недели");
}
}