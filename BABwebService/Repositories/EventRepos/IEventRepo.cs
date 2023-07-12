using System;
using BABwebService.Models;

namespace BABwebService.Repositories.EventRepos
{
	public interface IEventRepo
	{
		Task<IEnumerable<EventModel>> GetEvents(Guid guid); 
	}
}

