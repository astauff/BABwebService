using System;
using BABwebService.DTO;

namespace BABwebService.DTO.EventDTOs
{
	public class EventListDTO: BaseResponseDTO
	{
		public IEnumerable<EventDTO> EventList { get; set; } = new List<EventDTO>();
	}
}

