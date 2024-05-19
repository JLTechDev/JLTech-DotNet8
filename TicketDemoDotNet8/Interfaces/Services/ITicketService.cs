using Business.Models;

namespace Interfaces.Services
{
    public interface ITicketService
    {
        Task Add(TicketDto ticket);
        Task<TicketDto> Get(int ticketId);
        Task Update(TicketDto ticket);
    }
}
