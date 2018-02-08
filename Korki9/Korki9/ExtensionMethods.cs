using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki9
{
    public static class ExtensionMethods
    {
        public static DateTime ToUTCDateTime(this string input)
        {
            DateTime result = default(DateTime);
            if (!DateTime.TryParseExact(input, "yyyy'-'MM'-'dd HH':'mm':'ss'Z'", (IFormatProvider)CultureInfo.CurrentCulture, DateTimeStyles.AssumeUniversal, out result))
            {
                try
                {
                    return DateTime.Parse(input);
                }
                catch
                {
                    return result;
                }
            }
            return result;
        }

        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T, int> action)
        {
            int num = 0;
            foreach (T item in enumeration)
            {
                action(item, num);
                num++;
            }
        }

        public static void ParallelSafeForEach<T>(this IEnumerable<T> enumeration, Action<T> action, int MaxDepth)
        {
            foreach (T item in enumeration)
            {
                if (MaxDepth < 1)
                {
                    action(item);
                }
                else
                {
                    MaxDepth--;
                    Parallel.Invoke(delegate
                    {
                        action((T)item);
                    });
                }
            }
        }

        public static void RemoveAll<TKey, TValue>(this Dictionary<TKey, TValue> dict, Func<KeyValuePair<TKey, TValue>, bool> condition)
        {
            foreach (KeyValuePair<TKey, TValue> item in dict.Where(condition).ToList())
            {
                dict.Remove(item.Key);
            }
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> knownKeys = new HashSet<TKey>();
            foreach (TSource item in source)
            {
                if (knownKeys.Add(keySelector(item)))
                {
                    yield return item;
                    /*Error: Unable to find new state assignment for yield return*/
                    ;
                }
            }
            yield break;
            IL_00e0:
            /*Error near IL_00e1: Unexpected return in MoveNext()*/
            ;
        }

        public static IEnumerable<KeyValuePair<string, string>> ToPairs(this NameValueCollection collection)
        {
            return from string kv in collection
                   where !string.IsNullOrWhiteSpace(kv)
                   select kv into key
                   select new KeyValuePair<string, string>(key, collection[key]);
        }

        public static IDictionary<string, string> ToDictionary(this NameValueCollection source)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (string item in source.Cast<string>())
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, source[item]);
                }
            }
            return dictionary;
        }

        public static bool ContainsKey(this JObject jObject, string key)
        {
            if (jObject != null && !string.IsNullOrEmpty(key))
            {
                if (jObject[key] != null)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static IEnumerable<string> Keys(this JObject jObject)
        {
            return from p in jObject.Properties()
                   select p.Name;
        }
    }
}
