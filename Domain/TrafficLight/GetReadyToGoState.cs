namespace BlazorExamples.Domain.TrafficLight
{
    public class GetReadyToGoState : ITrafficLightState
    {
        public bool RedOn { get; } = true;
        public bool AmberOn { get; } = true;
        public bool GreenOn { get; } = false;
    }
}