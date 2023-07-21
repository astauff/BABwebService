using System;
using BABwebService.Models;

namespace BABwebService.Repositories.EventRepos
{
	public interface IEventRepo
	{
		Task<IEnumerable<EventModel>> GetEvents(Guid guid);
		Task<int> PostEvent(EventModel eventModel, Guid guid);
	}
}

