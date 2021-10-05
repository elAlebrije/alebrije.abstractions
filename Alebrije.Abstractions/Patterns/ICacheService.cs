using System.Threading.Tasks;

namespace Alebrije.Abstractions.Patterns
{
    public interface ICacheService
    {

        /// <summary>
        /// Gets the value of the <see cref="T"/> object that was cached with the <see cref="key"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns>Object stored with the key</returns>
        T Get<T>(string key);

        /// <summary>
        /// Sets the value of the <see cref="T"/> object to be cached with the key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Key that will identify the value to be stored.</param>
        /// <param name="value">Value to be stored.</param>
        /// <returns></returns>
        bool Set<T>(string key, T value);

        /// <summary>
        /// Gets ASYNC the value of the <see cref="T"/> object that was cached with the <see cref="key"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns>Object stored with the key</returns>
        Task<T> GetAsync<T>(string key);

        /// <summary>
        /// Sets ASYNC the value of the <see cref="T"/> object to be cached with the key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">Key that will identify the value to be stored.</param>
        /// <param name="value">Value to be stored.</param>
        /// <returns></returns>
        Task SetAsync<T>(string key, T value);
    }
}
