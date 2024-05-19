using Business.Models;
using Database.Entities;
using Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace TicketDemoDotNet8.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateTicket(TicketDto ticket)
        {
            try
            {
                await _ticketService.Add(ticket);
                return Ok("It worked!");
            }
            catch (Exception ex)
            {
                return BadRequest($"It failed! {ex}");
            }
        }

        [HttpPost]
        [Route("Get")]
        public async Task<IActionResult> GetTicket(int ticketId)
        {
            try
            {
                var result = await _ticketService.Get(ticketId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"It failed! {ex}");
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> UpdateTicket(TicketDto ticket)
        {
            try
            {
                await _ticketService.Update(ticket);

                var result = await _ticketService.Get(ticket.Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"It failed! {ex}");
            }
        }
    }
}
