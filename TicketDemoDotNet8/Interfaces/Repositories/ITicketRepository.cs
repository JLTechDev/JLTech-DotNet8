using Business.Models;

namespace Interfaces.Repositories
{
    public interface ITicketRepository
    {
        Task Add(TicketDto ticket);
        Task<TicketDto> Get(int ticketId);
        Task Update(TicketDto ticket);
    }
}
