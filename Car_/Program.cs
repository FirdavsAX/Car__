namespace Car_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1112, "Matiz", "Chevrolet", 50_000_000);
            Car car2 = new Car(1122, "Spark", "GM", 80_000_000);
            Car car3 = new Car(1211, "Lacetti", "UzAvtoMotors", 200_000_000);
            Car car4 = new Car(1121, "Cobalt", "Chevrolet", 180_000_000);
            Car car5 = new Car(1120, "KiaK5", "KIA", 300_000_000);

            car1.DisplayInfo();
            car2.DisplayInfo();
            car3.DisplayInfo();
            car4.DisplayInfo();
            car5.DisplayInfo();

            Car.TaxPersantage = 10;
            
            car1.CalculateTotal();
            car2.CalculateTotal();
            car3.CalculateTotal();
            car4.CalculateTotal();
            car5.CalculateTotal();

            car1.DisplayInfo();
            car2.DisplayInfo();
            car3.DisplayInfo();
            car4.DisplayInfo();
            car5.DisplayInfo();

            Console.ReadKey();
        }
    }
}