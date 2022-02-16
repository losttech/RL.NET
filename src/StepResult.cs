namespace RL;

[PublicAPI]
public ref struct StepResult<TObservation, TReward> {
    public StepResult(TObservation observation, TReward reward, ReadOnlySpan<bool> done) {
        this.Observation = observation;
        this.Reward = reward;
        this.Done = done;
    }

    public TObservation Observation { get; }
    public TReward Reward { get; }
    public ReadOnlySpan<bool> Done { get; }
}