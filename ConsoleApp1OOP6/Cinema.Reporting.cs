using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP6
{
    public partial class Cinema
    {
        public void AllTickets() 
        {
            Console.WriteLine("All Tickets:(from cinema reporting)");
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"Id: {ticket.Id}, Movie: {ticket.MoveName}, Price: {ticket.Price},Final : {ticket.CalcLastPrice}:F2, Type: {ticket.Tickettype()}, Status: {ticket.Status()}");
            }

        }
        public void FinalPrices()
        {
            Console.WriteLine(" Polymorphism: final price per ticket ");
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"{ticket.Tickettype()} => Final Price: {ticket.CalcLastPrice():F2}");
            }
        }

    }
}
