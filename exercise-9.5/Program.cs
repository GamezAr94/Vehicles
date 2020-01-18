using System;

namespace exercise_9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPassanger(new Compact());
            AddPassanger(new SUV());
            AddPassanger(new Pickup());
            AddPassanger(new PassengerTrain());
            Console.Read();
        }
        static void AddPassanger(IPassangerCarrier Vehicle)
        {
            Console.WriteLine(Vehicle.ToString());
        }
    }
}
