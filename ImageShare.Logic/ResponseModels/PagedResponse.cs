using ImageShare.Logic.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageShare.Logic.ResponseModels
{
    public abstract class PagedResponse
    {
        public int Page { get; set; }

        public int PageSize { get; set; }

        public SortBy SortBy { get; set; }

        public int Total { get; set; }
    }
}
