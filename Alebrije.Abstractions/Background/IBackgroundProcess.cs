using System.Threading.Tasks;
using Alebrije.Abstractions.Enums;

namespace Alebrije.Abstractions.Background
{
    public interface IBackgroundProcess<in TEnv, in TExec>
    {
        ProcessState CurrentState { get; }

        Task SetupEnvironment(TEnv envConfig);

        Task Execute(TExec workConfig);

        Task TeardownExecution();
    }
}