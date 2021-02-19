using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePiggy.Caching
{
    public class CacheLocal
    {
        static readonly ObjectCache Cache = MemoryCache.Default;

        /// <summary>
        /// Retorna objeto no cache
        /// </summary>
        /// <typeparam name="T">Entidade generica de retorno</typeparam>
        /// <param name="key">Chave de itentificação do cache</param>
        /// <returns>Retorna o cache convertido no objeto esperado</returns>
        public static T Get<T>(string key) where T : class
        {
            try
            {
                return (T)Cache[key];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Adiciona um ebjeto no cache
        /// </summary>
        /// <typeparam name="T">Entidade generica de retorno</typeparam>
        /// <param name="objectToCache">Entidade de cache a ser armezenada</param>
        /// <param name="key">Chave de itentificação do cache</param>
        /// <param name="pDataCache">Data de expiração do cache</param>
        public static void Add<T>(T objectToCache, string key, DateTime pDataCache) where T : class
        {
            Cache.Add(key, objectToCache, pDataCache);
        }

        /// <summary>
        /// Insert value into the cache using
        /// appropriate name/value pairs
        /// </summary>
        /// <param name="objectToCache">Item to be cached</param>
        /// <param name="key">Name of item</param>
        public static void Add(object objectToCache, string key, DateTime pDataCache)
        {
            Cache.Add(key, objectToCache, pDataCache);
        }

        /// <summary>
        /// Remove item from cache
        /// </summary>
        /// <param name="key">Name of cached item</param>
        public static void Clear(string key)
        {
            Cache.Remove(key);
        }

        /// <summary>
        /// Check for item in cache
        /// </summary>
        /// <param name="key">Name of cached item</param>
        /// <returns></returns>
        public static bool Exists(string key)
        {
            return Cache.Get(key) != null;
        }

        /// <summary>
        /// Gets all cached items as a list by their key.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAll()
        {
            return Cache.Select(keyValuePair => keyValuePair.Key).ToList();
        }
    }
}
