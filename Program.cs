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
    Console.WriteLine("Du bekommst den Job leider nicht.\n");
}

Console.WriteLine("Bitte geben Sie einen Wert zwischen 1 und 8 ein: ");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1:
        Console.WriteLine("Es ist Montag.");
        break;

    case 2:
        Console.WriteLine("Es ist Dienstag!");
        break ;

    case 3:
        Console.WriteLine("Es ist Mittwoch meine Kerle!");
        break;

    case 4:
        Console.WriteLine("Es ist Donnerstag!");
        break;

    case 5:
        Console.WriteLine("Es ist Freitag!");
        break;

    case 6:
        Console.WriteLine("Es ist Samstag");
        break;

    case 8:
        Console.WriteLine("Es ist schon wieder Mittwoch -.-");
        break;

        default:
        Console.WriteLine("Dieser Wert konnte nicht zugeordnet werden.");
        break;
}

Console.WriteLine("\nBitte wählen sie einen der folgenden Kommandos aus: SayHello, SayGoodbye oder Smile.");
Console.Write("Command: ");
string command = Console.ReadLine();

switch(command)
{
    case "SayHello":
        Console.WriteLine("Hallo!");
        break;

    case "SayGoodbye":
        Console.WriteLine("Auf wiedersehen!");
        break;

    case "Smile":
        Console.WriteLine("=)");
        break;

        default :
        Console.WriteLine("Ungültiger Befehl!");
        break;
}

Console.ReadKey();