﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroShoping.DomainBase
{
    public class RequestPageBase
    {
        public int PageIndex { get; set; }
        public int TotalCount {  get; set; }
        public int PageSize { get; set; }
    }
    public class ResponsePageBase<T>
    {
        public IEnumerable<T> List { get; set; }
        public int PageIndex { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PageTotal { get; set; }
    }
}
