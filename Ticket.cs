using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public abstract class Ticket
    {
        string Name;
        string departure;
        string destination;
        bool firstClass;
        int discount;

        public abstract int getPrice();
        public abstract void makeTicket(string from, string to, bool first, int discountPercent);
    }

    public class NormalTicket : Ticket
    {
        string Name;
        string departure;
        string destination;
        bool firstClass;
        int discount;

        public override int getPrice()
        {
            throw new NotImplementedException();
        }

        public override void makeTicket(string from, string to, bool first, int discountPercent)
        {
            Name = from + " to " + to;
            departure = from;
            destination = to;
            firstClass = first;
            discount = discountPercent;
        }
    }

}
