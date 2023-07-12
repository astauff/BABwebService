using System;
using BABwebService.Models;
using BABwebService.DTO.EventDTOs;
using BABwebService.Repositories.EventRepos;
using AutoMapper;

namespace BABwebService.Services
{
	public class EventService: IEventService
	{
		private readonly IEventRepo _eventRepo;
		private readonly IMapper _mapper;

		public EventService(IEventRepo eventRepo, IMapper mapper)
		{
			_eventRepo = eventRepo;
			_mapper = mapper;
		}

        public async Task<EventListDTO> GetMultiEvents(Guid guid)
        {
			var events = await _eventRepo.GetEvents(guid);
			if (events.Any())
			{
				EventListDTO eventListDTO = new EventListDTO();
				eventListDTO.EventList = _mapper.Map<List<EventDTO>>(events).OrderByDescending(dto => dto.eventDate).ToList();
				eventListDTO.ReturnCode = "0";
				return eventListDTO;
			}
			else
			{
				return new EventListDTO()
				{
					ReturnCode = "9",
					Errors = { "Unable to find events" }

				};
			}

        }
    }
}

