
namespace P08.Threeuple
{
    public class Threeuple<Tfirst, Tsecond, Tthird>
    {
        public Threeuple(Tfirst first, Tsecond second, Tthird third)
        {
            this.FirstItem = first;
            this.SecondItem = second;
            this.ThirdItem = third;
        }

        public Tfirst FirstItem { get; set; }
        public Tsecond SecondItem { get; set; }
        public Tthird ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
