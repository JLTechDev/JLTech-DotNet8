using Business.Models;
using Database;
using Database.Entities;
using Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Business.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly JLTechContext _context;

        public TicketRepository(JLTechContext context)
        {
            _context = context;
        }

        public async Task Add(TicketDto ticket)
        {
            await _context.Ticket.AddAsync(new Ticket
            {
                Priority = ticket.Priority,
                Description = ticket.Description,
                Status = ticket.Status,
            });

            await _context.SaveChangesAsync();
        }

        public async Task<TicketDto> Get(int ticketId)
        {
            return await _context.Ticket
                .Where(x => x.Id == ticketId)
                .Select(x => new TicketDto
            {
                Id = x.Id,
                Priority = x.Priority,
                Description = x.Description,
                Status = x.Status,
            }).FirstAsync();
        }

        public async Task Update(TicketDto ticket)
        {
            var existingTicket = await _context.Ticket.FirstAsync(x => x.Id == ticket.Id);

            existingTicket.Status = ticket.Status;
            existingTicket.Description = ticket.Description;
            existingTicket.Priority = ticket.Priority;

            await _context.SaveChangesAsync();
        }
    }
}
