using System.Collections.Generic;

namespace JsonPagedList
{
    /// <summary>
    /// Dic extension 
    /// </summary>
    public static class DictionaryExtension
    {
        /// <summary>
        /// add or update
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="keyValuePair"></param>
        public static void AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
            KeyValuePair<TKey, TValue> keyValuePair)
        {
            if (dictionary.ContainsKey(keyValuePair.Key))
                dictionary[keyValuePair.Key] = keyValuePair.Value;
            else
                dictionary.Add(keyValuePair);
        }
    }
}
