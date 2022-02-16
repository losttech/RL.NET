namespace RL;

[PublicAPI]
public interface IPseudorandom<in TSeed> {
    bool IsSystemIndependent { get; }
    void Seed(TSeed seed);
}