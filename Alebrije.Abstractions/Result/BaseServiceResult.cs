namespace Alebrije.Abstractions.Result
{
    // Moved near its interface to simplify casting
    /// <summary>
    /// IService Result Implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseServiceResult<T>
    {
        private T _data;
        public virtual T Data
        {
            get => _data;
            set => _data = value;
        }
    }
}