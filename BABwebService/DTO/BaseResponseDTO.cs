using System;
namespace BABwebService.DTO
{
	public class BaseResponseDTO
	{
		public string ReturnCode { get; set; }
		public List<string> Errors { get; set; } = new List<string>();
	}
}

