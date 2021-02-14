using System;
using Tickets.Models;

namespace Tickets.Interfaces
{
    public interface ITicketService
    {
        void CreateTickets(TicketsSettings ticketsSettings);
    }
}
