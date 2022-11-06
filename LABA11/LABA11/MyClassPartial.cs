using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LABA11
{
    public partial class Car
    {
        public int _id
        {
            get
            {
                return id;
            }
        }

        public string _name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int _year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string _model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string _color
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

        public int _cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public static int _ColCar
        {
            get
            {
                return ColCar;
            }
        }
    }
}
