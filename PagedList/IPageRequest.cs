using System;
using System.Collections.Generic;
using System.Text;

namespace PagedList
{
    /// <summary>
    /// page request
    /// </summary>
    public interface IPageRequest
    {
        /// <summary>
        /// Index
        /// </summary>
        int Index { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        int Size { get; set; }
    }
}
