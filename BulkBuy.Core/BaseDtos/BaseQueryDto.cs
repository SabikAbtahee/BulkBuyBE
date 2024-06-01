﻿using System;
namespace BulkBuy.Core.BaseDtos
{
    public class BaseQueryDto<TData> : BaseDto
    {
        public TData Data { get; set; }
        public List<string> ErrorMessages { get; set; }
        public int TotalCount { get; set; }

        public BaseQueryDto()
        {
        }
    }
}

