using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        //ATTRIBUTES
        private string message;
        private ActiveTickets tickets;
        private CarPark carPark;

        //CONSTRUCTOR
        public TicketMachine(ActiveTickets tickets)
        {
            this.tickets = tickets;
        }
        //FUNCTIONS
        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please press to get a ticket.";
        }

        public void PrintTicket()
        {
            message = "Thank you, enjoy your stay.";
            tickets.AddTicket();
            carPark.TicketDispensed();
        }

        public void ClearMessage()
        {
            message = "";
        }

        public string GetMessage()
        {
            return message;
        }
    }
}
