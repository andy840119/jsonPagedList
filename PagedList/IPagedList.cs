﻿using System.Collections.Generic;

namespace JsonPagedList
{
    /// <summary>
    ///     Because <see cref="PagedList{T}" /> inherit IList will lose data on serialize data
    ///     So inherit <see cref="IPagedList{T}" /> instead
    ///     <see cref="IPagedList{T}" /> add most interface from <see cref="IList{T}" />
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public interface IPagedList<TData> : IPageMetaData
    {
        /// <summary>
        ///     Data
        /// </summary>
        IDictionary<int, IList<TData>> Data { get; }

        int CurrentPageIndex { get; set; }

        /// <summary>
        ///     Count
        /// </summary>
        int Count { get; }

        /// <summary>
        ///     IsReadOnly
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        ///     index of object
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        TData this[int index] { get; set; }

        /// <summary>
        ///     get data by index
        /// </summary>
        /// <returns></returns>
        IList<TData> GetDataByPageIndex(int pageIndex);

        /// <summary>
        ///     get data by index
        /// </summary>
        /// <returns></returns>
        IList<TData> GetDataByCurrentPageIndex();

        /// <summary>
        ///     Add
        /// </summary>
        /// <param name="item"></param>
        void Add(TData item);

        /// <summary>
        ///     Clear
        /// </summary>
        void Clear();

        /// <summary>
        ///     Contain
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Contains(TData item);

        /// <summary>
        ///     CopyTo
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        void CopyTo(TData[] array, int arrayIndex);

        /// <summary>
        ///     Remove
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Remove(TData item);

        /// <summary>
        ///     index of
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        int IndexOf(TData item);

        /// <summary>
        ///     insert
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        void Insert(int index, TData item);

        /// <summary>
        ///     remove at
        /// </summary>
        /// <param name="index"></param>
        void RemoveAt(int index);
    }
}