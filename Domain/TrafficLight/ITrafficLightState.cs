namespace BlazorExamples.Domain.TrafficLight
{
    public interface ITrafficLightState
    {
        bool RedOn { get; }
        bool AmberOn { get; }
        bool GreenOn { get; }
    }
}