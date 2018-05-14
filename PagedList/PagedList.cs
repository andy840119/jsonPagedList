using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace PagedList
{
    /// <summary>
    /// Paged list with dafault metadata
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class PagedList<TData> : PagedList<PageMetaData, TData>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public PagedList()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        public PagedList(IQueryable<TData> source, int pageIndex, int pageSize) : base(source, pageIndex, pageSize)
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        public PagedList(IList<TData> source, int pageIndex, int pageSize) : base(source, pageIndex, pageSize)
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        public PagedList(IEnumerable<TData> source, int pageIndex, int pageSize, int totalCount) : base(source, pageIndex, pageSize, totalCount)
        {

        }
    }

    /// <summary>
    /// Custom PageList
    /// </summary>
    /// <typeparam name="TMataData"></typeparam>
    /// <typeparam name="TData"></typeparam>
    public class PagedList<TMataData,TData> : IPagedList<TMataData,TData> where TMataData : class, IPageMetaData , new ()
    {
        /// <summary>
        /// Data
        /// </summary>
        public IList<TData> Data { get; } = new List<TData>();

        /// <summary>
        /// Meta data
        /// </summary>
        public TMataData MetaData { get; } = new TMataData();

        /// <summary>
        /// Ctor
        /// </summary>
        public PagedList()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedList(IQueryable<TData> source, int pageIndex, int pageSize)
        {
            MetaData.TotalCount = source.Count();
            MetaData.TotalPages = MetaData.TotalCount / pageSize;

            if (MetaData.TotalCount % pageSize > 0)
                MetaData.TotalPages++;

            MetaData.PageSize = pageSize;
            MetaData.PageIndex = pageIndex;

            if (Data is List<TData> list)
            {
                list.AddRange(source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
            }
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedList(IList<TData> source, int pageIndex, int pageSize)
        {
            MetaData.TotalCount = source.Count();
            MetaData.TotalPages = MetaData.TotalCount / pageSize;

            if (MetaData.TotalCount % pageSize > 0)
                MetaData.TotalPages++;

            MetaData.PageSize = pageSize;
            MetaData.PageIndex = pageIndex;

            if (Data is List<TData> list)
            {
                list.AddRange(source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
            }
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="totalCount">Total count</param>
        public PagedList(IEnumerable<TData> source, int pageIndex, int pageSize, int totalCount)
        {
            MetaData.TotalCount = totalCount;
            MetaData.TotalPages = MetaData.TotalCount / pageSize;

            if (MetaData.TotalCount % pageSize > 0)
                MetaData.TotalPages++;

            MetaData.PageSize = pageSize;
            MetaData.PageIndex = pageIndex;

            if (Data is List<TData> list)
            {
                list.AddRange(source);
            }
        }

        public void Add(TData item)
        {
            Data.Add(item);
        }

        public void Clear()
        {
            Data.Clear();
        }

        public bool Contains(TData item)
        {
            return Data.Contains(item);
        }

        public void CopyTo(TData[] array, int arrayIndex)
        {
            Data.CopyTo(array, arrayIndex);
        }

        public bool Remove(TData item)
        {
            return Data.Remove(item);
        }

        public int Count => Data.Count;

        public bool IsReadOnly => false;

        public int IndexOf(TData item)
        {
            return Data.IndexOf(item);
        }

        public void Insert(int index, TData item)
        {
            Data.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            Data.RemoveAt(index);
        }

        [JsonIgnore]
        public TData this[int index]
        {
            get => Data[index];
            set => Data[index] = value;
        }
    }
}
