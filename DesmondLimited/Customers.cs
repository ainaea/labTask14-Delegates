using System;

namespace DesmondLimited
{
    public class Customers
    {
        public string Name { get; private set; }
        public decimal Principal { get; private set; }
        public float Rate { get; private set; }
        public int Time { get; private set; }

        public Customers(string name, decimal principal, float rate, int time)
        {
            Name = name;
            Principal = principal;
            Rate = rate;
            Time = time;
        }

        public decimal GetSimpleInterest()
        {
            return Principal * (decimal) Rate * Time / 100;
        }

        public decimal GetCompoundInterest()
        {
            return Principal * (decimal) Math.Pow( 1 + Rate/ 100, Time);
        }
    }
}