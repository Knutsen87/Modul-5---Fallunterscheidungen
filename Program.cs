// See https://aka.ms/new-console-template for more information

class BMI
{
    static void main(String[] args)
    {

        Console.WriteLine("Bitte nennen Sie ihr Gewicht: ");
        double Gewicht = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Bitte nennen Sie ihre Körpergröße: ");
        double Größe = Convert.ToDouble(Console.ReadLine());

        double BMI = (Gewicht / (Größe * Größe));
        string Ergebnis = "";

        if (BMI < 18.5)
        {
            Ergebnis = "Untergewicht";
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Ergebnis = "Normalgewicht";
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Ergebnis = "Übergewicht";
        }
        else if (BMI >= 30 && BMI < 35)
        {
            Ergebnis = "Adipositas Grad 1!";
        }
        else if (BMI >= 35 && BMI < 40)
        {
            Ergebnis = "Adipositas Grad 2";
        }
        else if (BMI >= 40)
        {
            Ergebnis = "Adipositas Grad 3";
        }
        Console.WriteLine("Dein BMI beträgt {0}, das ist {1}.\n", BMI, Ergebnis);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie eine Jahreszahl ein: ");
        int Jahr = Convert.ToInt32(Console.ReadLine());

        if (IstSchaltJahr(Jahr))
        {
            Console.WriteLine(Jahr + "Ist ein Schaltjahr!");
        }
        else
        {
            Console.WriteLine(Jahr + "Ist kein Schaltjahr!");
        }
        Console.ReadKey();
    }


    static bool IstSchaltJahr(int Jahr)
    {
        return (Jahr % 4 == 0 && Jahr % 100 != 0) || (Jahr % 400 == 0);
    }



}



