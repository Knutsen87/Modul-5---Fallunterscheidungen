// See https://aka.ms/new-console-template for more information


int age = 14;
bool withParents = false;

/* if (age >= 18)
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
*/


int alter = 18;
bool mobil = false;
bool qualifiziert = true;
bool testBestanden = false;
bool schüchtern = false;

if ((alter >= 18) && (mobil) && (qualifiziert || testBestanden) && !schüchtern)
{
    Console.WriteLine("Du bekommst den Job.");
}
else
{
    Console.WriteLine("Du bekommst den Job leider nicht.");
}

Console.ReadKey();