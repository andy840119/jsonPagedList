using System;
using System.Collections.Generic;
using System.Text;

namespace PagedList
{
    /// <summary>
    /// Page request
    /// </summary>
    public class PageRequest : IPageRequest
    {
        /// <summary>
        /// Index
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        public int Size { get; set; }
    }
}
