namespace RL.Envs;

using RL.Spaces;

[PublicAPI]
public class RepeatObservation : IEnvironment<float, float, float, Box<float>, Box<float>>,
    IPseudorandom<int> {
    static readonly Box<float> Space = new(low: 0, high: 1);

    static readonly bool[] NeverDone = new bool[1];
    public float LastObservation { get; internal set; }

    Random random = new();

    public float Reset() {
        return this.LastObservation = (float)this.random.NextDouble();
    }

    public StepResult<float, float> Step(float action) {
        float reward = -Math.Abs(action - this.LastObservation);
        this.LastObservation = (float)this.random.NextDouble();
        return new StepResult<float, float>(this.LastObservation, reward, NeverDone.AsSpan());
    }


    public Box<float> ActionSpace => Space;
    public Box<float> ObservationSpace => Space;

    public void Seed(int seed) {
        this.random = new Random(seed);
    }

    public bool IsSystemIndependent => false;
}