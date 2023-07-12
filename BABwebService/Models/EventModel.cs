using System;
using Dapper.Contrib.Extensions;

namespace BABwebService.Models
{
	[Table("eventInfo")]
	public class EventModel
	{
			public string eventName { get; set; }
			public DateTime eventDate { get; set; }
			public DateTime eventStart { get; set; }
			public DateTime eventEnd { get; set; }
			public bool groupEvent { get; set; }
			public string groupMembers { get; set; }
	}
}

