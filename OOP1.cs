//OOP1
class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;

        Console.WriteLine("Vehicle Constructor");
    }
    public void start()
    {
        Console.WriteLine($" starting is:{Brand}");

    }
    class Car : Vehicle
    {
        public int NumberOfDoors;

        public Car(string brand, int year, int numberOfDoors) : base(brand, year)
        {
            NumberOfDoors = numberOfDoors;

            Console.WriteLine("Car Constructor");
        }
        


    }
    class Bus : Vehicle
    {
        public int Capacity;

        public Bus(string brand, int year, int capacity) : base(brand, year)
        {
            Capacity = capacity;

            Console.WriteLine(" Bus Constructor");
        }
       
    }
    class Motorcycle : Vehicle
    {
        public string HasSidecar;

        public Motorcycle(string brand, int year, string hasSidecar) : base(brand, year)
        {
            HasSidecar = hasSidecar;

            Console.WriteLine("Motorcycle Constructor");
        }
        
    }
    class program
    {

        static void Main(string[] args)
        {
            Car car = new Car("toyota", 2026, 4);
            Bus bus = new Bus("Merceds", 2010, 18);
            Motorcycle motorcycle = new Motorcycle("honda", 2015, "NO");
            car.start();
            bus.start();
            motorcycle.start();

        }
    }
}
 