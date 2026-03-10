using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP6
{
    internal class MaxTicket :Ticket
    {
        public bool Is3D { get; set; }
        public MaxTicket(int id, string moveName, double price, bool is3D) : base(id, moveName, price)
        {
            Is3D = is3D;
        }
        public override double CalcLastPrice() => Is3D ? Price * 1.14 : Price;
        public override string Tickettype() => "Max Ticket";
    }
}
