using System.Collections.Generic;
using System.Linq;

namespace JsonPagedList
{
    public static class PagedListExtension
    {
        /// <summary>
        ///     Convert IList to PagedList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this IList<TData> pagedList, int pageIndex, int pageSize)
        {
            var pageList = new PagedList<TData>(pagedList, pageIndex, pageSize);
            return pageList;
        }

        /// <summary>
        ///     Convert IQueryable to pageList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this IQueryable<TData> pagedList, int pageIndex, int pageSize)
        {
            var pageList = new PagedList<TData>(pagedList, pageIndex, pageSize);
            return pageList;
        }

        /// <summary>
        ///     Convert ICollection to pageList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this ICollection<TData> pagedList, int pageIndex, int pageSize)
        {
            var pageList = new PagedList<TData>(pagedList, pageIndex, pageSize);
            return pageList;
        }

        /// <summary>
        ///     Convert IEnumerable to pageList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this IEnumerable<TData> pagedList, int pageIndex,
            int pageSize, int totalCount)
        {
            var pageList = new PagedList<TData>(pagedList, pageIndex, pageSize, totalCount);
            return pageList;
        }

        /// <summary>
        ///     Convert IList to PagedList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this IList<TData> pagedList, IPageRequest request)
        {
            var pageList = new PagedList<TData>(pagedList, request.Index, request.Size);
            return pageList;
        }

        /// <summary>
        ///     Convert IQueryable to pageList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this IQueryable<TData> pagedList, IPageRequest request)
        {
            var pageList = new PagedList<TData>(pagedList, request.Index, request.Size);
            return pageList;
        }

        /// <summary>
        ///     Convert ICollection to pageList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this ICollection<TData> pagedList, IPageRequest request)
        {
            var pageList = new PagedList<TData>(pagedList, request.Index, request.Size);
            return pageList;
        }

        /// <summary>
        ///     Convert IEnumerable to pageList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="request"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this IEnumerable<TData> pagedList, IPageRequest request,
            int totalCount)
        {
            var pageList = new PagedList<TData>(pagedList, request.Index, request.Size, totalCount);
            return pageList;
        }

        /// <summary>
        ///     Convert pageList to IList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pagedList"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(this PagedList<T> pagedList) where T : struct
        {
            return pagedList.Data.SelectMany(x => x.Value).ToList();
        }
    }
}