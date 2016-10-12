using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class TicketOrder
    {
        List<Ticket> allTickets;
        int totalPrice;

        public void addNormalTicket(string from, string to, bool firstClass, int discountPercent)
        {
            NormalTicket newTicket = new NormalTicket();
            newTicket.makeTicket(from, to, firstClass, discountPercent);
            allTickets.Add(newTicket);
        }

        public float getTotal()
        {
            totalPrice = 0;
            foreach(Ticket a in allTickets)
            {
                totalPrice += a.getPrice();
            }
            return totalPrice;
        }

        public void makePayment()
        {
            switch (info.Payment)
            {
                case UIPayment.CreditCard:
                    CreditCard c = new CreditCard();
                    c.Connect();
                    int ccid = c.BeginTransaction(getTotal());
                    c.EndTransaction(ccid);
                    break;
                case UIPayment.DebitCard:
                    DebitCard d = new DebitCard();
                    d.Connect();
                    int dcid = d.BeginTransaction(getTotal());
                    d.EndTransaction(dcid);
                    break;
                case UIPayment.Cash:
                    IKEAMyntAtare2000 coin = new IKEAMyntAtare2000();
                    coin.starta();
                    coin.betala((int)Math.Round(getTotal() * 100));
                    coin.stoppa();
                    break;
            }
        }
    }
    }
}
