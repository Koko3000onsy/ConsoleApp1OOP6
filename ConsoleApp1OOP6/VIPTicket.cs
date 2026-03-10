using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP6
{
    public class VIPTicket:Ticket
    {
        public bool LoungeAccess { get; set; }
        public double Fee { get; set; }
        public VIPTicket(int id, string moveName, double price , bool lounge, double fee) : base(id, moveName, price) 
        { 
            LoungeAccess = lounge;
            Fee = fee;
        }
        public override double CalcLastPrice() =>  Price +Fee* 1.6 ;
        public override string Tickettype() => "VIP Ticket";
    
    }
}
