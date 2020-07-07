using System.Collections.Generic;

namespace P07.MilitaryElite.Contracts
{
    interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
        void AddPrivate(IPrivate @private);
    }
}
