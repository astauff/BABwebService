using System;
using BABwebService.DTO;

namespace BABwebService.DTO.EventDTOs
{
	public class EventDTO : BaseResponseDTO
	{
        public string eventName { get; set; }
        public DateTime eventDate { get; set; }
        public DateTime eventStart { get; set; }
        public DateTime eventEnd { get; set; }
        public bool groupEvent { get; set; }
        public string groupMembers { get; set; }
    }
}

