using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
        class ExitSensor : Sensor
        {
            // ATTRIBUTES

            // NO ADDITIONAL ATTRIBUTES

            // CONSTRUCTORS
            public ExitSensor(CarPark carPark)
                : base()
            {
                this.carPark = carPark;
            }

            public override void CarDetected()
            {
                CarOnSensor = true;
                carPark.CarArrivedAtExit();
            }

            public override void CarLeftSensor()
            {
                CarOnSensor = false;
                carPark.CarExitedCarpark();
            }

           
        }
}
