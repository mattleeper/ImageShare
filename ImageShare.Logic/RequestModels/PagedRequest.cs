﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageShare.Logic.RequestModels
{
    public enum SortBy
    {
        Created,
        Title
    }

    public class PagedRequest
    {
        public string Requestor { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }

        public SortBy SortBy { get; set; }
    }
}
