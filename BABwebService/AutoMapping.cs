using System;
using BABwebService.Models;
using BABwebService.DTO.EventDTOs;
using AutoMapper;

namespace BABwebService
{
	public class AutoMapping: Profile
	{
		public AutoMapping()
		{
			CreateMap<EventModel, EventDTO>();
		}
	}
}

