namespace BlazorExamples.Domain.TrafficLight
{
    public class GoState : ITrafficLightState
    {
        public bool RedOn { get; } = false;
        public bool AmberOn { get; } = false;
        public bool GreenOn { get; } = true;
    }
}