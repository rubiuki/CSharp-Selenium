using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    internal class Car
    {
        string color;
        int numberOfDoors;
        bool isConvertable;

        public Car(string carColor, int doors, bool convertable)
        {
            Color = carColor;
            NumberOfDoors = doors;
            IsConvertable = convertable;
        }

        public string Color
        {
            get
            {
                return color;
            }
            set 
            {
                color = value;
            } 
        }
        public int NumberOfDoors
        {
            get
            {
                return numberOfDoors;
            }
            set
            {
                if(value<=4) { 
                    numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("Car should have 4 doors.");
                }
            }
        }
        public bool IsConvertable
        {
            get; set;
        }

        public void Accelerate()
        {
            Console.WriteLine("I am accelerating!");
        }

        public bool FamilyCar()
        {
            if (NumberOfDoors >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
