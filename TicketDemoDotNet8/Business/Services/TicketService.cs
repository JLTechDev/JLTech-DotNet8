using Business.Models;
using Interfaces.Repositories;
using Interfaces.Services;

namespace Business.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task Add(TicketDto ticket)
        {
            await _ticketRepository.Add(ticket);
        }

        public async Task<TicketDto> Get(int ticketId)
        {
            return await _ticketRepository.Get(ticketId);
        }

        public async Task Update(TicketDto ticket)
        {
            await _ticketRepository.Update(ticket);
        }
    }
}
