using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOP
{
    internal class WaterBottle
    {
        private string color;
        private double wateramount;
        private double capacity;

        public WaterBottle(): this("white",100)
        {

        }
        public WaterBottle(string color, double capacity)
        {
            this.color = color;
            this.capacity = capacity;
        }
        

        ~WaterBottle() //destructor
        {
            this.color = null;
            this.wateramount = 0;
        }
        public string Color
        {
            get
            {
                return color;
            }
        }

        public bool IsOpen
        { get; set; }
        public double Wateramount
        { 
          get {
                if(wateramount<0)
                    return 0;
                else if(wateramount>capacity)
                    return capacity;
                else 
                    return wateramount;
            } 
          set { 
                if (value < 0 && value >= capacity)
                    wateramount = value;
            } }

        public void AddWater(double amount)
        {
            wateramount += amount;
        }
        public void AddWater(int amount)
        {
            wateramount += amount;
        }
    }
}
