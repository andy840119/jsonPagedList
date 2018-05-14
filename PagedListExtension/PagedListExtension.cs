using System;

namespace PagedList
{
    public static class PagedListExtension
    {
        /// <summary>
        /// Combine two page Data
        /// </summary>
        /// <param name="pagedList1"></param>
        /// <param name="pagedList2"></param>
        public static void CombinePageData<TMataData, TData>(this IPagedList<TMataData, TData> pagedList1, IPagedList<TMataData, TData> pagedList2) where TMataData : class, IPageMetaData, new()
        {
            
        }
    }
}
