
namespace P01.GenericBoxOfStrings
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"System.String: {this.value}";
        }
    }
}
