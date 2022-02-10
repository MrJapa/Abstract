abstract class Bil
{
    public abstract void Model(); //Abstrakte metoder har ikke en body og kan kun laves i abstrakte klasser
    public abstract void DrivMiddel(); //Samme her
    public void Kør() //En normal metode
    {
        Console.WriteLine("Bilen kan køre");
    }
}

class førsteBil : Bil
{
    public override void Model() //For at få adgang til disse metoder, er vi nødt til at arve fra klassen bil.
    {
        Console.WriteLine("Bilen er en Tesla");
    }

    public override void DrivMiddel()
    {
        Console.WriteLine("Bilen kører på el\n");
    }

}

class andenBil : Bil
{
    public override void Model()
    {
        Console.WriteLine("Bilen er en Toyota");
    }
    public override void DrivMiddel()
    {
        Console.WriteLine("Bilen kører på benzin");
    }
}
/*
class tredjeBil //Denne klasse vil ikke virke, da den ikke arver fra den Bil klassen, så den har ikke adgang til metoder som er defineret deri.
{
    public override void Model();
    {
        Console.WriteLine("Bilen er en kampvogn");
    }
    public override void DrivMiddel();
    {
        Console.WriteLine("Bilen kører på benzin");
    }
}
*/

class Program
{
    static void Main(string[] args)
    {
        førsteBil bil1 = new førsteBil();
        bil1.Model();
        bil1.DrivMiddel(); 
        andenBil bil2 = new andenBil();
        bil2.Model();
        bil2.DrivMiddel();
    }
}

/*
class Program2
{
    static void Main2(string[] args)
    {
        Bil bil = new Bil();    //Hvis vi prøver dette, vil programmet slå fejl, da man ikke kan lave en instans af en abstract klasse, men kun af arvede klasser.
    }
}
*/