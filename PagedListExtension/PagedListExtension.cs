using System;
using System.Reflection;

namespace PagedList
{
    public static class PagedListExtension
    {
        /// <summary>
        /// Combine two page Data
        /// </summary>
        /// <param name="pagedList1"></param>
        /// <param name="pagedList2"></param>
        public static void CombinePageData<TData>(this IPagedList<TData> pagedList1, IPagedList<TData> pagedList2)
        {
            if(pagedList1== null || pagedList2==null)
                throw new ArgumentNullException(nameof(pagedList1) + "cannot be null.");

            if (pagedList1.PageSize != pagedList2.PageSize)
                throw new AmbiguousMatchException(nameof(IPagedList<TData>) + "'s page size shuld be same");

            if(pagedList1 == pagedList2)
                throw new ArgumentException(nameof(pagedList1) + "cannot be same as " + nameof(pagedList2));

            foreach (var value in pagedList2.Data)
            {
                pagedList1.Data.AddOrUpdate(value);
            }

            pagedList1.TotalCount = pagedList2.TotalCount;
            pagedList1.TotalPages = pagedList2.TotalPages;
        }

        /// <summary>
        /// Create pervious page request 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <returns></returns>
        public static IPageRequest CreatePervoiusPageRequest<TData>(this IPagedList<TData> pagedList)
        {
            if (!pagedList.HasPreviousPage)
                return null;

            return new PageRequest()
            {
                Index = pagedList.MinDataPage -1,
                Size = pagedList.PageSize
            };
        }

        /// <summary>
        /// Create next page request 
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <returns></returns>
        public static IPageRequest CreateNextPageRequest<TData>(this IPagedList<TData> pagedList)
        {
            if (!pagedList.HasNextPage)
                return null;

            return new PageRequest()
            {
                Index = pagedList.MaxDataPage + 1,
                Size = pagedList.PageSize
            };
        }
    }
}
