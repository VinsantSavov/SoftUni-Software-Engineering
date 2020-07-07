using DataLogger.Enumerations;

namespace DataLogger.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }
        Level Level { get; }
        int MessagesAppended { get; }

        void Append(IError error);
    }
}
