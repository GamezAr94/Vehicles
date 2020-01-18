using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_9._5
{
    abstract class Car : Vehicle
    {
    }

    class Compact : Car, IPassangerCarrier
    {

    }

    class SUV : Car, IPassangerCarrier
    {

    }

    class Pickup : Car, IHeavyLoadCarrier, IPassangerCarrier
    {

    }
}
