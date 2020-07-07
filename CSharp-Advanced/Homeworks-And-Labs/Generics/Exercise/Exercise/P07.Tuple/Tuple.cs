
namespace P07.Tuple
{
    public class Tuple<Tfirst, Tsecond>
    {
        public Tuple(Tfirst first, Tsecond second)
        {
            this.FirstItem = first;
            this.SecondItem = second;
        }

        public Tfirst FirstItem { get; set; }
        public Tsecond SecondItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem}";
        }
    }
}
