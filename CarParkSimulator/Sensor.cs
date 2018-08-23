using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        protected bool CarOnSensor;
        //protected int SensorNumber;
         protected CarPark carPark;

        // CONSTRUCTORS

        public Sensor()
        {
            CarOnSensor = false;
            
        }

        // OPERATIONS
        public bool IsCarOnSensor()
        {
            return CarOnSensor;
        }

        public virtual void CarDetected()
        {
            this.CarOnSensor = true;
        }

        public virtual void CarLeftSensor()
        {
            this.CarOnSensor = false;
        }
    }
}
