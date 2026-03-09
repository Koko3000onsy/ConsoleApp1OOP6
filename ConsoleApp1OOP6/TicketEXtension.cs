using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP6
{
    public static class TicketEXtension
    {
        public static string Receipt(this Ticket ticket)
        {
            return 
                $@"========== RECEIPT ==========
                 Movie    : {ticket.MoveName}
                 Type     : {ticket.Tickettype()}
                 Price    : {ticket.Price}
                 Final    : {ticket.CalcLastPrice():F2}
                 Status   : {ticket.Status()}";
        }
        public static double TotalRevenue(this Ticket[] tickets)
        {
            double total = 0;
            foreach (var ticket in tickets)
                total += ticket .CalcLastPrice();
            return total;
        }
    }
}
