using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class Celcius
    {
        public int Degree { get; set; }

        public Celcius(int degree)
        {
            Degree = degree;
        }

        public static implicit operator Kelvin(Celcius degree)
        {
            return new Kelvin(degree.Degree/1.7);
        }
        
    }
}
