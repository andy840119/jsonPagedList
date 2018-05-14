using System.Collections.Generic;
using System.Linq;

namespace JsonPagedList
{
    /// <summary>
    ///     Custom PageList
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class PagedList<TData> : IPagedList<TData>
    {
        /// <summary>
        ///     Ctor
        /// </summary>
        public PagedList() : this(30)
        {
        }

        /// <summary>
        ///     Ctor
        /// </summary>
        public PagedList(int pageSize)
        {
            PageSize = pageSize;
            Data.Add(new KeyValuePair<int, IList<TData>>(PageIndex, new List<TData>()));
        }

        /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedList(IQueryable<TData> source, int pageIndex, int pageSize)
        {
            TotalCount = source.Count();
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            PageSize = pageSize;
            PageIndex = pageIndex;

            var list = source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            Data.Add(new KeyValuePair<int, IList<TData>>(PageIndex, list));
        }

        /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedList(IList<TData> source, int pageIndex, int pageSize)
        {
            TotalCount = source.Count();
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            PageSize = pageSize;
            PageIndex = pageIndex;

            var list = source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            Data.Add(new KeyValuePair<int, IList<TData>>(PageIndex, list));
        }

        /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="totalCount">Total count</param>
        public PagedList(IEnumerable<TData> source, int pageIndex, int pageSize, int totalCount)
        {
            TotalCount = totalCount;
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            PageSize = pageSize;
            PageIndex = pageIndex;

            var list = source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            Data.Add(new KeyValuePair<int, IList<TData>>(PageIndex, list));
        }

        /// <summary>
        ///     Temp page index
        /// </summary>
        protected int PageIndex { get; set; }

        /// <summary>
        ///     Data
        /// </summary>
        public IDictionary<int, IList<TData>> Data { get; } = new Dictionary<int, IList<TData>>();

        /// <summary>
        ///     page size
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        ///     total count
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        ///     total page
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        ///     Min page
        /// </summary>
        public int MinDataPage => Data.Keys.Min();

        /// <summary>
        /// </summary>
        public int MaxDataPage => Data.Keys.Max();

        /// <summary>
        ///     has pervious page
        /// </summary>
        public bool HasPreviousPage => MinDataPage > 0;

        /// <summary>
        ///     has next page
        /// </summary>
        public bool HasNextPage => MaxDataPage + 1 < TotalPages;

        /// <summary>
        ///     Add
        /// </summary>
        /// <param name="item"></param>
        public void Add(TData item)
        {
            Data[PageIndex].Add(item);
        }

        /// <summary>
        ///     Clear
        /// </summary>
        public void Clear()
        {
            Data[PageIndex].Clear();
        }

        /// <summary>
        ///     Contain
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(TData item)
        {
            return Data[PageIndex].Contains(item);
        }

        /// <summary>
        ///     CopyTo
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(TData[] array, int arrayIndex)
        {
            Data[PageIndex].CopyTo(array, arrayIndex);
        }

        /// <summary>
        ///     Remove
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(TData item)
        {
            return Data[PageIndex].Remove(item);
        }

        /// <summary>
        ///     Count
        /// </summary>
        public int Count => Data[PageIndex].Count;

        /// <summary>
        ///     IsReadOnly
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        ///     Index of
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(TData item)
        {
            return Data[PageIndex].IndexOf(item);
        }

        /// <summary>
        ///     insert
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, TData item)
        {
            Data[PageIndex].Insert(index, item);
        }

        /// <summary>
        ///     remove at
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            Data[PageIndex].RemoveAt(index);
        }

        /// <summary>
        ///     index of object
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public TData this[int index]
        {
            get => Data[PageIndex][index];
            set => Data[PageIndex][index] = value;
        }
    }
}