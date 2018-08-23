using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        //ATTRIBUTES
        private string message;
        private ActiveTickets tickets;
        private CarPark carPark;

        //CONSTRUCTOR
        public TicketValidator (ActiveTickets tickets)
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
            message = "Please insert your ticket.";
        }

        public void TicketEntered(int ticketCode)
        {
            message = "Thank you, drive safely.";
            tickets.RemoveTicket(ticketCode);
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
