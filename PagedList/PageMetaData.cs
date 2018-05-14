using System;
using System.Collections.Generic;
using System.Text;

namespace PagedList
{
    public class PageMetaData : IPageMetaData
    {
        /// <summary>
        /// Page index
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// page size
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// total count
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// total page
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// has pervious page
        /// </summary>
        public bool HasPreviousPage { get; set; }

        /// <summary>
        /// has next page
        /// </summary>
        public bool HasNextPage { get; set; }
    }
}
