

namespace ChopeBastillaApplicationService.CommonDomian.ValueObject
{
    public abstract class BaseId<T>
    {
        public T Value { get; }

        public BaseId(T value)
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is BaseId<T> id &&
                   EqualityComparer<T>.Default.Equals(Value, id.Value);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
