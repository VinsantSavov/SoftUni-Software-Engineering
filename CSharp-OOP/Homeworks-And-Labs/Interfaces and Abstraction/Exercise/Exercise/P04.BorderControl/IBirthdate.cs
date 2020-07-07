namespace P04.BorderControl
{
    public interface IBirthdate
    {
        string Birthdate { get; }

        bool CheckYear(string year);
    }
}
