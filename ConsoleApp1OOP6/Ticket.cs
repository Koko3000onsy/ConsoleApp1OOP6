using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP6
{
    public abstract class Ticket
    {
        public int Id { get; set; }
        public string MoveName { get; set; }
        public double Price { get; set; }
        public bool isbooked { get; set; }
        public Ticket(int id, string moveName, double price)
        {
            Id = id;
            MoveName = moveName;
            Price = price;
            isbooked = false;
        }   
        public abstract double CalcLastPrice();
        public virtual string Tickettype()=> "Regular Ticket";
        public string Status()
        {
            if (isbooked)
                return "Booked";
            else
                return "Available";
        }
        public void Book()=> isbooked = true;

        public void Cancel()=> isbooked = false;




    }
}
