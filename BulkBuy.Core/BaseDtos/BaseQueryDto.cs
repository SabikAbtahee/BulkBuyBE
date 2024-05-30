using System;
namespace BulkBuy.Core.BaseDtos
{
    public class BaseQueryDto<TData>
    {
        public bool Success { get; set; }
        public TData Data { get; set; }
        public List<string> ErrorMessages { get; set; }
        public int TotalCount { get; set; }
        public int HttpStatusCode { get; set; }

        public BaseQueryDto()
        {
        }
    }
}

