using System;
using System.Collections.Generic;
using System.Text;

namespace PagedList
{
    public interface IPageMetaData
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        int TotalCount { get; set; }
        int TotalPages { get; set; }
        bool HasPreviousPage { get; set; }
        bool HasNextPage { get; set; }
    }
}
