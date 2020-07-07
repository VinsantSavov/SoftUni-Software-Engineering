namespace P04.BorderControl.Models
{
    public class Robot : ICheckable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }

        public string Id { get; private set; }

        public string CheckID(string lastDigits)
        {
            if (this.Id.EndsWith(lastDigits))
            {
                return this.Id;
            }

            return null;
        }
    }
}
