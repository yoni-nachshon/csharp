using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrive[] cars = new IDrive[10];
            Driver[] drivers = new Driver[5];


            cars[0] = new SmallCar(121, "1111", "a");
            cars[1] = new SmallCar(121, "2222", "b");
            cars[2] = new SmallCar(121, "3333", "c");
            cars[3] = new MediumCar(121, "4444", "aa", false);
            cars[4] = new MediumCar(121, "5555", "bb", true);
            cars[5] = new MediumCar(121, "6666", "cc", true);
            cars[6] = new LargeCar(121, "7777", "g", 10, 7000);
            cars[7] = new LargeCar(121, "8888", "f", 20, 8000);
            cars[8] = new Track(12000);
            cars[9] = new Track(14000);

            for (int i = 0; i < 5; i++)
            {
                drivers[i] = new Driver();
                Console.WriteLine("Enter a name Driver");
                drivers[i].name = Console.ReadLine();
                Console.WriteLine("Enter size 1 = Small 2 = Medium; 3 = Large");
                drivers[i].sizeCar = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter waightMax");
                drivers[i].waightMax = int.Parse(Console.ReadLine());

                for (int x = 0; x < cars.Length; x++)
                {
                    Console.WriteLine("cars[" + x + "]" + cars[x].CanDrive(drivers[i]));
                }
                                
            }
        }
      
    }
}
