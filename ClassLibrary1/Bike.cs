using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Bike
    {
        private int _id;
        private int _price;
        private int _gear;
        private string _color;

        public Bike()
        {

        }

        public Bike(int id, int price, int gear, string color)
        {
            _id = id;
            _price = price;
            _gear = gear;
            _color = color;
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value >= 0) _id = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public string Color
        {
            get => _color;
            set
            {
                if (value != null) _color = value;
                else throw new ArgumentNullException();
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value >= 0) _price = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public int Gear
        {
            get => _gear;
            set
            {
                if (value >= 3 && value <= 32) _gear = value;
                else throw new ArgumentOutOfRangeException();
            }
        }


    }
}
