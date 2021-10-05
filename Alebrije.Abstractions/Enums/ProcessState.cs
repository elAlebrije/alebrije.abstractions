namespace Alebrije.Abstractions.Enums
{
    public enum ProcessState
    {
        NotInitialized = 0,
        Loading = 1,
        Idle = 2,
        Working = 3,
        WorkFinished = 4,
        CleaningEnvironment = 5,

        Dead = 500
    }
}