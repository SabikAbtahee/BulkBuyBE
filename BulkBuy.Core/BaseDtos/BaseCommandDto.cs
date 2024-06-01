using System;
namespace BulkBuy.Core.BaseDtos
{
    public class BaseCommandDto<TData> : BaseDto
    {

        public TData Data { get; set; }

        public List<string> ErrorMessages { get; set; }


        public BaseCommandDto()
        {
        }
    }
}

