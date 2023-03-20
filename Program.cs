namespace KlassenDefinieren
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Auto MyCar = new Auto("VW");
            Auto YouCar = new Auto("Audi");
            Auto ChiefCar = new Auto("Porsche");
            MyCar.bauJahr = 13;
            YouCar.bauJahr = 8;
            ChiefCar.bauJahr = 1;

            MyCar.Beschleunigung();
            YouCar.Beschleunigung();
            ChiefCar.Beschleunigung();
            Console.ReadKey();
        }
    }
}