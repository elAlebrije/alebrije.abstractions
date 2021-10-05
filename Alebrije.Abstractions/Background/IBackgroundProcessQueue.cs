using System;
using System.Threading;
using System.Threading.Tasks;

namespace Alebrije.Abstractions.Background
{
    /// <summary>
    /// <see cref="IBackgroundProcessQueue"/> Represents a background queueing class.
    /// Will keep accepting jobs and process them as long as the Queue has not reached its limit.
    /// </summary>
    public interface IBackgroundProcessQueue
    {
        /// <summary>
        /// Sets the Queue limit.  If it reaches its limit it will stop accepting incoming jobs, until another one is popped.
        /// Can only be set once.    Default Limit is <value>1</value>
        /// </summary>
        /// <param name="limit">Queues limit.</param>
        /// <returns><value>True</value> if it could set the value - otherwise returns <value>False</value></returns>
        bool SetQueueLimit(int limit);

        /// <summary>
        /// Queues a new process to run in the background.
        /// </summary>
        /// <param name="workItem">Function/Process that will run in the background.</param>
        /// <returns>True if it could enqueue the process.</returns>
        bool QueueBackgroundProcess(Func<CancellationToken, Task> workItem);

        Task<Func<CancellationToken, Task>> DequeueProcessAsync(CancellationToken cancellationToken);
    }
}