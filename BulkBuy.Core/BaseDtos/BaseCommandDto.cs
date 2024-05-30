using System;
namespace BulkBuy.Core.BaseDtos
{
    public class BaseCommandDto<TData>
    {
        public bool Success { get; set; }

        public TData Data { get; set; }

        public List<string> ErrorMessages { get; set; }

        public int HttpStatusCode { get; set; }

        public BaseCommandDto()
        {
        }
    }
}

