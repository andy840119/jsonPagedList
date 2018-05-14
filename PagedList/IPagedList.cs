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
        IList<TData> Data { get; }

        TMataData MetaData { get; }

        void Add(TData item);

        void Clear();

        bool Contains(TData item);

        void CopyTo(TData[] array, int arrayIndex);

        bool Remove(TData item);

        int Count { get; }
        bool IsReadOnly { get; }
        int IndexOf(TData item);

        void Insert(int index, TData item);

        void RemoveAt(int index);

        TData this[int index] { get;set; }
    }
}
