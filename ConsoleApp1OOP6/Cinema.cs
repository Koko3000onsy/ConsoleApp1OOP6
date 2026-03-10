using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP6
{
    public partial class Cinema
    {
        private List<Ticket> tickets=new List<Ticket>();
        public void AddTicket(Ticket ticket) => tickets.Add(ticket);
        public void BookTicket(Ticket ticket)=> ticket.Book();
        public void CancelTicket(Ticket ticket) => ticket.Cancel();

    }
}
