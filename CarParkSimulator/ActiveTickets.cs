using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        //ATTRIBUTES
        private List<Ticket> tickets;

        //CONSTRUCTOR
        public ActiveTickets()
        {
            tickets = new List<Ticket>();
        }
        
        //FUNCTIONS
        public void AddTicket()
        {
            tickets.Add(new Ticket());
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        public void RemoveTicket(int ticketCode)
        {
            //loop over each ticket in the collection tickets
            foreach (Ticket ticket in tickets)
            {
                //when the customers ticket is found in the list....
                if (ticketCode == ticket.GetHashCode())                        
                {
                    //remove that ticket from the list
                    tickets.Remove(ticket);
                }
            }
        }
    }
}
