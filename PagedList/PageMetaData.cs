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
        public bool HasPreviousPage => (PageIndex > 0);

        /// <summary>
        /// has next page
        /// </summary>
        public bool HasNextPage => (PageIndex + 1 < TotalPages);
    }
}
