﻿using System.Threading.Tasks;

namespace Core.Plugins.Caching
{
    public interface ICacheService
    {
        /// <summary>
        /// Cache is Any
        /// </summary>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(string key, int db = 0);

        /// <summary>
        /// Get Cache Entity result T
        /// </summary>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<T> GetAsync<T>(string key, int db = 0) where T : new();

        /// <summary>
        /// Get Cache result string
        /// </summary>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        Task<string> GetAsync(string key, int db = 0);
        
        /// <summary>
        /// Add or Update Cache
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="minute"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        Task SetAsync(string key, string data, int? minute = null, int db = 0);

        /// <summary>
        /// Remove Cache by key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        Task RemoveAsync(string key, int db = 0);

        /// <summary>
        /// Remove Cache by pattern
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        Task RemoveByPatternAsync(string pattern, int db = 0);
        
        /// <summary>
        /// Clear All DB Cache
        /// </summary>
        void Clear();
        
    }
}