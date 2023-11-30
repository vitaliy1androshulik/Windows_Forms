using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CarsHomeWork
{ 
    [Serializable]
    internal class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Probig { get; set; }
        public double Volume { get; set; }

        public Car():this("no model", 2000, "no color", 0, 0.0) {}
        public Car(string model, int year, string color, int probig, double volume)
        {
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.Probig = probig;
            this.Volume = volume;
        }
        public string Show()
        {
            return $"Model :: {Model}\nYear :: {Year}\nColor :: {Color}\nProbig :: {Probig}\nVolume :: {Volume}";
        }
        public override string ToString()
        {
            return $"{Model} - {Year} - {Probig} km. - Color : {Color} - Volume : {Volume}";
        }
    }
}
