using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_9._5
{
    abstract class Train : Vehicle
    {
    }

    class PassengerTrain : Train, IPassangerCarrier
    {

    }

    class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    class DoubleBogey : Train, IHeavyLoadCarrier
    {

    }

}
