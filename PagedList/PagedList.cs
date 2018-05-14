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
            Data.Add(new KeyValuePair<int, IList<TData>>(CurrentPageIndex, new List<TData>()));
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
            CurrentPageIndex = pageIndex;

            var list = source.AsEnumerable().Skip(pageIndex * pageSize).Take(pageSize).ToList();
            Data.Add(new KeyValuePair<int, IList<TData>>(CurrentPageIndex, list));
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
            CurrentPageIndex = pageIndex;

            var list = source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            Data.Add(new KeyValuePair<int, IList<TData>>(CurrentPageIndex, list));
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
            CurrentPageIndex = pageIndex;

            var list = source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            Data.Add(new KeyValuePair<int, IList<TData>>(CurrentPageIndex, list));
        }

        /// <summary>
        ///     Temp page index
        /// </summary>
        public int CurrentPageIndex { get; set; }

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
        ///     get data by index
        /// </summary>
        /// <returns></returns>
        public IList<TData> GetDataByPageIndex(int pageIndex)
        {
            if (Data.ContainsKey(pageIndex))
                return Data[pageIndex];

            return new List<TData>();
        }

        /// <summary>
        ///     get data by index
        /// </summary>
        /// <returns></returns>
        public IList<TData> GetDataByCurrentPageIndex()
        {
            return GetDataByPageIndex(CurrentPageIndex);
        }

        /// <summary>
        ///     Add
        /// </summary>
        /// <param name="item"></param>
        public void Add(TData item)
        {
            Data[CurrentPageIndex].Add(item);
        }

        /// <summary>
        ///     Clear
        /// </summary>
        public void Clear()
        {
            Data[CurrentPageIndex].Clear();
        }

        /// <summary>
        ///     Contain
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(TData item)
        {
            return Data[CurrentPageIndex].Contains(item);
        }

        /// <summary>
        ///     CopyTo
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(TData[] array, int arrayIndex)
        {
            Data[CurrentPageIndex].CopyTo(array, arrayIndex);
        }

        /// <summary>
        ///     Remove
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(TData item)
        {
            return Data[CurrentPageIndex].Remove(item);
        }

        /// <summary>
        ///     Count
        /// </summary>
        public int Count => Data[CurrentPageIndex].Count;

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
            return Data[CurrentPageIndex].IndexOf(item);
        }

        /// <summary>
        ///     insert
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, TData item)
        {
            Data[CurrentPageIndex].Insert(index, item);
        }

        /// <summary>
        ///     remove at
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            Data[CurrentPageIndex].RemoveAt(index);
        }

        /// <summary>
        ///     index of object
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public TData this[int index]
        {
            get => Data[CurrentPageIndex][index];
            set => Data[CurrentPageIndex][index] = value;
        }
    }
}