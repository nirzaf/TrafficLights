using BlazorExamples.Pages;

namespace BlazorExamples.Domain.TrafficLight
{
    public class GetReadyToStopState : ITrafficLightState
    {
        public bool RedOn { get; } = false;
        public bool AmberOn { get; } = true;
        public bool GreenOn { get; } = false;
    }
}