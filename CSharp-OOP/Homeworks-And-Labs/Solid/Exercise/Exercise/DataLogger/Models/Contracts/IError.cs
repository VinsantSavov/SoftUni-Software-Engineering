using DataLogger.Enumerations;
using System;

namespace DataLogger.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }
        Level Level { get; }
    }
}
