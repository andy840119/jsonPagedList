using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagedList
{
    public static class PagedListExtension
    {
        /// <summary>
        /// Convert IList to PagedList
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
        /// Convert IQueryable to pageList
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
        /// Convert IEnumerable to pageList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static PagedList<TData> ToPageList<TData>(this IEnumerable<TData> pagedList, int pageIndex, int pageSize, int totalCount)
        {
            var pageList = new PagedList<TData>(pagedList, pageIndex, pageSize, totalCount);
            return pageList;
        }

        /// <summary>
        /// Convert IList to PagedList
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <typeparam name="TMataData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static IPagedList<TMataData,TData> ToPageList<TMataData, TData>(this IList<TData> pagedList, int pageIndex, int pageSize) where TMataData : class, IPageMetaData, new()
        {
            var pageList = new PagedList<TMataData,TData>(pagedList, pageIndex, pageSize);
            return pageList;
        }

        /// <summary>
        /// Convert IQueryable to pageList
        /// </summary>
        /// <typeparam name="TMataData"></typeparam>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static IPagedList<TMataData, TData> ToPageList<TMataData, TData>(this IQueryable< TData> pagedList, int pageIndex, int pageSize) where TMataData : class, IPageMetaData, new()
        {
            var pageList = new PagedList<TMataData, TData>(pagedList, pageIndex, pageSize);
            return pageList;
        }

        /// <summary>
        /// Convert IEnumerable to pageList
        /// </summary>
        /// <typeparam name="TMataData"></typeparam>
        /// <typeparam name="TData"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static IPagedList<TMataData, TData> ToPageList<TMataData, TData>(this IEnumerable< TData> pagedList, int pageIndex, int pageSize, int totalCount) where TMataData : class, IPageMetaData, new()
        {
            var pageList = new PagedList<TMataData, TData>(pagedList, pageIndex, pageSize, totalCount);
            return pageList;
        }

        /// <summary>
        /// Convert pageList to IList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static IList<T> ToList<T>(this PagedList<T> pagedList, int pageIndex, int pageSize) where T : struct
        {
            return pagedList.Data;
        }

        /// <summary>
        /// Convert pageList to list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static IQueryable<T> ToPageList<T>(this PagedList<T> pagedList, int pageIndex, int pageSize) where T : struct
        {
            return pagedList.Data.AsQueryable();
        }

        /// <summary>
        /// Convert pageList to list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pagedList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static IEnumerable<T> ToPageList<T>(this PagedList<T> pagedList, int pageIndex, int pageSize, int totalCount) where T : struct
        {
            return pagedList.Data;
        }
    }
}
