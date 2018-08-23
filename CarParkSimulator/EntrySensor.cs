using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class EntrySensor : Sensor
    {
        // ATTRIBUTES

        // NO ADDITIONAL ATTRIBUTES

        // CONSTRUCTORS
        public EntrySensor(CarPark carPark)
            : base()
        {
            this.carPark = carPark;
        }

        public override void CarDetected()
        {
            CarOnSensor = true;
            carPark.CarArrivedAtEntrance();
        }

        public override void CarLeftSensor()
        {
            CarOnSensor = false;
            carPark.CarEnteredCarpark();
        }
       

    }
}