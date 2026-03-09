using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP6
{
    public class StandardTicket:Ticket
    {
        public StandardTicket(int id, string moveName, double price) : base(id, moveName, price) { }
        public override double CalcLastPrice()=> Price*1.14;
        public override string Tickettype()=> "Standard Ticket";


    }
}
