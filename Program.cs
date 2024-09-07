using static Csharp_DZ_NEW_1_Dedok.Money;
namespace Csharp_DZ_NEW_1_Dedok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 
            Money price1 = new Money(2, 75);
            Money discount = new Money(1, 50);

            Console.WriteLine($"Initial price: {price1}");
            Console.WriteLine($"Discount: {discount}");

            Product product = new Product("Laptop", price1);

            Console.WriteLine(product);

            product.DecreasePrice(discount);

            Console.WriteLine("After discount:");
            Console.WriteLine(product);

            Money price2 = new Money(4, 25);
            Console.WriteLine($"Price1 equals Price2? {price1.Equals(price2)}");

            Product product2 = new Product("Laptop", price2);
            Console.WriteLine($"Product equals Product2? {product.Equals(product2)}");

            Console.WriteLine($"HashCode of Product: {product.GetHashCode()}");
            Console.WriteLine($"HashCode of Product2: {product2.GetHashCode()}");
            Console.WriteLine();
            Console.ReadKey();
            //2
            Kettle kettle = new Kettle("Electric Kettle");
            Microwave microwave = new Microwave("Samsung Microwave");
            Car car = new Car("Toyota Corolla");
            Steamship steamship = new Steamship("Old Steamship");

            Console.WriteLine("Checking Kettle:");
            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Checking Microwave:");
            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Checking Car:");
            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Checking Steamship:");
            steamship.Show();
            steamship.Sound();
            steamship.Desc();
            Console.WriteLine();
            Console.ReadKey();

            Kettle anotherKettle = new Kettle("Electric Kettle");
            Console.WriteLine($"Kettle equals Another Kettle? {kettle.Equals(anotherKettle)}");
            Console.ReadKey();

            Console.WriteLine(kettle.ToString());
            Console.ReadKey();

            Console.WriteLine($"HashCode of Kettle: {kettle.GetHashCode()}");
            Console.WriteLine($"HashCode of Another Kettle: {anotherKettle.GetHashCode()}");
            Console.WriteLine();
            Console.ReadKey();
            //4
            Tvarina[] zoo = new Tvarina[3];
            zoo[0] = new Tygr("Амурський тигр", "Ліси", "М'ясоїдний", 60);
            zoo[1] = new Krokodyl("Нільський крокодил", "Річки", "М'ясоїдний", 5);
            zoo[2] = new Kenguru("Червоний кенгуру", "Австралія", "Травоїдний", 3);

            foreach (var animal in zoo)
            {
                animal.ShowInfo();
                Console.WriteLine($"Хеш-код: {animal.GetHashCode()}");
                Console.WriteLine();
            }
            int predatorsCount = 0;
            int meatFood = 0; 
            int plantFood = 0; 

            foreach (var animal in zoo)
            {
                if (animal.IsPredator)
                {
                    predatorsCount++;
                    meatFood += 10; 
                }
                else
                {
                    plantFood += 5;
                }
            }
            Console.WriteLine($"Кількість хижаків у зоопарку: {predatorsCount}");
            Console.WriteLine($"Обсяг корму для хижаків: {meatFood} кг");
            Console.WriteLine($"Обсяг рослинної їжі для травоїдних: {plantFood} кг");
            Console.ReadKey();
        }
    }
}
