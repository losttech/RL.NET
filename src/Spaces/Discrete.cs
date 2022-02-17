namespace RL.Spaces; 

[PublicAPI]
public struct Discrete: ISpace<Int64> {
    public Int64 StateCount { get; }
    public Int64 Base { get; }

    public Discrete(Int64 stateCount, Int64 @base = 0) {
        if (stateCount <= 0)
            throw new ArgumentOutOfRangeException(nameof(stateCount), "Must be positive");
        this.StateCount = stateCount;
        this.Base = @base;
    }
}