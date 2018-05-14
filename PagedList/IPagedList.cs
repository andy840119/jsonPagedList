using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PagedList
{
    /// <summary>
    /// Because <see cref="PagedList{T,F}"/> inherit IList will lose data on serialize data
    /// So inherit <see cref="IPagedList{T,F}"/> instead
    /// <see cref="IPagedList{T,F}"/> add most interface from <see cref="IList{T}"/>
    /// </summary>
    /// <typeparam name="TMataData"></typeparam>
    /// <typeparam name="TData"></typeparam>
    public interface IPagedList<out TMataData, TData> where TMataData : IPageMetaData 
    {
        /// <summary>
        /// Data
        /// </summary>
        IList<TData> Data { get; }

        /// <summary>
        /// Meta data
        /// </summary>
        TMataData MetaData { get; }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="item"></param>
        void Add(TData item);

        /// <summary>
        /// Clear
        /// </summary>
        void Clear();

        /// <summary>
        /// Contain
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Contains(TData item);

        /// <summary>
        /// CopyTo
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        void CopyTo(TData[] array, int arrayIndex);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Remove(TData item);

        /// <summary>
        /// Count
        /// </summary>
        int Count { get; }

        /// <summary>
        /// IsReadOnly
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// index of
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        int IndexOf(TData item);

        /// <summary>
        /// insert
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        void Insert(int index, TData item);

        /// <summary>
        /// remove at
        /// </summary>
        /// <param name="index"></param>
        void RemoveAt(int index);

        /// <summary>
        /// index of object
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        TData this[int index] { get;set; }
    }
}
