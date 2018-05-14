using System;
using System.Collections.Generic;
using System.Text;

namespace PagedList
{
    public interface IPageMetaData
    {
        /// <summary>
        /// Page index
        /// </summary>
        int PageIndex { get; set; }

        /// <summary>
        /// page size
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// total count
        /// </summary>
        int TotalCount { get; set; }

        /// <summary>
        /// total page
        /// </summary>
        int TotalPages { get; set; }

        /// <summary>
        /// has pervious page
        /// </summary>
        bool HasPreviousPage { get; }

        /// <summary>
        /// has next page
        /// </summary>
        bool HasNextPage { get; }
    }
}
