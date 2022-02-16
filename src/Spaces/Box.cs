namespace RL.Spaces;

[PublicAPI]
public struct Box<T> : ISpace<T> {
    public T Low { get; }
    public T High { get; }

    public Box(T low, T high) {
        this.Low = low;
        this.High = high;
    }
}