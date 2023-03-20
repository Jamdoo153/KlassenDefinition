namespace KlassenDefinieren
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Auto MyCar = new Auto();
            Auto YouCar = new Auto();
            Auto ChiefCar = new Auto();
            MyCar.marke = "VW";
            MyCar.bauJahr = 13;
            YouCar.marke = "Audi";
            YouCar.bauJahr = 8;
            ChiefCar.marke = "Porsche";
            ChiefCar.bauJahr = 1;

            MyCar.Beschleunigung();
            YouCar.Beschleunigung();
            ChiefCar.Beschleunigung();
            Console.ReadKey();
        }
    }
}