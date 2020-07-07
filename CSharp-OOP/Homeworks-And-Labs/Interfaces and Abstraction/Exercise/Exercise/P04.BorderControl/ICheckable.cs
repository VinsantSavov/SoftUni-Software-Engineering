using System.Collections.Generic;

namespace P04.BorderControl.Models
{
    public interface ICheckable
    {
        string Id { get; }
        string CheckID(string lastDigits);
    }
}
