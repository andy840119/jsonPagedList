using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagedList
{
    public static class PagedListExtension
    {
        /// <summary>
        /// this is the extension that convert list to pageLIst
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagedList<T> ToPageList<T>(this IList<T> pagedList, int pageIndex, int pageSize) where T : struct
        {
            var pageList = new PagedList<T>(pagedList, pageIndex, pageSize);
            return pageList;
        }

        /// <summary>
        /// this is the extension that convert list to pageLIst
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagedList<T> ToPageList<T>(this IQueryable<T> pagedList, int pageIndex, int pageSize) where T : struct
        {
            var pageList = new PagedList<T>(pagedList, pageIndex, pageSize);
            return pageList;
        }

        /// <summary>
        /// this is the extension that convert list to pageLIst
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static PagedList<T> ToPageList<T>(this IEnumerable<T> pagedList, int pageIndex, int pageSize, int totalCount) where T : struct
        {
            var pageList = new PagedList<T>(pagedList, pageIndex, pageSize, totalCount);
            return pageList;
        }
    }
}
