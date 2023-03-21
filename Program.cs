namespace KlassenDefinieren
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Auto MyCar = new Auto("VW");
            Auto YouCar = new Auto("Audi");
            Auto ChiefCar = new Auto("Porsche");
            MyCar.BauJahr = 13;
            YouCar.BauJahr = 8;
            ChiefCar.BauJahr = 1;

            MyCar.Beschleunigung();
            YouCar.Beschleunigung();
            ChiefCar.Beschleunigung();
            Console.ReadKey();
        }
    }
}