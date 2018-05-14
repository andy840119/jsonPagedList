using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PagedList
{
    public interface IPagedList<TMataData, TData> where TMataData : IPageMetaData 
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
