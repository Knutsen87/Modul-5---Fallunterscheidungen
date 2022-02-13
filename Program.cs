// See https://aka.ms/new-console-template for more information


int age = 14;
bool withParents = false;

if (age >= 18)
{
    Console.WriteLine("Du darfst den Film sehen!");
}
else if (withParents == true)
{
    Console.WriteLine("Du darfst den Film dank deiner Eltern sehen!");
}
else
{
    Console.WriteLine("Du darfst den Film nicht sehen!");
}
Console.ReadKey();