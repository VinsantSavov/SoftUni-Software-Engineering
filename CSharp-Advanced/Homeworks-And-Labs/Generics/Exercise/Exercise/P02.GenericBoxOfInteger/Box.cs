
namespace P02.GenericBoxOfInteger
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
            return $"System.Int32: {value}";
        }
    }
}
