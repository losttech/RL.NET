namespace RL;

[PublicAPI]
public interface IEnvironment<TObservation, in TAction, TReward,
    out TObservationSpace, out TActionSpace>
    where TActionSpace : ISpace<TAction>
    where TObservationSpace : ISpace<TObservation> {
    TActionSpace ActionSpace { get; }
    TObservationSpace ObservationSpace { get; }

    /// <summary>
    ///     Run one step of the environment's dynamics. When end of
    ///     episode is reached, you are responsible for calling <seealso cref="Reset" />
    ///     to reset this environment's state.
    /// </summary>
    /// <param name="action">Action provided by the agent</param>
    StepResult<TObservation, TReward> Step(TAction action);

    /// <summary>
    ///     Resets the environment to an initial state.
    /// </summary>
    /// <returns>Initial observation</returns>
    /// <remarks>
    ///     If you need repeatable experiments, call
    ///     <see cref="IPseudorandom{TSeed}.Seed(TSeed)" /> before calling this method.
    /// </remarks>
    TObservation Reset();
}