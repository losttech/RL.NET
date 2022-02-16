namespace RL.Envs;

public class RepeatTests {
    [Fact]
    public void Reward() {
        var env = new RepeatObservation { LastObservation = 2 };
        var step = env.Step(-1);
        Assert.Equal(expected: -3, actual: step.Reward, precision: 1);
    }

    [Fact]
    public void Repeatable() {
        const int seed = 420;
        var env = new RepeatObservation();
        env.Seed(seed);
        float initial = env.Reset();
        env.Seed(seed);
        float rerun = env.Reset();
        Assert.Equal(expected: initial, actual: rerun, precision: 4);
    }
}