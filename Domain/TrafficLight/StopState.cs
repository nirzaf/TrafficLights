namespace BlazorExamples.Domain.TrafficLight
{
    public class StopState : ITrafficLightState
    {
        public bool RedOn { get; } = true;
        public bool AmberOn { get; } = false;
        public bool GreenOn { get; } = false;
    }
}