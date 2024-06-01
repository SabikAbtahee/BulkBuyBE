using System;
namespace BulkBuy.Core.BaseDtos
{
	public class BaseDto
	{
		public int StatusCode { get; set; }
		public string Message { get; set; }
        public bool Success { get; set; }

        public BaseDto()
		{
		}
	}
}

