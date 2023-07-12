using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BABwebService.DTO.EventDTOs;
using BABwebService.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BABwebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("Event")]
        public async Task<IActionResult> GetEvents()
        {
            var guid = Guid.NewGuid();
            var response = await _eventService.GetMultiEvents(guid);

            if(response.ReturnCode == "0")
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

    }
}

