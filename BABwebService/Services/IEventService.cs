using System;
using BABwebService.DTO.EventDTOs;

namespace BABwebService.Services
{
	public interface IEventService
	{
		public Task<EventListDTO> GetMultiEvents(Guid guid);

		public Task<int> PostEvent(EventDTO eventDTO, Guid guid);
	}
}

